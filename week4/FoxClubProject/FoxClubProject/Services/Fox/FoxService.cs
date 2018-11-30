using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClubProject.Interfaces;
using FoxClubProject.Repository;
using Microsoft.EntityFrameworkCore.Query.ExpressionTranslators.Internal;

namespace FoxClubProject.Services.Fox
{
    public class FoxService : IFoxService
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
        public List<string> Tricks { get; set; }
        public List<string> ActionHistory { get; set; }
        public int FoodCapacity { get; set; }
        public int DrinkCapacity { get; set; }
        public  string[] AllTricks=new []{"python","Java","Html","c#"};
        public  string[] AllFood= new[] { "pizza", "salad", "chicken", "cookie" };
        public  string[] AllDrink=new []{ "lemmonade","coke","tea","coffe"};
        public FoxService()
        {
            this.Food = "pizza";
            this.Drink = "lemmonade";
            this.FoodCapacity = 10;
            this.DrinkCapacity = 10;
            this.Tricks = new List<string>();
            this.ActionHistory = new List<string>();
        }
        public string GetTricks()
        {
            if (this.Tricks.Count == 0 || this.Tricks==null)
            {
                return "no tricks";
            }
            else
            {
                string result = "";
                for (int i=0;i<this.Tricks.Count;i++)
                {
                    result += $"{i+1}: {Tricks[i]}\n";
                }

                return result;
            }
        }

        public void Save()
        {
            AllFoxes.Foxlist.Add(this);
        }

        public  FoxService FoxInList(string name)
        {
            foreach (var fox in AllFoxes.Foxlist)
            {
                if (fox.Name == name)
                {
                    return fox;
                }
            }

            return null;
        }

        public void Learn(string skill)
        {
            foreach (var trick in AllTricks)
            {
                if (skill == trick)
                {
                    this.Tricks.Add(skill);
                    string action = $"{DateTime.Now} : learned to code in {skill}";
                    this.ActionHistory.Add(action);
                }
            }
        }

        public bool IfLearned(string trick)
        {
            foreach (var skill in this.Tricks)
            {
                if (skill == trick)
                {
                    return true;
                }
            }

            return false;
        }

        public void ChangeFoodDrink(string name, string food, string drink)
        {
            foreach (var fox in AllFoxes.Foxlist)
            {
                if (fox.Name == name)
                {
                    
                    if (fox.Food != food)
                    {
                        fox.ActionHistory.Add($"{DateTime.Now} : Food has been changed from {fox.Food} to {food}");
                        fox.Food = food;
                    }

                    if (fox.Drink != drink)
                    {
                        fox.ActionHistory.Add($"{DateTime.Now} : Drink has been changed from {fox.Drink} to {drink}");
                        fox.Drink = drink;
                    }
                }
            }
        }


    }
}
