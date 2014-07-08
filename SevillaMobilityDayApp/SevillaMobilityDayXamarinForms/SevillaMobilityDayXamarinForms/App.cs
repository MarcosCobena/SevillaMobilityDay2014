using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SevillaMobilityDayXamarinForms
{
    using SevillaMobilityDayXamarinForms.Views;

    public class App
	{
		public static Page GetMainPage()
		{
            var mainNav = new NavigationPage(new MainPage());
            
            return mainNav;
		}
	}
}
