using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftsCarrier
{
    class Carrier
    {
        public List<Aircraft> Aircrafts { get; set; }
        public int AmmoStorage { get; set; }
        public int HealthPoint { get; set; }

        private int totalDamage=0;
        public int TotalDamage
        {
            get
            {
                foreach (Aircraft a in Aircrafts)
                {
                    this.totalDamage += (a.BaseDamage * a.Ammo);
                }

                return this.totalDamage;
            }
            set {throw new Exception("You can't set this!"); }
        }

        public Carrier(int store, int health)
        {
            this.AmmoStorage = store;
            this.HealthPoint = health;
            this.Aircrafts=new List<Aircraft>();
        }

        public void Add(Aircraft a)
        {
            this.Aircrafts.Add(a);
        }

        public bool IfStorageEnough()
        {
            int need = 0;
            foreach (Aircraft a in Aircrafts)
            {
                if (a.Type == "F16")
                {
                    need += (8 - a.Ammo);
                }else if (a.Type == "F35")
                {
                    need += (12 - a.Ammo);
                }
            }

            if (need > this.AmmoStorage)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Fill()
        {
           
            if (this.AmmoStorage ==0)
            {
                throw new Exception("There is no ammo in strore!");
                
            }
            else
            {
                if(this.IfStorageEnough())
                {
                    foreach (Aircraft a in this.Aircrafts)
                    {
                        if (this.AmmoStorage == 0)
                        {
                            throw new Exception("There is no ammo in strore!");
                        }
                        this.AmmoStorage = a.Refill(this.AmmoStorage);
                    }
                }
                else
                {
                    foreach (Aircraft a in this.Aircrafts)
                    {
                        if (a.Type == "F35")
                        {
                            if (this.AmmoStorage == 0)
                            {
                                throw new Exception("There is no ammo in strore!");
                            }
                            this.AmmoStorage = a.Refill(this.AmmoStorage);
                        }
                    }

                    foreach (Aircraft a in this.Aircrafts)
                    {
                        if (a.Type == "F16")
                        {
                            if (this.AmmoStorage == 0)
                            {
                                throw new Exception("There is no ammo in strore!");
                            }
                            this.AmmoStorage = a.Refill(this.AmmoStorage);
                        }
                    }
                }
            }
            
        }

        public void fight(Carrier another)
        {
            int hasDamage=0;
            foreach (Aircraft a in another.Aircrafts)
            {
                hasDamage += a.Damage * a.Ammo;
            }

            this.HealthPoint -= hasDamage;
            
        }

        public string GetStatus()
        {
            string result = "";
            result =
                $"HP:{this.HealthPoint},  Aircraft count: {this.Aircrafts.Count}," +
                $" Ammo Storage: {this.AmmoStorage}, Total damage: {this.TotalDamage}\n" +
                $"Aircrafts:\n";
            foreach (Aircraft a in Aircrafts)
            {
                result += $"Type {a.Type}, Ammo: {a.Ammo}, Base Damage: {a.BaseDamage}, All Damage: {a.Damage}\n";
            }

            return result;

        }


    }
}
