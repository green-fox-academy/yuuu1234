using System;
using System.Collections.Generic;
using System.Text;

namespace Pirate_exam
{
    class Pirate
    {
        public int drinkCount = 0;
        public string state = "Alive";
        public void DrinkSomeRum()
        {
            this.drinkCount++;
        }

        public string HowsItGoingMate()
        {
            if ((this.drinkCount >= 0) & (this.drinkCount <= 4))
            {
                return "Pour me anudder!";
            }
            else
            {
                return "Arghh, I'ma Pirate. How d'ya d'ink its goin?";
            }
        }

        public string Die()
        {
            this.state = "Dead";
            return "He's dead";
        }

        public void Brawl(Pirate x)
        {
            Random rt=new Random();
            int outcome=rt.Next(1, 4);
            if (outcome == 1)
            {
                this.Die();
            }else if (outcome == 2)
            {
                x.Die();
            }else
            {
                x.Die();
                this.Die();
            }
        }
    }
}
