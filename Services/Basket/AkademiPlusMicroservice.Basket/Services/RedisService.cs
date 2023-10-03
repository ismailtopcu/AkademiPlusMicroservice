﻿using StackExchange.Redis;

namespace AkademiPlusMicroservice.Basket.Services
{
    public class RedisService
    {
        private readonly string _host;
        private readonly int _port;
        private ConnectionMultiplexer _multiplexer;

        public RedisService( string host,int port)
        {

            _port = port;
            _host = host;
        }

        public void Connect() => _multiplexer = ConnectionMultiplexer.Connect($"{_host}:{_port}");
        public IDatabase GetDb(int db =1) => _multiplexer.GetDatabase(db);
    }
}
