using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace calculadora_prestamos.Models
{
    public class Prestamo
    {
        public int Id { get; set; }

        public long Capital { get; set; }

        public decimal Intereces { get; set; }

        public decimal Cuota { get; set; }

        public int ClienteId { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}