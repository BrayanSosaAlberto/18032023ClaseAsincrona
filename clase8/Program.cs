using pro8.Models;

AlmacenContext db = new AlmacenContext();

Console.WriteLine("Por favor ingresar el nombre del producto: ");
string nombre = Console.ReadLine();
Console.WriteLine("Por favor ingresar la descripción del producto: ");
string descripcion = Console.ReadLine();
Console.WriteLine("Por favor ingresar el precio del producto: ");
decimal precio = decimal.Parse(Console.ReadLine());
Console.WriteLine("Por favor el stock del producto: ");
int stock = int.Parse(Console.ReadLine());


var producto = new Producto { Nombre = nombre, Descripcion = descripcion, Precio = precio, Stock = stock };
db.Productos.Add(producto);
db.SaveChanges();