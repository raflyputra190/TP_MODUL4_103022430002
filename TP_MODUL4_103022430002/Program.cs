using System;

class Program
{
    static void Main(string[] args)
    {
        DoorMachine pintu = new DoorMachine();

        pintu.BukaPintu();
        pintu.KunciPintu();
        pintu.BukaPintu();
    }
}