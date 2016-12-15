using System;

public abstract class EstadoBluetooth
{

    public static int ON = 1;
    public static int OFF = 0;

    public static int state;

    public int getState()
    {
        return state;
    }

    public void setState(int st)
    {
        state = st;
    }

}
