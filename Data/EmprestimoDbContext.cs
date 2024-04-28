using ControleEmprestimo.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEmprestimo.Data
{
    public class EmprestimoDbContext : DbContext
    {

        public EmprestimoDbContext(DbContextOptions<EmprestimoDbContext> options)

            : base(options)
        {
            
        }



        public DbSet<EmprestimoModel> Emprestimos { get; set; }
    }
}
