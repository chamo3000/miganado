using System;
using System.Collections.Generic;

namespace Migan.Models
{
    public partial class Factura
    {
        public int Id { get; set; }
        public int Consecutivo { get; set; }
        public int? Reunion { get; set; }
        public DateTime? Fecha { get; set; }
        public int? IdCliente { get; set; }
        public int? IdClaseGanado { get; set; }
        public int? Corral { get; set; }
        public int? Cabezas { get; set; }
        public int? IdSexo { get; set; }
        public int? Kilos { get; set; }
        public int? ValorKg { get; set; }
        public double? ValorTotal { get; set; }
        public int? Anio { get; set; }

        public virtual Clase? IdClaseGanadoNavigation { get; set; }
        public virtual Cliente? IdClienteNavigation { get; set; }
        public virtual Sexo? IdSexoNavigation { get; set; }
    }
}
