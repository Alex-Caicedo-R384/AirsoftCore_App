using System;
using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;
using AirsoftCore_App.Models;

namespace AirsoftCore_App.Views
{
    public partial class DetallesProductoPage : ContentPage
    {
        public Producto Producto { get; set; }

        public DetallesProductoPage(Producto producto)
        {
            InitializeComponent();
            Producto = producto;
            BindingContext = Producto;
        }

        private ObservableCollection<Producto> ObtenerListaDeProductos()
        {
            return new ObservableCollection<Producto>
            {
                new Producto { Nombre = "Casco Airsoft", PrecioEnDolares = 49.99m, PrecioEnCreditos = 100,
                    Categoria = "Protección", Descripcion = "Casco de alta calidad para airsoft.", UrlImagen = "casco.jpg" },
                new Producto { Nombre = "Réplica de Rifle", PrecioEnDolares = 19.99m, PrecioEnCreditos = 300,
                    Categoria = "Armas", Descripcion = "Réplica de rifle de asalto para airsoft.", UrlImagen = "rifle.jpg" },
                new Producto { Nombre = "Chaleco Táctico", PrecioEnDolares = 79.99m, PrecioEnCreditos = 150,
                    Categoria = "Protección", Descripcion = "Chaleco táctico resistente para airsoft.", UrlImagen = "chaleco.jpg" },
                new Producto { Nombre = "Pistola de Airsoft", PrecioEnDolares = 59.99m, PrecioEnCreditos = 120,
                    Categoria = "Armas", Descripcion = "Pistola de airsoft de alta precisión.", UrlImagen = "pistola.jpg" },
                new Producto { Nombre = "Máscara de Airsoft", PrecioEnDolares = 34.99m, PrecioEnCreditos = 70,
                    Categoria = "Protección", Descripcion = "Máscara de protección facial para airsoft.", UrlImagen = "mascara.jpg" },
                new Producto { Nombre = "Bolas de Airsoft", PrecioEnDolares = 14.99m, PrecioEnCreditos = 30,
                    Categoria = "Accesorios", Descripcion = "Bolas de airsoft de alta calidad.", UrlImagen = "bolas.jpg" },
                new Producto { Nombre = "Guantes Tácticos", PrecioEnDolares = 24.99m, PrecioEnCreditos = 50,
                    Categoria = "Protección", Descripcion = "Guantes tácticos para airsoft.", UrlImagen = "guantes.jpg" },
                new Producto { Nombre = "Rodilleras Tácticas", PrecioEnDolares = 29.99m, PrecioEnCreditos = 60,
                    Categoria = "Protección", Descripcion = "Rodilleras tácticas para airsoft.", UrlImagen = "rodilleras.jpg" },
                new Producto { Nombre = "Cargador de Bolas", PrecioEnDolares = 9.99m, PrecioEnCreditos = 20,
                    Categoria = "Accesorios", Descripcion = "Cargador de bolas para airsoft.", UrlImagen = "cargador.jpg" },
                new Producto { Nombre = "Gafas de Protección", PrecioEnDolares = 19.99m, PrecioEnCreditos = 40,
                    Categoria = "Protección", Descripcion = "Gafas de protección para airsoft.", UrlImagen = "gafas.jpg" },
                new Producto { Nombre = "Réplica de Escopeta", PrecioEnDolares = 89.99m, PrecioEnCreditos = 180,
                    Categoria = "Armas", Descripcion = "Réplica de escopeta para airsoft.", UrlImagen = "escopeta.jpg" },
                new Producto { Nombre = "Funda para Arma", PrecioEnDolares = 14.99m, PrecioEnCreditos = 30,
                    Categoria = "Accesorios", Descripcion = "Funda para arma de airsoft.", UrlImagen = "funda.jpg" },
                new Producto { Nombre = "Silenciador de Airsoft", PrecioEnDolares = 19.99m, PrecioEnCreditos = 40,
                    Categoria = "Accesorios", Descripcion = "Silenciador para armas de airsoft.", UrlImagen = "silenciador.jpg" },
                new Producto { Nombre = "Láser Táctico", PrecioEnDolares = 29.99m, PrecioEnCreditos = 60,
                    Categoria = "Accesorios", Descripcion = "Láser táctico para armas de airsoft.", UrlImagen = "laser.jpg" },
                new Producto { Nombre = "Linterna Táctica", PrecioEnDolares = 24.99m, PrecioEnCreditos = 50,
                    Categoria = "Accesorios", Descripcion = "Linterna táctica para armas de airsoft.", UrlImagen = "linterna.jpg" },
                new Producto { Nombre = "Batería de Airsoft", PrecioEnDolares = 14.99m, PrecioEnCreditos = 30,
                    Categoria = "Accesorios", Descripcion = "Batería para armas de airsoft.", UrlImagen = "bateria.jpg" },
                new Producto { Nombre = "Cargador de Batería", PrecioEnDolares = 19.99m, PrecioEnCreditos = 40,
                    Categoria = "Accesorios", Descripcion = "Cargador de batería para armas de airsoft.", UrlImagen = "cargador_bateria.jpg" },
                new Producto { Nombre = "Correa de Arma", PrecioEnDolares = 9.99m, PrecioEnCreditos = 20,
                    Categoria = "Accesorios", Descripcion = "Correa para armas de airsoft.", UrlImagen = "correa.jpg" },
                new Producto { Nombre = "Parches de Airsoft", PrecioEnDolares = 4.99m, PrecioEnCreditos = 10,
                    Categoria = "Accesorios", Descripcion = "Parches temáticos de airsoft.", UrlImagen = "parches.jpg" },
                new Producto { Nombre = "Réplica de Subfusil", PrecioEnDolares = 19.99m, PrecioEnCreditos = 220,
                    Categoria = "Armas", Descripcion = "Réplica de subfusil para airsoft.", UrlImagen = "subfusil.jpg" },
                new Producto { Nombre = "Réplica de Francotirador", PrecioEnDolares = 129.99m, PrecioEnCreditos = 260,
                    Categoria = "Armas", Descripcion = "Réplica de francotirador para airsoft.", UrlImagen = "francotirador.jpg" },
                new Producto { Nombre = "Réplica de Pistola", PrecioEnDolares = 59.99m, PrecioEnCreditos = 120,
                    Categoria = "Armas", Descripcion = "Réplica de pistola para airsoft.", UrlImagen = "pistola2.jpg" }
            };
        }
    }

}
