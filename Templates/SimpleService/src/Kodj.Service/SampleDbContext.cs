using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Kodj.Service.Entities;

namespace Kodj.Service
{
    public class SampleDbContext : DbContext
    {
        public DbSet<SampleEntity> SampleEntities { get; set; }
    }
}
