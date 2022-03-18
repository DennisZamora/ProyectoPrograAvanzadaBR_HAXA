using System;
using System.Collections.Generic;
using System.Text;

namespace BE.DAL.DO.Objects
{
    public class Usuario
    {
        public Usuario()
        {
            //Propiedad = new HashSet<Propiedad>();
        }

        public long IdUsuario { get; set; }
        public string CedulaIdentificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int IdRol { get; set; }

        //public virtual Rol IdRolNavigation { get; set; }
        //public virtual ICollection<Propiedad> Propiedad { get; set; }
    }
}
