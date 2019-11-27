using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Materiales> Materiales { get; set; }
        public DbSet<Obra> Obras { get; set; }
        public DbSet<Actividad> Actividades { get; set; }

        public Contexto() : base("Constr")
        {
        }
    }
}
