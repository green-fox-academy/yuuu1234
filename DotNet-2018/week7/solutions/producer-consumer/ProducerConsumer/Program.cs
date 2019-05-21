using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfConsumers = Environment.ProcessorCount;
            Consumer[] consumers = new Consumer[numberOfConsumers];
            var cancellationTokenSource = new CancellationTokenSource();
            var blockingCollection = new BlockingCollection<Page>();

            for (int i = 0; i < numberOfConsumers; i++)
            {
                var consumer = new Consumer(cancellationTokenSource.Token, blockingCollection);
                consumers[i] = consumer;
                consumer.Start();
            }

            var pages = File.ReadAllLines("urls.txt");

            var producerTasks = new List<Task>();
            
            foreach (var page in pages)
            {
                var producer = new Producer(blockingCollection, page, cancellationTokenSource.Token);

                try
                {
                    producerTasks.Add(producer.Run());
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e);
                }
            }

            string userInput;
            do
            {
                userInput = Console.ReadLine();
                blockingCollection.Add(new Page { Text = userInput }, cancellationTokenSource.Token);
            } while (userInput != "q");

            cancellationTokenSource.Cancel();

            Task.WaitAll(producerTasks.ToArray());

            foreach (var consumer in consumers)
            {
                consumer.Wait();
            }

            Console.WriteLine("Hello World!");
        }
    }
}
