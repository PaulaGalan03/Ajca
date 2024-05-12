using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ajca.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInicioSesion : ContentPage
    {
        public PaginaInicioSesion()
        {
            InitializeComponent();
        }

        private async void BtnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaPrincipal());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaRegistro());
        }
    }
}