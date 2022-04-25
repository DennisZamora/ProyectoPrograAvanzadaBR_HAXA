namespace BE.DAL.DO.Objects
{
    public partial class Imagenes
    {
        public int IdImagen { get; set; }
        public int IdPropiedad { get; set; }
        public string Link { get; set; }

        public virtual Propiedad IdPropiedadNavigation { get; set; }
    }
}
