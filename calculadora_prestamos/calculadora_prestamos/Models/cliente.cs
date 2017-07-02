using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace calculadora_prestamos.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [StringLength(50)]
        public string Nombrecompleto { get; set; }

        [Required(ErrorMessage = "El campo {0} es Obligatorio")]
        [StringLength(150)]
        public string Direccion { get; set; }

        public virtual ICollection <Prestamo> Prestamo { get; set;}

    }
}