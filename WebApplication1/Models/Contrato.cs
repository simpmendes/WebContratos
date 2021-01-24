using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebContratos.Models
{
    public class Contrato
    {
        
        public int Id { get; set; }
        -
        public int NumCont { get; set; }
        [Required]
        [StringLength(50)]
        public string NomeMutuario { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataAssinatura { get; set; }
    }
}
