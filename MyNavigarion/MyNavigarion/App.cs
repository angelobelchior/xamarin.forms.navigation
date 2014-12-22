using System;
using Xamarin.Forms;

namespace MyNavigarion
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new  NavigationPage(new UIContentPage ());
		}
	}
}

