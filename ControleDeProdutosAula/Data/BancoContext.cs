

using ControleDeProdutosAula.Models;
using Microsoft.EntityFrameworkCore;
using System.Transactions;

namespace ControleDeProdutosAula.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : 
         base(options)
        { 
        
        }
        
        public DbSet<ProdutoModel> Produtos { get; set; }  
        
    }
}
