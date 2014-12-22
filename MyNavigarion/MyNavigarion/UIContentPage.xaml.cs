using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyNavigarion
{	
	public partial class UIContentPage : ContentPage
	{	
		public UIContentPage ()
		{
			InitializeComponent ();
		}

		protected async void OnClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync (new UITabbedPage());
		}
	}
}