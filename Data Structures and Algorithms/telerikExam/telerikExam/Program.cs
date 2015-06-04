using System;
using System.Numerics;


class NightmareOnCodeStreet
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char[] arr = input.ToCharArray();

        BigInteger counter = 0;
        BigInteger sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if ((i % 2) != 0)
            {
                BigInteger proba = BigInteger.Parse(arr[i].ToString());
                sum += proba;
                counter++;
            }
        }
        Console.WriteLine("{0} {1}", counter, sum);
    }
}