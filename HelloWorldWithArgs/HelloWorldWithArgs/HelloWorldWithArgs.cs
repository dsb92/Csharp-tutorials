using System;

public class HalloWorldWithArgs
{
    public static void Main(string[] args)
    {
        for (int c = 0; c < args.Length; c++)
            Console.WriteLine(args[c]);
    }
}