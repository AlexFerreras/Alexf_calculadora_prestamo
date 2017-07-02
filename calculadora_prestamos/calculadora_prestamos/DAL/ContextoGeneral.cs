using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using calculadora_prestamos.Models;
namespace calculadora_prestamos.DAL
{
    public class ContextoGeneral : DbContext
    {
        public ContextoGeneral(): base("conexion")  { }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Prestamo> Prestamo { get; set; }



    }
}