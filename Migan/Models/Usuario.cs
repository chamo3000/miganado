using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Migan.Models
{
    [Table("Usuario", Schema = "dbo")]
    public partial class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Nombre de Usuario")] 
        public string? Usuario1 { get; set; }
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string? Contrasena { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public int? Idperfil { get; set; }

        public virtual Perfile? IdperfilNavigation { get; set; }
    }
}
