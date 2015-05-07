using RedisCache;
using RedisTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RedisTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //开启Redis服务,TODO:此处需要修改为你Redis路径
            System.Diagnostics.Process.Start(@"D:\Program Files\redis-2.4.5\64bit\redis-server.exe");
            Console.WriteLine("--------------Redis server open success---------------");
            //Test Start
            var listSo = GetAllSalesOrder();

            AddSalesOrderToRedisCache(10);

            Console.ReadKey();
        }

        static IList<SalesOrder> GetAllSalesOrder()
        {
            using (var redisClient = RedisManager.GetClient())
            {
                var so = redisClient.GetTypedClient<SalesOrder>();
                return so.GetAll();
            }
        }

        static void AddSalesOrderToRedisCache(int count)
        {
            List<SalesOrder> listSO = new List<SalesOrder>();
            for (int i = 0; i < count; i++)
            {
                listSO.Add(new SalesOrder()
                {
                    SalesOrderNo = DateTime.Now.Ticks + new Random().Next(1, 1000).ToString(),
                    SalesOrderID = Guid.NewGuid(),
                    SalesOrderDate = DateTime.Now
                });
            }
            using (var redisClient = RedisManager.GetClient())
            {
                var so = redisClient.GetTypedClient<SalesOrder>();
                if (listSO.Count <= 1)
                {
                    so.Store(listSO.First());
                }
                else
                {
                    so.StoreAll(listSO);
                }
                Thread.Sleep(3000);
                Console.WriteLine("目前订单数量：" + so.GetAll().Count);
            }
        }
    }
}
