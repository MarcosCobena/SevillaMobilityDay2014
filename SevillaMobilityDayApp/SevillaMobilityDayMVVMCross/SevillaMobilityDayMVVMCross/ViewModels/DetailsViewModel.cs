using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SevillaMobilityDay.Core.ViewModels
{
    using Cirrious.MvvmCross.ViewModels;

    using PropertyChanged;

    using SevillaMobilityDay.Core.Models;

    [ImplementPropertyChanged]
    public class DetailsViewModel : MvxViewModel
    {
        public Speaker Speaker { get; set; }

        public void Init(Speaker speaker)
        {
            this.Speaker = speaker;
        }
    }
}
