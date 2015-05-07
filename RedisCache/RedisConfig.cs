using System.Configuration;

namespace RedisCache
{
    /// <summary>
    /// Redis配置Section配置信息
    /// </summary>
    public sealed class RedisConfig :ConfigurationSection
    {
        #region Static Method
        /// <summary>
        /// 获取默认Redis的Section节点配置信息(默认节点名：RedisConfig)
        /// </summary>
        /// <returns></returns>
        public static RedisConfig GetRedisConfig()
        {
            return GetRedisConfig("RedisConfig");
        }

        /// <summary>
        /// 获取指定名称的Redis的Section节点配置信息
        /// </summary>
        /// <param name="sectionName"></param>
        /// <returns></returns>
        public static RedisConfig GetRedisConfig(string sectionName)
        {
            return (RedisConfig)ConfigurationManager.GetSection(sectionName);
        } 
        #endregion

        #region Property
        /// <summary>
        /// 以","隔开的写操作的Redis服务器地址
        /// </summary>
        [ConfigurationProperty("WriteServerList", IsRequired = false)]
        public string WriteServerList
        {
            get
            {
                return (string)base["WriteServerList"];
            }
            set
            {
                base["WriteServerList"] = value;
            }
        }

        /// <summary>
        /// 以","隔开的读操作的Redis服务器地址
        /// </summary>
        [ConfigurationProperty("ReadServerList", IsRequired = false)]
        public string ReadServerList
        {
            get
            {
                return (string)base["ReadServerList"];
            }
            set
            {
                base["ReadServerList"] = value;
            }
        }

        /// <summary>
        /// 写操作支持的最大连接数(默认:5)
        /// </summary>
        [ConfigurationProperty("MaxWritePoolSize", IsRequired = false, DefaultValue = 5)]
        public int MaxWritePoolSize
        {
            get
            {
                int _maxWritePoolSize = (int)base["MaxWritePoolSize"];
                return _maxWritePoolSize > 0 ? _maxWritePoolSize : 5;
            }
            set
            {
                base["MaxWritePoolSize"] = value;
            }
        }


        /// <summary>
        /// 读操作支持的最大连接数(默认:5)
        /// </summary>
        [ConfigurationProperty("MaxReadPoolSize", IsRequired = false, DefaultValue = 5)]
        public int MaxReadPoolSize
        {
            get
            {
                int _maxReadPoolSize = (int)base["MaxReadPoolSize"];
                return _maxReadPoolSize > 0 ? _maxReadPoolSize : 5;
            }
            set
            {
                base["MaxReadPoolSize"] = value;
            }
        }


        /// <summary>
        /// 是否自动启动(默认:true)
        /// </summary>
        [ConfigurationProperty("AutoStart", IsRequired = false, DefaultValue = true)]
        public bool AutoStart
        {
            get
            {
                return (bool)base["AutoStart"];
            }
            set
            {
                base["AutoStart"] = value;
            }
        }



        /// <summary>
        /// 本地缓存到期时间,单位:秒(默认:1)
        /// </summary>
        [ConfigurationProperty("LocalCacheTime", IsRequired = false, DefaultValue = 36000)]
        public int LocalCacheTime
        {
            get
            {
                return (int)base["LocalCacheTime"];
            }
            set
            {
                base["LocalCacheTime"] = value;
            }
        }


        /// <summary>
        /// 是否记录日志,该设置仅用于排查redis运行时出现的问题,如redis工作正常,请关闭该项
        /// </summary>
        [ConfigurationProperty("RecordeLog", IsRequired = false, DefaultValue = false)]
        public bool RecordeLog
        {
            get
            {
                return (bool)base["RecordeLog"];
            }
            set
            {
                base["RecordeLog"] = value;
            }
        } 
        #endregion
    }
}
