using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeProject.Models
{
    public class Ingredient
    {
        public long IngredientId { get; set; }
        public int Amount { get; set; }
        public string Unit { get; set; }
        public string Name { get; set; }

    }
}
