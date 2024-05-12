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
	public partial class PaginaMenu : MasterDetailPage
    {
		public PaginaMenu ()
		{
			InitializeComponent ();
		}
        private void Opcion1_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Opcion1Page());
            IsPresented = false; // Oculta el menú lateral después de seleccionar una opción
        }

        private void Opcion2_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Opcion2Page());
            IsPresented = false; // Oculta el menú lateral después de seleccionar una opción
        }
    }
}