﻿namespace _02._ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = int.Parse(Console.ReadLine());
            int withdraw = int.Parse(Console.ReadLine());
            int limit = int.Parse(Console.ReadLine());

            if (balance > withdraw && limit > withdraw)
                Console.WriteLine("The withdraw was successful.");
            else if (limit < withdraw)
                Console.WriteLine("The limit was exceeded.");
            else
                Console.WriteLine("Insufficient availability.");

        }
    }
}