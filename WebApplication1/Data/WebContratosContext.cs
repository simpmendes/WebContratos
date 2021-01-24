using Microsoft.EntityFrameworkCore;
using WebContratos.Models;

namespace WebContratos.Data
{
    public class WebContratosContext : DbContext
    {
        public WebContratosContext(DbContextOptions<WebContratosContext> options)
            : base(options)
        { 
        }
        public DbSet<Contrato> Contrato { get; set; }
    }
}
