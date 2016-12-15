
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;

namespace TestXamarin.Droid
{
    [Activity(Label = "TestXamarin", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private IntentFilter filter;
        private BluetoothReceiver receiver;

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new app());
            initBluetooth();
        }

        private void initBluetooth()
        {
            receiver = new BluetoothReceiver();
            filter = new IntentFilter(Android.Bluetooth.BluetoothAdapter.ActionStateChanged);
            Android.App.Application.Context.RegisterReceiver(receiver, filter);
        }

    }
}

