namespace BE.API.DataModels
{
    public class Imagenes
    {
        public int IdImagen { get; set; }
        public int IdPropiedad { get; set; }
        public string Link { get; set; }

        public virtual Propiedad IdPropiedadNavigation { get; set; }
    }
}
