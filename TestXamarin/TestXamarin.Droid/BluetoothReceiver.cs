using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Bluetooth;

namespace TestXamarin.Droid
{
    [BroadcastReceiver]
    public class BluetoothReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            int state = intent.GetIntExtra(BluetoothAdapter.ExtraState, BluetoothAdapter.Error);

            switch (state)
            {
                case (int)State.On:
                    Toast.MakeText(Application.Context, "Bluetooth ON", ToastLength.Short).Show();
                    app.bluetoothManager.setChangeEvent("ON");
                    break;
                case (int)State.TurningOn:
                    Toast.MakeText(Application.Context, "Bluetooth Turning ON", ToastLength.Short).Show();
                    break;
                case (int)State.Off:
                    Toast.MakeText(Application.Context, "Bluetooth OFF", ToastLength.Short).Show();
                    app.bluetoothManager.setChangeEvent("OFF");
                    break;
                case (int)State.TurningOff:
                    Toast.MakeText(Application.Context, "Bluetooth Turning OFF", ToastLength.Short).Show();
                    break;
            }

        }
    }
}