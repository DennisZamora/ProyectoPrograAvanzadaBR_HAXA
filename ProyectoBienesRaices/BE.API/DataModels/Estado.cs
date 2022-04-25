using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BE.API.DataModels
{
    public class Estado
    {
        public Estado()
        {
            Propiedad = new HashSet<Propiedad>();
        }

        public int IdEstado { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Propiedad> Propiedad { get; set; }
    }
}
