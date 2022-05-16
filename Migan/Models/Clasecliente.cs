using System;
using System.Collections.Generic;

namespace Migan.Models
{
    public partial class Clasecliente
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoCliente { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual Tipocliente IdTipoClienteNavigation { get; set; } = null!;
    }
}
