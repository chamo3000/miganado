using System;
using System.Collections.Generic;

namespace Migan.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Claseclientes = new HashSet<Clasecliente>();
            Gastos = new HashSet<Gasto>();
        }

        public int Id { get; set; }
        public string PrimerApellido { get; set; } = null!;
        public string? SegundoApellido { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Cedula { get; set; }

        public virtual ICollection<Clasecliente> Claseclientes { get; set; }
        public virtual ICollection<Gasto> Gastos { get; set; }
    }
}
