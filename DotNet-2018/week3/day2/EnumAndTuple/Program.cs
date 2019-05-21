using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace EnumAndTuple
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 3;
            switch (choice)
            {
                //cars
                case 1:
                    List<Car> cars = new List<Car>();
                    //int count = 0;
                    for (int i = 0; i < 256; i++)
                    {
                        Random random = new Random();
                        Array type = Enum.GetValues(typeof(Car.CarType));
                        Array color = Enum.GetValues(typeof(Car.CarColor));
                        Car.CarType randomType = (Car.CarType)type.GetValue(random.Next(type.Length));
                        Car.CarColor randomColor = (Car.CarColor)type.GetValue(random.Next(color.Length));
                        cars.Add(new Car(randomType, randomColor));
                    }

                    foreach (var car in CountSameType(cars))
                    {
                        Console.WriteLine(car.Key + "-->" + car.Value);
                    }
                    foreach (var car in CountSameColor(cars))
                    {
                        Console.WriteLine(car.Key + "-->" + car.Value);
                    }
                    Console.WriteLine(MostFrequentCar(cars));
                    break;
                //cards
                case 2:
                    Console.WriteLine("Welcome to card game");
                    Game cardGame = new Game();
                    cardGame.AskDraw();
                    break;
                //product tuple
                case 3:
                    Product p=new Product("brush",20,30);
                    var (name, oprice, nprice) = p.GetDiscount();
                    Console.WriteLine($"name {name} old price {oprice} new price {nprice}");
                    break;

            }
           
          
        }

        static Dictionary<string,int> CountSameType(List<Car> carlist)
        {
            Dictionary<string, int> typeCount = new Dictionary<string, int>();
            foreach (var car in carlist)
            {
                string t = car.Type.ToString();          
                try
                {
                    typeCount[t] += 1;
                }
                catch
                {
                    typeCount.Add(t,1);
                }
            }

            return typeCount;


        }

        static Dictionary<string,int> CountSameColor(List<Car> carlist)
        {
            Dictionary<string, int> colorCount = new Dictionary<string, int>();
            foreach (var car in carlist)
            {
                string c = car.Color.ToString();
                try
                {
                    colorCount[c]+=1;
                }
                catch
                {
                    colorCount.Add(c, 1);
                }
            }

            return colorCount;
        }

        static string MostFrequentCar(List<Car> carlist)
        {
            var mylist = CountSameType(carlist).ToList();
            mylist.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));
            return mylist[mylist.Count-1].Key;
        }

        static List<Order> GenerateOrder()
        {
            List<Order> orderlist=new List<Order>();
            for (int i = 0; i < 100; i++)
            {
                orderlist.Add(new Order());
            }

            return orderlist;
        }
        
        static (string, int, double) FindPopular(List<Order> orders)
        {
           List<(string, int, double)> countOrder=new List<(string, int, double)>();
            foreach (var o in orders)
            {
                foreach (var l in countOrder)
                {
                   
                }
            }


        }
    }
}
