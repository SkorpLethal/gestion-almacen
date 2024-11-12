namespace GestionAlmacen
{
    public class Producto
    { 
        public Producto(string nombre, int cantidad, double precio) {
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = precio;
        }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        

    }
}
