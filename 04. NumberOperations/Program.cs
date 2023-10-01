namespace _04._NumberOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            string op = Console.ReadLine();
            double sum = 0;

            if (op == "+")
                sum = num1 + num2;
            if (op == "-")
                sum = num1 - num2;
            if (op == "*")
                sum = num1 * num2;
            if (op == "/")
                sum = num1 / num2;
            Console.WriteLine($"{num1} {op} {num2} = {sum:f2}");

        }
    }
}