using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BR_HAXA_FE.IDENTITY.Models
{
    public partial class Cita
    {
        public int IdCita { get; set; }
        public int IdUsuario { get; set; }
        public int IdPropiedad { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }

        //public virtual Propiedad IdPropiedadNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
