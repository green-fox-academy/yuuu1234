using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
namespace DisposePattern
{
    class NetworkAndFileLogger:FileLogger
    {
        private readonly HttpClient httpClient;

        public NetworkAndFileLogger(string filePath) : base(filePath)
        {
            httpClient = new HttpClient();
        }

        public override void Log(string message)
        {
            httpClient.PostAsync
                ("https://www.baidu.com/", new StringContent(message)).Wait();
        }

        protected override void Dispose(bool manualDisposing)
        {
            base.Dispose();
            if (manualDisposing)
            {
              httpClient?.Dispose();
            }
        }
    }
}
