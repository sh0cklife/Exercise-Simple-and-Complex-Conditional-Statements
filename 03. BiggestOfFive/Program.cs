namespace _03._BiggestOfFive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            int max = num1;

           if (num2 > max)
            max = num2;
           if (num3 > max)
            max = num3;
           if (num4 > max)
            max = num4;
            if (num5 > max)
            max = num5;

            Console.WriteLine(max);


        }
    }
}