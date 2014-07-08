using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using Cirrious.MvvmCross.Binding.Touch.Views;
using SevillaMobilityDay.Core.ViewModels;

namespace SevillaMobilityDayMVVMCross.iOS.Views
{
    [Register("MainView")]
    public class MainView : MvxTableViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var source = new MvxStandardTableViewSource(TableView, "TitleText Name");
            TableView.Source = source;

            var set = this.CreateBindingSet<MainView, MainViewModel>();
            set.Bind(source).To(vm => vm.Speakers);
            set.Bind(source).For(s => s.SelectionChangedCommand).To(vm => vm.ShowDetailCommand);
            set.Apply();

            TableView.ReloadData();
        }
    }
}