using System;

namespace TheGardenApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Flower pink=new Flower("pink");
            pink.WaterAmount = 8;
            
            Flower blue=new Flower("blue");
            blue.WaterAmount = 3;
        
            Tree green=new Tree("green");
            green.WaterAmount = 20;
            Tree brown=new Tree("brown");
            brown.WaterAmount = 5;
            Garden garden=new Garden();
            garden.AddFlower(pink);
            garden.AddFlower(blue);
            garden.AddTree(green);
            garden.AddTree(brown);
            garden.watering(40);
        }
    }
}
