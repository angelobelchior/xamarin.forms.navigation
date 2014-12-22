using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MyNavigarion
{	
	public partial class UITabbedPage : TabbedPage
	{	
		public UITabbedPage ()
		{
			InitializeComponent ();
		}

		protected async void OnClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync (new UICarouselPage());
		}
	}
}