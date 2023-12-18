using Microsoft.Maui.Controls;
using System;
using System.IO;
using System.Threading.Tasks;
using AirsoftCore_App.Models;
using AirsoftCore_App.Services;

namespace AirsoftCore_App.Views
{
    public partial class PerfilPage : ContentPage
    {
        private AuthService authService = new AuthService();

        public PerfilPage()
        {
            InitializeComponent();
        }

        private async void OnGuardarCambiosClicked(object sender, EventArgs e)
        {
            string nuevoUsuario = entryNuevoUsuario.Text;
            string nuevaContrase�a = entryNuevaContrase�a.Text;

            if (string.IsNullOrWhiteSpace(nuevoUsuario) || string.IsNullOrWhiteSpace(nuevaContrase�a))
            {
                await DisplayAlert("Perfil", "El usuario y la contrase�a no pueden estar vac�os", "OK");
                return;
            }

            await DisplayAlert("Perfil", "Cambios guardados correctamente", "OK");

            await authService.ActualizarDatosPerfilAsync(nuevoUsuario, nuevaContrase�a);
        }
    }
}
