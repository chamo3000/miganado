using System;
using System.Collections.Generic;

namespace Migan.Models
{
    public partial class VistaComprador
    {
        public int Id { get; set; }
        public string PrimerApellido { get; set; } = null!;
        public string? SegundoApellido { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Cédula { get; set; }
        public string Descripción { get; set; } = null!;
    }
}
