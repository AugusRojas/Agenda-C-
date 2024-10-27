using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class Contacto
    {
        public string nombre_contacto {  get; set; }
        public string apellido_contacto { get; set; }
        public int telefono_contacto { get; set; }
        public string direccion_contacto { get; set; }

        public Contacto(string nombre_contacto,string apellido_contacto,string direccion_contacto,int telefono_contacto)
        {
            this.apellido_contacto = apellido_contacto;
            this.direccion_contacto = direccion_contacto;
            this.telefono_contacto = telefono_contacto;
            this.nombre_contacto = nombre_contacto;
        }




    }
}
