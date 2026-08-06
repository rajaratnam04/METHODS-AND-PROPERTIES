using System;

public class RandomHelper
{
    private static Random random = new Random();

    public static int RandInt(int min, int max)
    {
        return random.Next(min, max +  1);
    }

    public static double RandDouble(int min, int max)
    {
        return min + random.NextDouble() * (max - min);
    }


    static void Main(string[] args)
    {
        int randomInt = RandomHelper.RandInt(1, 10);
        double randomDouble = RandomHelper.RandDouble(1, 10);

        Console.WriteLine("Random Integer (1 to 10): " + randomInt);
        Console.WriteLine("Random Double (1 to 10): " + randomDouble);

      
    }
}