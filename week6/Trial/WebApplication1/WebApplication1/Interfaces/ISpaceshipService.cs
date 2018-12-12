using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Interfaces
{
    public interface ISpaceshipService
    {
        void ChangeTheLocation(long id);
        void DecreaseUltilization();
        void IncreaseUltilization();
        int GetUltilization();
    }
}
