using System;

class DoorMachine
{
    private enum State
    {
        Terkunci,
        Terbuka
    }

    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        TampilkanStatus();
    }

    public void BukaPintu()
    {
        if (currentState == State.Terkunci)
        {
            currentState = State.Terbuka;
        }

        TampilkanStatus();
    }

    public void KunciPintu()
    {
        if (currentState == State.Terbuka)
        {
            currentState = State.Terkunci;
        }

        TampilkanStatus();
    }

    private void TampilkanStatus()
    {
        if (currentState == State.Terkunci)
        {
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu tidak terkunci");
        }
    }
}