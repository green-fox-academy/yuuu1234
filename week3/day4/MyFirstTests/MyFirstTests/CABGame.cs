using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstTests
{
    public class CABGame
    {
        private string state;
        private int count;
        public int[] Answer { get; set; }
        public int[] Input { get; set; }
        public CABGame()
        {
            Random r= new Random();
            this.Answer = new[] {r.Next(11), r.Next(11), r.Next(11), r.Next(11)};
            this.Input=new int[4];
            this.state = "playing";
            this.count = 0;
        }

        public void StartPlay()
        {
            Console.WriteLine("***********Start Playing************"); 
            while(state == "playing")
            {
                string result = "";
                this.count = 0;
                Console.WriteLine("please enter 4 numbers");
                string[] input=Console.ReadLine().Split(new char[] { ' ', ',' });
                for(int i=0;i<4;i++)
                {
                    this.Input[i] = int.Parse(input[i]);
                }

                int correctTime = 0;
                for(int i=0;i<4;i++)
                {
                    if (this.Input[i] == this.Answer[i])
                    {
                        result += "Cow ";
                        correctTime++;
                    }
                    else if (this.Input[i] != this.Answer[i] & this.Answer.Contains(this.Input[i]))
                    {
                        result += "Bull ";
 
                    }
                    else
                    {
                        result += "# ";
                    }
                }

                Console.WriteLine("this round:\nyour input:");
                foreach (var i in this.Input)
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine("\nthe result:\n"+result);
                if (correctTime == 4)
                {
                    this.state = "finished";
                }
                
            }

            Console.WriteLine("you got it");
        }

    }
}
