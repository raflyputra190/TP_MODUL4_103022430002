// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class KodePos
{
    private Dictionary<string, string> tabelKodePos;

    public KodePos()
    {
        tabelKodePos = new Dictionary<string, string>()
        {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"}
        };
    }

    public string getKodePos(string kelurahan)
    {
        if (tabelKodePos.ContainsKey(kelurahan))
        {
            return tabelKodePos[kelurahan];
        }
        else
        {
            return "Kode pos tidak ditemukan";
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        Console.WriteLine("Batununggal: " + kodePos.getKodePos("Batununggal"));
        Console.WriteLine("Kujangsari: " + kodePos.getKodePos("Kujangsari"));
        Console.WriteLine("Mengger: " + kodePos.getKodePos("Mengger"));
        Console.WriteLine("Wates: " + kodePos.getKodePos("Wates"));
        Console.WriteLine("Cijaura: " + kodePos.getKodePos("Cijaura"));
        Console.WriteLine("Jatisari: " + kodePos.getKodePos("Jatisari"));
        Console.WriteLine("Margasari: " + kodePos.getKodePos("Margasari"));
        Console.WriteLine("Sekejati: " + kodePos.getKodePos("Sekejati"));
        Console.WriteLine("Kebonwaru: " + kodePos.getKodePos("Kebonwaru"));
        Console.WriteLine("Maleer: " + kodePos.getKodePos("Maleer"));
    }
}
