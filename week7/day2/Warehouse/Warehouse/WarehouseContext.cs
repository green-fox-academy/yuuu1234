using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Warehouse
{
    public class WarehouseContext : DbContext
    {
        
        public WarehouseContext(DbContextOptions options) : base(options)
        {
        }
    }
}
