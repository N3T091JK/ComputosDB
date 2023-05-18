using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputosDB.Entities.AppContext
{
     class AppContextDBComputo : DbContext
    {            
            public AppContextDBComputo() : base("conn")
            {

            }
            public DbSet<Computadoras> Computadoras { get; set; }
            public DbSet<Detallecomputadora> Detallecomputadoras { get; set; }
      
        
    }
}
