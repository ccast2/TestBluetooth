using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestXamarin
{
    public class EventoBluetooth
    {
        private static EventoBluetooth instance;
        
        private EventoBluetooth()
        {
        }

        public static EventoBluetooth getInstance()
        {
            if(instance==null)
            {
                instance = new EventoBluetooth();
            }
            return instance;
        }

        List<IBluetoothState> observers = new System.Collections.Generic.List<IBluetoothState>();

        public void addObserverState(IBluetoothState observer)
        {
            observers.Add(observer);
        }

        public void dettachObserverState(IBluetoothState observer)
        {
            observers.Remove(observer);
        }

        public void notifyObserverState(string state)
        {
            foreach (IBluetoothState tmp in observers)
            {
                tmp.setBluetoothState(state);
            }
        }

        public void setChangeEvent(string state)
        {
            app.etiqueta.Text = state;
            notifyObserverState(state);
        }

    }
}
