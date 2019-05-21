using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week4day1workshop.Models
{
    public class Greeting
    {
        public long Id { get; set; }
        public string Content { get; set; }
        private static long count;
        public string Hello { get; set; }
        private string[] hellos = {"Mirëdita", "Ahalan", "Parev", "Zdravei", "Nei Ho", "Dobrý den", "Ahoj", "Goddag", "Goede dag, Hallo", "Hello", "Saluton", "Hei", "Bonjour",
            "Guten Tag", "Gia'sou", "Aloha", "Shalom", "Namaste", "Namaste", "Jó napot", "Halló", "Helló", "Góðan daginn", "Halo", "Aksunai", "Qanuipit", "Dia dhuit",
            "Salve", "Ciao", "Kon-nichiwa", "An-nyong Ha-se-yo", "Salvëte", "Ni hao", "Dzien' dobry", "Olá", "Bunã ziua", "Zdravstvuyte", "Hola", "Jambo", "Hujambo", "Hej",
            "Sa-wat-dee", "Merhaba", "Selam", "Vitayu", "Xin chào", "Hylo", "Sut Mae", "Sholem Aleychem", "Sawubona"};

        public string Color { get; set; }
        public string Font { get; set; }

        private string[] colors =
        {
            "#000000", "#FFEBCD", "#8A2BE2", "#A52A2A", "#DEB887", "#5F9EA0", "#7FFF00",
            "#6495ED", "#00008B", "#DC143C", "#006400", "#8B0000", "	#FF1493"
        };

        private string[] fonts = {"10px","15px","20px","25px","30px","35px"};      
        public Greeting()
        {
            Random r = new Random();
            count +=1;
            this.Id = count;
            if (count > hellos.Length)
            {
                count -= hellos.Length;
            }

            this.Hello = hellos[count];
            this.Color = colors[r.Next(colors.Length)];
            this.Font = fonts[r.Next(fonts.Length)];
        }
    }
}
