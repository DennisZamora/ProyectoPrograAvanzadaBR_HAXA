using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BR_HAXA_FE.IDENTITY.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Cita = new HashSet<Cita>();
            Propiedad = new HashSet<Propiedad>();
        }

        public int IdUsuario { get; set; }
        public string CedulaIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdRol { get; set; }

        public virtual Rol IdRolNavigation { get; set; }
        public virtual ICollection<Cita> Cita { get; set; }
        public virtual ICollection<Propiedad> Propiedad { get; set; }
    }
}
