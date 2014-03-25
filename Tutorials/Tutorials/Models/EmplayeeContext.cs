using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Tutorials.Models
{
    public class EmplayeeContext : DbContext
    {
        public DbSet<Emplayee> Employees { get; set; }
    }
}