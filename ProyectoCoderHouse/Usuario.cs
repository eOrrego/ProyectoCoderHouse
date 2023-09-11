using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCoderHouse
{
    // Clase concreta para Usuarios
    public class Usuario : UsuarioBase
    {
        // Constructor de la clase
        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contrasenia, string mail) : base(id, nombre, apellido, nombreUsuario, contrasenia, mail)
        {
        }

        // Método para mostrar la información del usuario
        public override void MostrarInformacion()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellido: " + Apellido);
            Console.WriteLine("Nombre de usuario: " + NombreUsuario);
            Console.WriteLine("Mail: " + Mail);
        }
    }
}
