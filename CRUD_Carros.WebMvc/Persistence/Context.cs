using CRUD_Carros.WebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Carros.WebMvc.Persistence
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options){ }

        public DbSet<Car> Cars { get; set; }
    }
}
