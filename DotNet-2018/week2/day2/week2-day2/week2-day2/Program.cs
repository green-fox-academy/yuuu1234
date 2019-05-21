using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Sources;

namespace week2_day2
{
    class Program
    {
     
        
        static void Main(string[] args)
        {
            
            PostIt postit1 = new PostIt("Orange", "idea 1", "blue");
            PostIt postit2 = new PostIt("pink", "Awesome", "black");
            PostIt postit3 = new PostIt("yellow", "Superb", "green");
            BlogPost b1 = new BlogPost("John Doe", "Lorem ipsum", "Lorem ipsum dolor sit amet.", "2000.05.04");
            BlogPost b2 = new BlogPost(" Tim Urban", "Wait but why",
                "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10");
            BlogPost b3 = new BlogPost(" William Turton", "ne Engineer Is Trying to Get IBM to Reckon With Trump",
                "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.",
                "2017.03.28");
            Animal animal = new Animal();
            //Console.WriteLine(animal.hunger);


            //Pokemon
            List<Pokemon> pokemonOfAsh = InitializePokemon();

            // Every pokemon has a name and a type.
            // Certain types are effective against others, e.g. water is effective against fire.

            // Ash has a few pokemon.
            // A wild pokemon appeared!

            Pokemon wildPokemon = new Pokemon("Oddish", "leaf", "water");
            string choose = "";

            // Which pokemon should Ash use?
            foreach (Pokemon p in pokemonOfAsh)
            {
                if (p.IsEffectiveAgainst(wildPokemon))
                {
                    choose = p.Name;
                    break;
                }
            }

            Console.WriteLine($"I choose you,{choose}");


            var fleet = new Fleet();
            // Create a fleet of things to have this output:
            // 1. [ ] Get milk
            // 2. [ ] Remove the obstacles
            // 3. [x] Stand up
            // 4. [x] Eat lunch
            // Hint: You have to create a Print method also
            Thing thing1 = new Thing("Get milk");
            fleet.Add(thing1);
            Thing thing2 = new Thing("Remove the obstacles");
            fleet.Add(thing2);
            Thing thing3 = new Thing("Stand up");
            thing3.Complete();
            fleet.Add(thing3);
            Thing thing4 = new Thing("Eat lunch");
            thing4.Complete();
            fleet.Add(thing4);
            PrintThings(fleet);

            //Diceset
            DiceSet diceset = new DiceSet();
            diceset.Roll();
           
            while (true)
            {
                if (diceset.GetCurrent().Distinct().Count() == 1)
                {
                    break;
                }
                else
                {
                    diceset.Reroll();
                }
            }
            foreach (int i in diceset.GetCurrent())
            {
                Console.WriteLine(i);
            }


            //Domino
            var dominoes = InitializeDominoes();
            // You have the list of Dominoes
            // Order them into one snake where the adjacent dominoes have the same numbers on their adjacent sides
            // Create a function to write the dominous to the console in the following format
            // eg: [2, 4], [4, 3], [3, 5] ...
            
            List<Domino> reorder=new List<Domino>();
            
            reorder.Add(dominoes[0]);

            while (reorder.Count != dominoes.Count)
            {
                foreach (Domino d in dominoes)
                {

                    if ((d.GetValues()[0] == reorder[reorder.Count - 1].GetValues()[1]) & (!reorder.Contains(d)))
                    {
                        reorder.Add(d);

                    }


                }
            }
            

            foreach (Domino d in reorder)
            {
                Console.WriteLine(d.GetValues()[0]+" "+d.GetValues()[1]);
            }
        }

        private static List<Pokemon> InitializePokemon()
        {
            return new List<Pokemon>
            {
                new Pokemon("Balbasaur", "leaf", "water"),
                new Pokemon("Pikatchu", "electric", "water"),
                new Pokemon("Charizard", "fire", "leaf"),
                new Pokemon("Balbasaur", "water", "fire"),
                new Pokemon("Kingler", "water", "fire")
            };
        }

        static void PrintThings(Fleet f)
        {
            foreach (Thing i in f.GetThingList())
            {
                if (i.IfComplete())
                {
                    Console.WriteLine("[X] " + i.getName());
                }
                else
                {
                    Console.WriteLine("[ ] " + i.getName());
                }
            }
        }

        public static List<Domino> InitializeDominoes()
        {
            var dominoes = new List<Domino>();
            dominoes.Add(new Domino(5, 2));
            dominoes.Add(new Domino(4, 6));
            dominoes.Add(new Domino(1, 5));
            dominoes.Add(new Domino(6, 7));
            dominoes.Add(new Domino(2, 4));
            dominoes.Add(new Domino(7, 1));
            return dominoes;
        }


    }
        
       
    
}
