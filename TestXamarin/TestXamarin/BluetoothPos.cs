using System;
using System.Collections.Generic;


namespace TestXamarin
{
    class BluetoothPos : IBluetoothServices
    {

        List<IBluetoothState> observers = new System.Collections.Generic.List<IBluetoothState>();

        public void addObserverState(IBluetoothState observer)
        {
            observers.Add(observer);
        }

        public void dettachObserverState(IBluetoothState observer)
        {
            observers.Remove(observer);
        }

        public void notifyObserverState()
        {
            foreach(IBluetoothState tmp in observers)
            {
                tmp.setBluetoothState("Estado");
            }
        }
    }
}
