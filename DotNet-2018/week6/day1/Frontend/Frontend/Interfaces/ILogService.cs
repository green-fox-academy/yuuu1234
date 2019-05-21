using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;

namespace Frontend.Interfaces
{
    public interface ILogService
    {
        void Add(Log log);
        long logEntriesCount();
        List<Log> ListLog(int? count, int? page);
    }
}
