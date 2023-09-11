using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCoderHouse
{
    // Clase base abstracta para Productos
    public abstract class ProductoBase
    {
        protected int Id { get; set; }
        protected string Descripcion { get; set; }
        protected float Costo { get; set; }
        protected float PrecioVenta { get; set; }
        protected int Stock { get; set; }
        protected int IdUsuario { get; set; }

        // Constructor de la clase
        public ProductoBase(int id, string descripcion, float costo, float precioVenta, int stock, int idUsuario)
        {
            Id = id;
            Descripcion = descripcion;
            Costo = costo;
            PrecioVenta = precioVenta;
            Stock = stock;
            IdUsuario = idUsuario;
        }

        // Método abstracto para mostrar la información del producto
        public abstract void MostrarInformacion();
    }
}
