using System;
using System.Collections.Generic;
using System.Text;

namespace Pirate_exam
{
    class Ship
    {
        public List<Pirate> crew=new List<Pirate>();
        public Pirate captain;
        public int aliveCrew;
        public int score;
        public int rum;
        public Ship()
        {
            score = 0;
            rum = 0;
        }

        public void FillShip()
        {
            Random rt =new Random();
            int crewNumber = rt.Next(100);
            
            while (crewNumber > 0)
            {
                this.crew.Add(new Pirate());
                crewNumber--;
            }
            this.captain=new Pirate();
            this.crew.Add(captain);
            this.aliveCrew =this.crew.Count;
        }

        public string ShipInformation()
        {
            return $"Captain consumes {this.captain.drinkCount} drinks and {this.captain.state}\n" +
                   $"the number of alive crew: {this.aliveCrew}";
        }

        public bool Battle(Ship othership)
        {
            Random rt =new Random();
            int death = rt.Next(1, this.aliveCrew + 2);
            this.aliveCrew -= death;
            this.score = this.aliveCrew - (this.captain.drinkCount);
            int otherShipDeath = rt.Next(1, othership.aliveCrew + 2);
            othership.aliveCrew -= otherShipDeath;
            othership.score = othership.aliveCrew - (othership.captain.drinkCount);
            int awards =rt.Next(100);

            if (this.score > othership.score)
            {
                this.rum = awards;
                return true;
            }
            else
            {
                othership.rum = awards;
                return false;
            }

        }


    }
}
