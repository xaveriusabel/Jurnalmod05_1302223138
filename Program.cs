// See https://aka.ms/new-console-template for more information
using System.Numerics;

Console.WriteLine("Hello, World!");

public class penjumlahan<T>
{

    public T JumlahTigaAngka<T>(T parameter1, T parameter2, T parameter3) where T : IAdditionOperators<T, T, T>
    {
        return parameter1 + parameter2 + parameter3;
    }
}

class main
{
    public static void Main(string[] args)
    {
        penjumlahan<int> penjumlahan = new penjumlahan<int>();
        int angka1 = 13;
        int angka2 = 02;
        int angka3 = 22;
        Console.WriteLine(penjumlahan.JumlahTigaAngka(angka1, angka2, angka3));
    }
}