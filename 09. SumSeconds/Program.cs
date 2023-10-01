namespace _09._SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int time = a + b + c;
            int minutes = time / 60;    // целочислено деление
            int seconds = time % 60;    // деление с остатък

            string leadingZero = "";
            if (seconds < 10)
            {
                leadingZero = "0";
            }

            Console.WriteLine($"{minutes}:{leadingZero}{seconds}");

        }
    }
}