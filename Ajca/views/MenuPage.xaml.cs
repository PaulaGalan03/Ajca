﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ajca.views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : MasterDetailPage
	{
		public MenuPage ()
		{
			InitializeComponent ();
            this.Master = new Master();
		}

    }
}