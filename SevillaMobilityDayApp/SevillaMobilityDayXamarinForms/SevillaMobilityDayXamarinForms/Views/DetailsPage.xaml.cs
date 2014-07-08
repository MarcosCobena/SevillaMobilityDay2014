using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevillaMobilityDayXamarinForms.Views
{
    using SevillaMobilityDay.Core.Models;
    using SevillaMobilityDay.Core.ViewModels;

    public partial class DetailsPage
	{
		public DetailsPage (Speaker speaker)
		{
			InitializeComponent ();

		    var detailsViewModel = new DetailsViewModel();
            detailsViewModel.Init(speaker);

            this.BindingContext = detailsViewModel;
		}
	}
}
