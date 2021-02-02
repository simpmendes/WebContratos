using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebContratos.Models
{
    public class Contrato
    {
        
        
        public int ContratoID { get; set; }
       
        [Required]
        [StringLength(50, ErrorMessage = "Nome do mutuário não pode ser maior que 50 caracteres")]
        [Display(Name ="Nome do Mutuário")]
        public string NomeMutuario { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data de Assinatura")]
        public DateTime DataAssinatura { get; set; }

        
    }
    
}
