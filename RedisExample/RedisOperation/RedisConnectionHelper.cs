using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedisExample.RedisConnection
{
    public class RedisConnectionHelper
    {
        private static string RedisConnectionStr= "localhost,password=redis@redis123,syncTimeout=10000";
        private static int RedisDb = 2;
        private  ConnectionMultiplexer connection;
        private  IDatabase database;
        private static readonly object padlock = new object();

        private static RedisConnectionHelper instance = null;

        public ConnectionMultiplexer Connect()
        {
            connection = ConnectionMultiplexer.Connect(RedisConnectionStr);
            database = connection.GetDatabase(RedisDb);

            return connection;
        }
    }
}
