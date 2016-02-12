using System;

    public class ReturVærdier
    {
        public static int Main(string[] args)
        {
            if (args.Length < 3)
                return 1;
            for (int c = 0; c<args.Length;c++)
                Console.WriteLine(args[c]);
            return 0;
        }
    }
}
