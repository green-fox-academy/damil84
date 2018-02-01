using Microsoft.EntityFrameworkCore;
using PallidaOrientationExamReTake.Models;

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
