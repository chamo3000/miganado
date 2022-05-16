using System;
using System.Collections.Generic;

namespace Migan.Models
{
    public partial class Tipocliente
    {
        public Tipocliente()
        {
            Claseclientes = new HashSet<Clasecliente>();
        }

        public int Id { get; set; }
        public string Valor { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Clasecliente> Claseclientes { get; set; }
    }
}
