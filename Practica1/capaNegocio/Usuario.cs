using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocio
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public Usuario(string nombre,string usuario,string contrasena,string apellido)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.usuario = usuario;
            this.contrasena = contrasena;
        }


        public void Mostrar()
        {
            Console.WriteLine("$Nombre: {nombre} Apellido: {apellido} Usuario: {Usuario} contrasena: {contrasena}");
        }
    }
}
