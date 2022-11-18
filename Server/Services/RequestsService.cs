﻿using Grpc.Core;
using InternalAPI;

namespace LyftClient.Services
{
    public class RequestsService : Requests.RequestsBase // TBA
    {
        private readonly ILogger<RequestsService> _logger;

        public RequestsService(ILogger<RequestsService> logger)
        {
            _logger = logger;
        }
    }
}
