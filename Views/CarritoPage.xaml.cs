using System;
using System.Linq;
using AirsoftCore_App.Models;
using Microsoft.Maui.Controls;

namespace AirsoftCore_App.Views
{
    public partial class CarritoPage : ContentPage
    {
        public CarritoPage()
        {
            InitializeComponent();
            CarritoCollectionView.ItemsSource = AppShell.Carrito.ProductosEnCarrito;
        }

        private void OnEliminarDelCarritoClick(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is string productoId)
            {
                var producto = AppShell.Carrito.ProductosEnCarrito.FirstOrDefault(p => p.Id == productoId);

                if (producto != null)
                {
                    AppShell.Carrito.EliminarDelCarrito(producto);
                }
            }
        }

        private async void OnRealizarCompraClick(object sender, EventArgs e)
        {
            decimal totalCompra = AppShell.Carrito.CalcularTotalCompra();

            AppShell.Carrito.LimpiarCarrito();

            await DisplayAlert("Compra realizada", $"Total de la compra: {totalCompra:C}", "Aceptar");
        }
    }
}
