﻿namespace AirsoftCore_App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Views.DetallesProductoPage), typeof(Views.DetallesProductoPage));
        }
    }
}
