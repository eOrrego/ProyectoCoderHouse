using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCoderHouse
{
    // Clase concreta para Productos Vendidos
    public class ProductoVendido
    {
        private int Id { get; set; }
        private Producto Producto { get; set; }
        private int Stock { get; set; }
        private Venta Venta { get; set; }

        // Constructor de la clase
        public ProductoVendido(int id, Producto producto, int stock)
        {
            Id = id;
            Producto = producto;
            Stock = stock;
        }

        // Método público para establecer la venta
        public void SetVenta(Venta venta)
        {
            Venta = venta;
        }

        // Otros métodos públicos para obtener valores

        public int GetId()
        {
            return Id;
        }
        public Producto GetProducto()
        {
            return Producto;
        }
        public int GetStock()
        {
            return Stock;
        }
        public Venta GetVenta()
        {
            return Venta;
        }

        // Método para mostrar la información del producto vendido
        public void MostrarInformacion()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Stock: " + Stock);
            Console.WriteLine("Venta: " + Venta.GetId());
        }
    }
}
