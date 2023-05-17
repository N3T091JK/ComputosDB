using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputosDB.Entities
{
    public class Computadoras
    {
        [Key]
        public int idComputadora { get; set; }
        [MaxLength(80)]
        [Required]
        public string Nombre { get; set; }
        public virtual ICollection<Detallecomputadora> Detallecomputadoras { get; set; }

    }
}
