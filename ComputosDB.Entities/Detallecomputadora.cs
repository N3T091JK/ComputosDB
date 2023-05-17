using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputosDB.Entities
{
    public class Detallecomputadora
    {
        [Key]
        public int IdDetallecomputadora { get; set; }
        [MaxLength(80)]
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Ram { get; set; }
        [Required]
        public string ModeloDePlaca { get; set; }
        [Required]
        public string Teclado { get; set; }
        [Required]
        public string Raton { get; set; }
        [Required]
        public string Procesador { get; set; }
        [Required]
        public int NumerodeRAM { get; set; }
        [Required]
        public string Nucleos { get; set; }
        [Required]
        public decimal PulgadasDepantalla { get; set; }
        [Required]
        public int idComputadora { get; set; }
        public virtual Computadoras Computadoras { get; set; }
    }
}
