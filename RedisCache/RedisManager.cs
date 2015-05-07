using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisCache
{
    public class RedisManager
    {
        /// <summary>
        /// redis配置文件信息
        /// </summary>
        private static RedisConfig redisConfig = RedisConfig.GetRedisConfig();

        private static PooledRedisClientManager redisClientManager;

        /// <summary>
        /// 初始化链接池管理对象
        /// </summary>
        static RedisManager()
        {
            CreateManager();
        }

        /// <summary>
        /// 使用redis配置对象初始化连接池管理对象
        /// </summary>
        private static void CreateManager()
        {
            string[] readServerList = redisConfig.ReadServerList.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] writeServerList = redisConfig.WriteServerList.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            redisClientManager = new PooledRedisClientManager(writeServerList, readServerList, new RedisClientManagerConfig
            {
                MaxReadPoolSize = redisConfig.MaxReadPoolSize,
                MaxWritePoolSize = redisConfig.MaxWritePoolSize,
                AutoStart = redisConfig.AutoStart
            });
        }

        /// <summary>
        /// 获取redis客服端操作对象
        /// </summary>
        /// <returns></returns>
        public static IRedisClient GetClient()
        {
            if (null==redisClientManager)
            {
                CreateManager();
            }
            return redisClientManager.GetClient();
        }
    }
}
