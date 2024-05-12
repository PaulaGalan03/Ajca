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
	public partial class MenuPage : ContentPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
		}
        private async void Inicio_Clicked(object sender, EventArgs e)
        {
            await App.Modificador.Detail.Navigation.PushAsync(new PaginaPrincipal());
            App.Modificador.IsPresented = false;
        }

        private async void Notificaciones_Clicked(object sender, EventArgs e)
        {
            await App.Modificador.Detail.Navigation.PushAsync(new PaginaNotificaciones());
            App.Modificador.IsPresented = false;
        }
    }
}