using System.Collections.Generic;

namespace lab3
{
    public class Producto
    {
        

        public int precio;
        public string nombre;
        public string marca;
        public int stock;
        public int codigo;

        public Producto(string nombre, string marca, int precio, int stock, int codigo)
        {
            this.nombre = nombre;
            this.marca = marca;
            this.precio = precio;
            this.stock = stock;
            this.codigo = codigo;
        }
        public string Informacion()
        {
            return ("Nombre: " + nombre + ",  Marca: " + marca + ",  Precio: " + precio + ",  Stock: " + stock + ", Codigo: " + codigo);
        }
    }
}
