using Firmayönetimsistemi;
using Microsoft.EntityFrameworkCore;

namespace Firmayönetimsistemi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) { }
        public DbSet<Firmalar> Firmalars { get; set; }
        public DbSet<Siparis> Siparies { get; set; }
        public DbSet<Urunler> Urunlers { get; set; }
    }
}
