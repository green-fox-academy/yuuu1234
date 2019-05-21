using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    internal class Consumer
    {
        private readonly CancellationToken cancellationToken;
        private readonly BlockingCollection<Page> blockingCollection;
        private readonly Task task;

        public Consumer(CancellationToken cancellationToken, BlockingCollection<Page> blockingCollection)
        {
            this.cancellationToken = cancellationToken;
            this.blockingCollection = blockingCollection;
            task = new Task(Consume, cancellationToken, TaskCreationOptions.LongRunning);
        }

        private void Consume()
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var page = blockingCollection.Take(cancellationToken);

                var htmlStatistics = new HtmlStatistics(page.Text, page.Url);

                Console.WriteLine(htmlStatistics.GetWordCount());
                Console.WriteLine(htmlStatistics.GetSentenceCount());

                foreach (var imageLink in htmlStatistics.GetImageLinks())
                {
                    Console.WriteLine(imageLink);
                }

                foreach (var link in htmlStatistics.GetLinks())
                {
                    Console.WriteLine(link);
                }
            }
        }

        public void Start()
        {
            task.Start();
        }

        public void Wait()
        {
            task.Wait();
        }
    }
}