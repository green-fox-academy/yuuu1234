using System;
using System.Collections.Concurrent;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    public class Producer
    {
        private readonly BlockingCollection<Page> blockingCollection;
        private readonly string url;
        private readonly CancellationToken cancellationToken;

        public Producer(BlockingCollection<Page> blockingCollection, string url, CancellationToken cancellationToken)
        {
            this.blockingCollection = blockingCollection;
            this.url = url;
            this.cancellationToken = cancellationToken;
        }

        public Task Run()
        {
            // use async instead
            return Task.Run(() =>
            {
                using (WebClient webClient = new WebClient())
                {
                    Console.WriteLine("Download started");

                    var body = webClient.DownloadData(url);

                    Console.WriteLine("Download finished");

                    if (cancellationToken.IsCancellationRequested)
                    {
                        return;
                    }

                    blockingCollection.Add(new Page
                    {
                        Text = Encoding.UTF8.GetString(body),
                        Url = url
                    }, cancellationToken);
                }
            });
        }
    }
}