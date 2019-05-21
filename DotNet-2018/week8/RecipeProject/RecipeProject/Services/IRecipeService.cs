using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RecipeProject.Models;

namespace RecipeProject.Services
{
    public interface IRecipeService
    {
        Task<IEnumerable<Recipe>> GetAllRecipes();
    }
}
