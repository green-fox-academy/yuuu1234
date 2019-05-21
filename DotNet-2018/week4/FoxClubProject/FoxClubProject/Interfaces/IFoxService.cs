using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoxClubProject.Services.Fox;

namespace FoxClubProject.Interfaces
{
    public interface IFoxService
    {
        string GetTricks();
        void Save();
        FoxService FoxInList(string name);
        void Learn(string skill);
        bool IfLearned(string trick);
        void ChangeFoodDrink(string name, string food, string drink);
        


    }
}
