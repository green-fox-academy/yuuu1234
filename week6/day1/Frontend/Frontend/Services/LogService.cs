using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Interfaces;
using Frontend.Models;

namespace Frontend.Services
{
    public class LogService : ILogService
    {
        private readonly ApplicationContext _applicationContext;

        public LogService(ApplicationContext applicationContext)
        {
            this._applicationContext = applicationContext;
        }
        public void Add(Log log)
        {
            _applicationContext.Add(log);
            _applicationContext.SaveChanges();
        }

        public List<Log> ListLog(int? count, int? page)
        {
            throw new NotImplementedException();
        }


        public long logEntriesCount()
        {
            long count = 0;
            foreach (var log in _applicationContext.Logs)
            {
                count++;
            }

            return count;
        }

    }
}
