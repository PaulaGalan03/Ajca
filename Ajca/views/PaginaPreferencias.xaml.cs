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
	public partial class PaginaPreferencias : ContentPage
	{
		public PaginaPreferencias ()
		{
			InitializeComponent ();
		}

        private async void BtnEditarPerfil_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new PaginaEditarPerfil());
        }
    }
}