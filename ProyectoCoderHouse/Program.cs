// See https://aka.ms/new-console-template for more information
using ProyectoCoderHouse;
Console.WriteLine("Bienvenido al Proyecto CoderHouse de Esteban Orrego" + Environment.NewLine);

// Ejemplo de uso de la clase Usuario
Usuario usuario = new Usuario(1, "Juan", "Perez", "juanperez", "123456", "jperez@mail.com");
Console.WriteLine("Información del usuario:" + Environment.NewLine);
usuario.MostrarInformacion();
Console.WriteLine("------------------------------------" + Environment.NewLine);

// Ejemplo de uso de la clase Producto
Producto producto1 = new Producto(1, "Producto 1", 100, 200, 10, 1);
Producto producto2 = new Producto(2, "Producto 2", 200, 400, 20, 1);
Console.WriteLine("Información del producto 1:" + Environment.NewLine);
producto1.MostrarInformacion();
Console.WriteLine("------------------------------------" + Environment.NewLine);
Console.WriteLine("Información del producto 2:" + Environment.NewLine);
producto2.MostrarInformacion();
Console.WriteLine("------------------------------------" + Environment.NewLine);

// Ejemplo de uso de la clase Venta
Venta venta = new Venta(1, "Comentarios de la venta");
venta.SetUsuario(usuario);

// Ejemplo de uso de la clase ProductoVendido
ProductoVendido productoVendido1 = new ProductoVendido(1, producto1, 5);
ProductoVendido productoVendido2 = new ProductoVendido(2, producto2, 10);

productoVendido1.SetVenta(venta);
productoVendido2.SetVenta(venta);

// Mostrar información de la venta y los productos vendidos
Console.WriteLine("Información de la venta:" + Environment.NewLine);
venta.MostrarInformacion();
Console.WriteLine("------------------------------------" + Environment.NewLine);
Console.WriteLine("Información del producto vendido 1:" + Environment.NewLine);
productoVendido1.MostrarInformacion();
Console.WriteLine("------------------------------------" + Environment.NewLine);
Console.WriteLine("Información del producto vendido 2:" + Environment.NewLine);
productoVendido2.MostrarInformacion();
Console.WriteLine("------------------------------------" + Environment.NewLine);
