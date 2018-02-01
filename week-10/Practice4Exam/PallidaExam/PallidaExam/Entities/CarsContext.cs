using Microsoft.EntityFrameworkCore;
using PallidaExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaExam.Entities
{
    public class CarsContext : DbContext
    {
        public CarsContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Cars> Cars { get; set; }
    }
}
