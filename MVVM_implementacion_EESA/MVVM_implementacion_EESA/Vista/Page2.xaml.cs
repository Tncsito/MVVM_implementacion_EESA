﻿using MVVM_implementacion_EESA.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_implementacion_EESA.Vista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2()
		{
			InitializeComponent ();
			BindingContext = new VMpage2(Navigation);
		}
	}
}