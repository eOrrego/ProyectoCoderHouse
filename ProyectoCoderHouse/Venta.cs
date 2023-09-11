using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCoderHouse
{
    // Clase concreta para Ventas
    public class Venta
    {
        private int Id { get; set; }
        public string Comentarios { get; set; }
        private Usuario Usuario { get; set; }

        // Constructor de la clase
        public Venta(int id, string comentarios)
        {
            Id = id;
            Comentarios = comentarios;
        }

        // Método público para establecer el usuario
        public void SetUsuario(Usuario usuario)
        {
            Usuario = usuario;
        }

        // Otros métodos públicos para obtener valores
        public int GetId()
        {
            return Id;
        }
        public string GetComentarios()
        {
            return Comentarios;
        }
        public Usuario GetUsuario()
        {
            return Usuario;
        }

        // Método para mostrar la información de la venta
        public void MostrarInformacion()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Comentarios: " + Comentarios);
            Console.WriteLine("Usuario: " + Usuario.NombreUsuario);
        }
    }
}
