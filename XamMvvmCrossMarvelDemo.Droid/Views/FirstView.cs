using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace XamMvvmCrossMarvelDemo.Droid.Views
{
	[Activity(Label = "Marvel Comics",  MainLauncher = true, Icon = "@drawable/icon", Theme="@android:style/Theme.DeviceDefault.Light")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}