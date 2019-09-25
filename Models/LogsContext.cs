using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace pruebaMR.Models
{
    public class LogsContext : DbContext
    {
        public DbSet<GeneralLog> GeneralLogs { get; set; }
        public DbSet<Registro> Registros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=logs.db");
        }
    }

    public class GeneralLog
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<Registro> Registros { get; set; }
    }

    public class Registro
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int GeneralLogId { get; set; }
        public GeneralLog GeneralLog { get; set; }
    }
}
