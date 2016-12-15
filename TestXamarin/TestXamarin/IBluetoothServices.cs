using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXamarin
{
    interface IBluetoothServices
    {
        void addObserverState(IBluetoothState observer);
        void dettachObserverState(IBluetoothState observer);
        void notifyObserverState();
    }
}
