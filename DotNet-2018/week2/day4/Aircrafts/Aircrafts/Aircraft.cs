using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftsCarrier
{
    class Aircraft
    {
        
        public string Type { get; set; }

        public int Ammo { get; set; }
        public int Damage { get; set; }
        public int BaseDamage { get; set; }
        public int MaxAmmo { get; set; }

        public Aircraft(string type)
        {
            if (type== "F16" || type == "f16") 
            {
                this.Type = type;
                this.BaseDamage = 30;
                this.MaxAmmo = 8;
            }else if (type == "F35" || type == "f35")
            {
                this.Type = type;
                this.BaseDamage = 50;
                this.MaxAmmo = 12;
            }
            else
            {
                throw  new Exception("wrong type!");
            }
            this.Ammo = 0;
        }

        public Aircraft(string type, int ammo)
        {
            
            if((this.Type =="F16" || this.Type == "f16")&(ammo < 8 & ammo > 0))
            {
                this.Type = "F16";
                this.Ammo = ammo;
                this.BaseDamage = 30;
                this.MaxAmmo = 8;
            }else if ((this.Type == "F35" || this.Type == "f35") & (ammo < 12 & ammo > 0))
            {
                this.Type = "F35";
                this.Ammo = ammo;
                this.BaseDamage = 50;
                this.MaxAmmo = 12;
            }
            else
            {
                throw new Exception("wrong type or ammo!");
            }
        }

        public void TrackAmmo()
        {
            Console.WriteLine(this.Ammo);
        }

        public void Fight()
        {
            this.Damage = this.BaseDamage * this.Ammo;
            this.Ammo = 0;
        }

        public int Refill(int refill)
        {
            
            if (refill < (this.MaxAmmo - this.Ammo))
            {
                this.Ammo += refill;
                return 0;
            }
            else
            {
                this.Ammo = this.MaxAmmo;
                return refill - (this.MaxAmmo - this.Ammo);
            }
        }

        public string GetType()
        {
            return this.Type;
        }

        public string GetSatus()
        {
            return $"Type {this.Type}, Ammo: {this.Ammo}, Base Damage: {this.BaseDamage}, All Damage: {this.Damage}";
        }

        public bool IsPriority()
        {
            return (this.Type == "F35") ? true : false;
        }

    }
}
