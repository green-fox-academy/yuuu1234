using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecipeProject.Models;

namespace RecipeProject.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly RecipeProjectContext recipeProjectContext;

        public RecipeService(RecipeProjectContext recipeProjectContext)
        {
            this.recipeProjectContext = recipeProjectContext;
        }
        public async Task<IEnumerable<Recipe>> GetAllRecipes()
        {
            List<Recipe> recipes = await recipeProjectContext.Recipes.ToListAsync();
            return recipes;
        }
    }
}
