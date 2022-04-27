// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BR_HAXA_FE.WIZARD.Models
{
    public partial class Imagenes
    {
        public int IdImagen { get; set; }
        public int IdPropiedad { get; set; }
        public string Link { get; set; }

        public virtual Propiedad IdPropiedadNavigation { get; set; }
    }
}
