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
                    Categoria = "Protecci�n", Descripcion = "Casco de alta calidad para airsoft.", UrlImagen = "casco.jpg" },
                new Producto { Nombre = "R�plica de Rifle", PrecioEnDolares = 19.99m, PrecioEnCreditos = 300,
                    Categoria = "Armas", Descripcion = "R�plica de rifle de asalto para airsoft.", UrlImagen = "rifle.jpg" },
                new Producto { Nombre = "Chaleco T�ctico", PrecioEnDolares = 79.99m, PrecioEnCreditos = 150,
                    Categoria = "Protecci�n", Descripcion = "Chaleco t�ctico resistente para airsoft.", UrlImagen = "chaleco.jpg" },
                new Producto { Nombre = "Pistola de Airsoft", PrecioEnDolares = 59.99m, PrecioEnCreditos = 120,
                    Categoria = "Armas", Descripcion = "Pistola de airsoft de alta precisi�n.", UrlImagen = "pistola.jpg" },
                new Producto { Nombre = "M�scara de Airsoft", PrecioEnDolares = 34.99m, PrecioEnCreditos = 70,
                    Categoria = "Protecci�n", Descripcion = "M�scara de protecci�n facial para airsoft.", UrlImagen = "mascara.jpg" },
                new Producto { Nombre = "Bolas de Airsoft", PrecioEnDolares = 14.99m, PrecioEnCreditos = 30,
                    Categoria = "Accesorios", Descripcion = "Bolas de airsoft de alta calidad.", UrlImagen = "bolas.jpg" },
                new Producto { Nombre = "Guantes T�cticos", PrecioEnDolares = 24.99m, PrecioEnCreditos = 50,
                    Categoria = "Protecci�n", Descripcion = "Guantes t�cticos para airsoft.", UrlImagen = "guantes.jpg" },
                new Producto { Nombre = "Rodilleras T�cticas", PrecioEnDolares = 29.99m, PrecioEnCreditos = 60,
                    Categoria = "Protecci�n", Descripcion = "Rodilleras t�cticas para airsoft.", UrlImagen = "rodilleras.jpg" },
                new Producto { Nombre = "Cargador de Bolas", PrecioEnDolares = 9.99m, PrecioEnCreditos = 20,
                    Categoria = "Accesorios", Descripcion = "Cargador de bolas para airsoft.", UrlImagen = "cargador.jpg" },
                new Producto { Nombre = "Gafas de Protecci�n", PrecioEnDolares = 19.99m, PrecioEnCreditos = 40,
                    Categoria = "Protecci�n", Descripcion = "Gafas de protecci�n para airsoft.", UrlImagen = "gafas.jpg" },
                new Producto { Nombre = "R�plica de Escopeta", PrecioEnDolares = 89.99m, PrecioEnCreditos = 180,
                    Categoria = "Armas", Descripcion = "R�plica de escopeta para airsoft.", UrlImagen = "escopeta.jpg" },
                new Producto { Nombre = "Funda para Arma", PrecioEnDolares = 14.99m, PrecioEnCreditos = 30,
                    Categoria = "Accesorios", Descripcion = "Funda para arma de airsoft.", UrlImagen = "funda.jpg" },
                new Producto { Nombre = "Silenciador de Airsoft", PrecioEnDolares = 19.99m, PrecioEnCreditos = 40,
                    Categoria = "Accesorios", Descripcion = "Silenciador para armas de airsoft.", UrlImagen = "silenciador.jpg" },
                new Producto { Nombre = "L�ser T�ctico", PrecioEnDolares = 29.99m, PrecioEnCreditos = 60,
                    Categoria = "Accesorios", Descripcion = "L�ser t�ctico para armas de airsoft.", UrlImagen = "laser.jpg" },
                new Producto { Nombre = "Linterna T�ctica", PrecioEnDolares = 24.99m, PrecioEnCreditos = 50,
                    Categoria = "Accesorios", Descripcion = "Linterna t�ctica para armas de airsoft.", UrlImagen = "linterna.jpg" },
                new Producto { Nombre = "Bater�a de Airsoft", PrecioEnDolares = 14.99m, PrecioEnCreditos = 30,
                    Categoria = "Accesorios", Descripcion = "Bater�a para armas de airsoft.", UrlImagen = "bateria.jpg" },
                new Producto { Nombre = "Cargador de Bater�a", PrecioEnDolares = 19.99m, PrecioEnCreditos = 40,
                    Categoria = "Accesorios", Descripcion = "Cargador de bater�a para armas de airsoft.", UrlImagen = "cargador_bateria.jpg" },
                new Producto { Nombre = "Correa de Arma", PrecioEnDolares = 9.99m, PrecioEnCreditos = 20,
                    Categoria = "Accesorios", Descripcion = "Correa para armas de airsoft.", UrlImagen = "correa.jpg" },
                new Producto { Nombre = "Parches de Airsoft", PrecioEnDolares = 4.99m, PrecioEnCreditos = 10,
                    Categoria = "Accesorios", Descripcion = "Parches tem�ticos de airsoft.", UrlImagen = "parches.jpg" },
                new Producto { Nombre = "R�plica de Subfusil", PrecioEnDolares = 19.99m, PrecioEnCreditos = 220,
                    Categoria = "Armas", Descripcion = "R�plica de subfusil para airsoft.", UrlImagen = "subfusil.jpg" },
                new Producto { Nombre = "R�plica de Francotirador", PrecioEnDolares = 129.99m, PrecioEnCreditos = 260,
                    Categoria = "Armas", Descripcion = "R�plica de francotirador para airsoft.", UrlImagen = "francotirador.jpg" },
                new Producto { Nombre = "R�plica de Pistola", PrecioEnDolares = 59.99m, PrecioEnCreditos = 120,
                    Categoria = "Armas", Descripcion = "R�plica de pistola para airsoft.", UrlImagen = "pistola2.jpg" }
            };
        }
    }

}
