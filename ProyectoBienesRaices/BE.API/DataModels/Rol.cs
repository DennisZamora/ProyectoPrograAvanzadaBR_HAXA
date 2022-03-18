using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE.API.DataModels
{
    public class Rol
    {
        public Rol()
        {
            //Usuario = new HashSet<Usuario>();
        }

        public int IdRol { get; set; }
        public string NombreRol { get; set; }

        //public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
