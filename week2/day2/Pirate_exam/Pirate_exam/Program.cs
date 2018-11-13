using System;

namespace Pirate_exam
{
    class Program
    {
        static void Main(string[] args)
        {
           //BattleApp
            Ship ship1=new Ship();
            ship1.FillShip();
            Console.WriteLine(ship1.ShipInformation());
            Ship ship2=new Ship();
            ship2.FillShip();
            Console.WriteLine(ship1.ShipInformation());
            ship1.Battle(ship2);
            Console.WriteLine(ship1.ShipInformation());

            //Armada
            Armada armada1=new Armada();
            armada1.FillArmada(ship1);
            armada1.FillArmada(ship2);
            Armada armada2 = new Armada();
            Ship ship3 = new Ship();
            ship1.FillShip();
            Ship ship4 = new Ship();
            ship4.FillShip();
            armada2.FillArmada(ship3);
            armada2.FillArmada(ship4);
            armada1.War(armada2);

        }
    }
}
