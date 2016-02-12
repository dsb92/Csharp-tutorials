using System;

struct Koordinat
{

    private byte x;//Constructor i struct
    private byte ý;
    public Koordinat(byte x, byte y)
    {
        this.x = x;
        this.ý = y;
    }

    //Eksempel på metode i struct
    public void Vis()
    {
        Console.WriteLine("x={0},y={1}", x, ý);
        //Output: x = 10, y = 50
    }
}

class CstructDemo
{
    static void Main(string[] args)
    {
        //Lav instans af struct
        Koordinat k = new Koordinat(10, 50);

        k.Vis();
    }
}
