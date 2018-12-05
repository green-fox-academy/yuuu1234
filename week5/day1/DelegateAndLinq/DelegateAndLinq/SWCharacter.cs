using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace DelegateAndLinq
{
    class SWCharacter
    {
        //name;height;mass;hair_color;skin_color;eye_color;birth_year;gender
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string HairColor { get; set; }
        public string SkinColor { get; set; }
        public string EyeColor { get; set; }
        public string BirthYear { get; set; }
        public string Gender { get; set; }

        public SWCharacter(string name,string height, string mass, string hair_color, string skin_color, string eye_color, string birth_year, string gender)
        {
            this.Name = name;
            this.Height = height;
            this.Mass = mass;
            this.HairColor = hair_color;
            this.SkinColor = skin_color;
            this.EyeColor = eye_color;
            this.BirthYear = birth_year;
            this.Gender = gender;

        }

    }
}
