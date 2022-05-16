using System;
using System.Collections.Generic;

namespace Migan.Models
{
    public partial class Sexo
    {
        public int Id { get; set; }
        public string Sexo1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
    }
}
