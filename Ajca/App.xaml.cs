using Ajca.views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ajca
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDet { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PaginaRegistro())
            {
                BarBackgroundColor = Color.FromHex("#73BFB8"),
                BarTextColor = Color.White
            };
        }
        public static MasterDetailPage Modificador { get; set; }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
