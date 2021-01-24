using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebContratos.Data;


namespace WebContratos.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebContratosContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebContratosContext>>()))
            {
                // Look for any movies.
                if (context.Contrato.Any())
                {
                    return;   // DB has been seeded
                }

                context.Contrato.AddRange(
                    new Contrato
                    {
                        NumCont = 2154646,
                        NomeMutuario = "Apolo Jr" ,
                        DataAssinatura = DateTime.Parse("1981-3-14"),
                        
                    },

                    new Contrato
                    {
                        NumCont = 2154690,
                        NomeMutuario = "FAbio",
                        DataAssinatura = DateTime.Parse("1999-8-21"),

                    },

                    new Contrato
                    {
                        NumCont = 2157456,
                        NomeMutuario = "Pedro",
                        DataAssinatura = DateTime.Parse("2020-09-14"),

                    },

                    new Contrato
                    {
                        NumCont = 4785685,
                        NomeMutuario = "Milena",
                        DataAssinatura = DateTime.Parse("2001-11-07"),

                    }
                );
                context.SaveChanges();
            }
        }
    }
}
