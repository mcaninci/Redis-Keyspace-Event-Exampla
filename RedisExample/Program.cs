using RedisExample.RedisConnection;
using RedisExample.RedisPubSubHelper;
using System;

namespace RedisExample
{
    class Program
    {
        public static RedisConnectionHelper redisConnectionHelper;
        static void Main(string[] args)
        {
            redisConnectionHelper = new RedisConnectionHelper();
            var redisConnction = redisConnectionHelper.Connect();
            RedisPubSub redisPubSub=new RedisPubSub(redisConnction);
            redisPubSub.SetSubscriberForNotification();
            Console.WriteLine("Connection açıldı ve Subscribe Key Notification tanımlandı.");
                 string line;
                    while ((line = Console.ReadLine()) != null)
                    {
                       if(!string.IsNullOrWhiteSpace(line))
                       break;
                    }
        }
    }
}
