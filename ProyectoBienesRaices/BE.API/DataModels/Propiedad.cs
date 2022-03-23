using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BE.API.DataModels
{
    public class Propiedad
    {
        public long IdPropiedad { get; set; }
        public byte[] Imagen { get; set; }
        public string Nombre { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Direccion { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoria { get; set; }
        public int IdEstado { get; set; }
        public int? Pisos { get; set; }
        public int? M2 { get; set; }
        public int? Habitacion { get; set; }
        public int? Baños { get; set; }
        public int? Garage { get; set; }
        public int IdUsuario { get; set; }
        public string Precio { get; set; }

        public virtual Categoria IdCategoriaNavigation { get; set; }
        public virtual Estado IdEstadoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
