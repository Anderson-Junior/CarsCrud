using CRUD_Marcas.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Marcas.Api.Persistence
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options){ }

        public DbSet<Brand> Brands { get; set; }
    } 
}
