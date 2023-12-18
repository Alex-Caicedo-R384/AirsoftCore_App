using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace AirsoftCore_App.Models
{
    public class Carrito
    {
        public ObservableCollection<Producto> ProductosEnCarrito { get; } = new ObservableCollection<Producto>();

        public void AgregarAlCarrito(Producto producto)
        {
            ProductosEnCarrito.Add(producto);
        }

        public void EliminarDelCarrito(Producto producto)
        {
            ProductosEnCarrito.Remove(producto);
        }

        public decimal CalcularTotalCompra()
        {
            return ProductosEnCarrito.Sum(p => p.PrecioEnDolares);
        }

        public void LimpiarCarrito()
        {
            ProductosEnCarrito.Clear();
        }
    }
}
