using Microsoft.EntityFrameworkCore;
using Model.Concret;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Context
{
    public class SistemaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Substitua "Teste" pelo nome do seu banco de dados
            optionsBuilder.UseSqlServer("Server=LOCALHOST\\SQLEXPRESS;Database=ClientesPF_PJ;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<PessoaFisica> PessoaFisica { get; set; }
    }
}
