using System;
using System.Collections.Generic;

namespace Migan.Models
{
    public partial class Vistahaciendum
    {
        public int Id { get; set; }
        public string NombreHacienda { get; set; } = null!;
        public string Municipio { get; set; } = null!;
        public string NombreCliente { get; set; } = null!;
        public string PrimerApellido { get; set; } = null!;
        public string? SegundoApellido { get; set; }
        public string? CedulaCliente { get; set; }
    }
}
