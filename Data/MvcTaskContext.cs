using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PD1_PZ_109602_202103.Models;

namespace PD1_PZ_109602_202103.Data
{
    public class MvcTaskContext : DbContext
    {
        public MvcTaskContext(DbContextOptions<MvcTaskContext> options)
        : base(options)
        {
        }
        public DbSet<MyTask> MyTask { get; set; }
    }
}
