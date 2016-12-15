using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CoreBluetooth;

namespace TestXamarin.iOS
{
    class BluetoothReceiver : CBCentralManagerDelegate
    {
        public override void UpdatedState(CBCentralManager central)
        {
            Console.WriteLine("central state: " + central.State);
            switch (central.State)
            {
                case CBCentralManagerState.PoweredOn:
                    Console.WriteLine("CBCentralManagerState.PoweredOn");
                    app.bluetoothManager.setChangeEvent("ON");
                    break;
                case CBCentralManagerState.PoweredOff:
                    Console.WriteLine("CBCentralManagerState.PoweredOff");
                    app.bluetoothManager.setChangeEvent("OFF");
                    break;
            }
        }
    }
}