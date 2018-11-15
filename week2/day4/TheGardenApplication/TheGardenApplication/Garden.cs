using System;
using System.Collections.Generic;
using System.Text;

namespace TheGardenApplication
{
    class Garden
    {
        public List<Flower> Flowers { get; set; }
        public List<Tree> Trees { get; set; }
        public List<int> ThirstyFlowers { get; set; }
        public List<int> ThirstyTrees { get; set; }
        private int CountThirsty=0;
        public Garden()
        {
            this.Flowers=new List<Flower>();
            this.Trees=new List<Tree>();
            this.ThirstyFlowers=new List<int>();
            this.ThirstyTrees=new List<int>();
        }

        public void AddTree(Tree t)
        {
            Trees.Add(t);
        }

        public void AddFlower(Flower f)
        {
            Flowers.Add(f);
        }

        public void FindThirsty()
        {
            for (int i=0; i < Flowers.Count; i++)
            {
                
                if (Flowers[i].IfNeedWater())
                {
                    this.ThirstyFlowers.Add(i);
                    Console.WriteLine($"the {Flowers[i].Color} flower need water");

                    this.CountThirsty++;
                }
                else
                {
                    Console.WriteLine($"the {Flowers[i].Color} flower doesn't need water");
                }
            }
            for (int j = 0; j < Trees.Count; j++)
            {
              
                if (Trees[j].IfNeedWater())
                {
                    this.ThirstyTrees.Add(j);
                    Console.WriteLine($"the {Trees[j].Color} tree need water");
                    this.CountThirsty++;
                }
                else
                {
                    Console.WriteLine($"the {Trees[j].Color} flower doesn't need water");
                }
            }

        }

        public void watering(double water)
        {
            Console.WriteLine("Watering with " + water);
            this.FindThirsty();
            if (this.CountThirsty != 0)
            {
                double eachWater = water / this.CountThirsty;

                if (ThirstyTrees.Count != 0)
                {
                    foreach (int i in ThirstyTrees)
                    {
                        Trees[i].watering(eachWater);
                    }
                }

                if (ThirstyFlowers.Count != 0)
                {
                    foreach (int j in ThirstyFlowers)
                    {
                        Flowers[j].watering(eachWater);
                    }
                }
               
            }
            
        }

    }
}
