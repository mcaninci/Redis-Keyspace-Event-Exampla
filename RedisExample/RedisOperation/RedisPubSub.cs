using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedisExample.RedisPubSubHelper
{
    public class RedisPubSub
    {

        private readonly string notificationKey = "__keyspace@2__:CachedData";
        private ConnectionMultiplexer connection;
        public RedisPubSub(ConnectionMultiplexer connection)
        {
            this.connection = connection;
        }

        public ISubscriber GetSubscriber()
        {
            return connection.GetSubscriber();
        }
        public  void SetSubscriberForNotification()
        {
            this.GetSubscriber().Subscribe(notificationKey, (channel, value) =>
            {
                Console.WriteLine("Redis keyevent triggered : " +value);

            });
        }
    }
}