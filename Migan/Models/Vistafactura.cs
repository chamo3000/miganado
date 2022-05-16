using System;
using System.Collections.Generic;

namespace Migan.Models
{
    public partial class Vistafactura
    {
        public int Id { get; set; }
        public long Consecutivo { get; set; }
        public int? Reunion { get; set; }
        public DateTime? Fecha { get; set; }
        public string NombrePropietario { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string ClaseGanado { get; set; } = null!;
        public int? Corral { get; set; }
        public int? Cabezas { get; set; }
        public string Sexo { get; set; } = null!;
        public int? Kilos { get; set; }
        public decimal? ValorKg { get; set; }
        public decimal? ValorTotal { get; set; }
        public int? Anio { get; set; }
        public string NombreComprador { get; set; } = null!;
        public string ApellidoComprador { get; set; } = null!;
    }
}
