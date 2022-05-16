using System;
using System.Collections.Generic;

namespace Migan.Models
{
    public partial class Usuario
    {
        public int Id { get; set; }
        public string? Usuario1 { get; set; }
        public string? Contrasena { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Idperfil { get; set; }

        public virtual Perfile? IdperfilNavigation { get; set; }
    }
}
