using Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Repository.Context
{

    public class BDContext : DbContext
    {
        public BDContext(DbContextOptions<BDContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
    }

}
