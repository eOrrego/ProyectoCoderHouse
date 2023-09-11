using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCoderHouse
{
    // Clase base abstracta para Usuarios
    public abstract class UsuarioBase
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public string NombreUsuario { get; set; }
        private string Contrasenia { get; set; }
        public string Mail { get; set; }

        // Constructor de la clase
        public UsuarioBase(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
            Mail = mail;
        }

        // Método abstracto para mostrar la información del usuario
        public abstract void MostrarInformacion();

        // Propiedad pública para acceder a la contraseña
        public string GetContrasenia()
        {
            return Contrasenia;
        }

        // Método público para establecer la contraseña
        public void SetContrasenia(string contrasenia)
        {
            Contrasenia = contrasenia;
        }
    }
}
