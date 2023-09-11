using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCoderHouse
{
    // Clase concreta para Productos
    public class Producto : ProductoBase
    {
        // Constructor de la clase
        public Producto(int id, string descripcion, float costo, float precioVenta, int stock, int idUsuario) : base(id, descripcion, costo, precioVenta, stock, idUsuario)
        {
        }

        // Método para mostrar la información del producto
        public override void MostrarInformacion()
        {
            Console.WriteLine("Descripción: " + Descripcion);
            Console.WriteLine("Costo: " + Costo);
            Console.WriteLine("Precio de venta: " + PrecioVenta);
            Console.WriteLine("Stock: " + Stock);
        }
    }
}
