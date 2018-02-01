using Microsoft.EntityFrameworkCore;
using PallidaOrientationExamReTake.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PallidaOrientationExamReTake.Entities
{
    public class WebStoreContext : DbContext
    {
        public WebStoreContext(DbContextOptions options) : base (options)
        {

        }
        public DbSet<WebStore> WebStore { get; set; }
    }
}
