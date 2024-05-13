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
    public partial class PaginaRegistro : ContentPage
    {
        public PaginaRegistro()
        {
            InitializeComponent();
        }

        private async void BtnInicioConFacebook_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }

        private async void BtnInicioConGoogle_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaInicioSesion());
        }
    }
}