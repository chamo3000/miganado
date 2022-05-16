using System;
using System.Collections.Generic;

namespace Migan.Models
{
    public partial class Gasto
    {
        public int Id { get; set; }
        public int? Reunion { get; set; }
        public int? Cliente { get; set; }
        public int? Bascula { get; set; }
        public int? Transporte { get; set; }
        public int? Bano { get; set; }
        public int? Recibida { get; set; }
        public int? ComisionF { get; set; }
        public int? ComisionG { get; set; }
        public int? Vacuna { get; set; }
        public int? Anticipo { get; set; }
        public int? Otros { get; set; }
        public string? Observacion { get; set; }

        public virtual Cliente? ClienteNavigation { get; set; }
    }
}
