using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace SevillaMobilityDayMVVMCross.Droid.Views
{
    using Android.Content.PM;

    [Activity()]
    public class DetailsView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.DetailsView);
        }
    }
}