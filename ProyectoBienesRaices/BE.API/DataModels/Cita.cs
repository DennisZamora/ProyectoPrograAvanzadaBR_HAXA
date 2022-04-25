namespace BE.API.DataModels
{
    public class Cita
    {
        public int IdCita { get; set; }
        public int IdUsuario { get; set; }
        public int IdPropiedad { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFinal { get; set; }

        public virtual Propiedad IdPropiedadNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
