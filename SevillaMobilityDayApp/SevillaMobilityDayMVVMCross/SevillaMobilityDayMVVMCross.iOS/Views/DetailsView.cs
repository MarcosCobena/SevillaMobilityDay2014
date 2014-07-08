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
    [Register("DetailsView")]
    public class DetailsView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            View = new UIView(UIScreen.MainScreen.Bounds);
            View.BackgroundColor = UIColor.White;

            var speakerNameLabel = new UILabel(new RectangleF(20, 100, 300, 20));
            var sessionTitleLabel = new UILabel(new RectangleF(20, 140, 300, 20));
            var sessionDescriptionLabel = new UILabel(new RectangleF(20, 180, 300, 20));
            var sessionTimeLabel = new UILabel(new RectangleF(20, 220, 300, 20));

            this.Add(speakerNameLabel);
            this.Add(sessionTitleLabel);
            this.Add(sessionDescriptionLabel);
            this.Add(sessionTimeLabel);

            var set = this.CreateBindingSet<DetailsView, DetailsViewModel>();
            set.Bind(speakerNameLabel).To(vm => vm.Speaker.Name); 
            set.Bind(sessionTitleLabel).To(vm => vm.Speaker.SessionTitle); 
            set.Bind(sessionDescriptionLabel).To(vm => vm.Speaker.SessionDescription); 
            set.Bind(sessionTimeLabel).To(vm => vm.Speaker.SessionTime); 
            set.Apply();
        }
    }
}