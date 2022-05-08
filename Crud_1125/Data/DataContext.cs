using Crud_1125.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_1125.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
