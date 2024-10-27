using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace capaNegocio
{
    public class Agenda
    {
        public Usuario datos { get; set; }
        public List<Contacto> contactos {  get; private set; }
        public Agenda(List<Contacto> contactos, string nombre, string usuario,string contrasena,string apellido)
        {
            this.datos = new Usuario(nombre, usuario, contrasena, apellido);
            this.contactos = contactos;
        }
    }
}
