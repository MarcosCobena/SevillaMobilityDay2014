using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevillaMobilityDayXamarinForms.Views
{
    using SevillaMobilityDay.Core.Models;
    using SevillaMobilityDay.Core.ViewModels;
    using Xamarin.Forms;

    public partial class MainPage
	{
		public MainPage ()
		{
			InitializeComponent ();

            var mainViewModel = new MainViewModel();
            mainViewModel.Init();

		    this.BindingContext = mainViewModel;
		}

        private async void OnItemSelected(object sender, ItemTappedEventArgs args)
        {
            var selectedSpeaker = args.Item as Speaker;

            if (selectedSpeaker == null)
            {
                return;
            }

            var detailsPage = new DetailsPage(selectedSpeaker);
            await Navigation.PushAsync(detailsPage);
        }
	}
}
