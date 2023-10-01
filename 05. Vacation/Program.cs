namespace _05._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string type = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double sum = 0;

            if (season == "Spring")
            {
                if (type == "Hotel")
                {
                    sum = days * 30 * 0.8;
                }else if (type == "Camping")
                {
                    sum = days * 10 * 0.8;
                }
            }else if (season == "Summer")
            {
                if (type == "Hotel")
                {
                    sum = days * 50;
                }
                else if (type == "Camping")
                {
                    sum = days * 30;
                }
            }else if (season == "Autumn")
            {
                if (type == "Hotel")
                {
                    sum = days * 20 * 0.7;
                }
                else if (type == "Camping")
                {
                    sum = days * 15 * 0.7;
                }
            }else if (season == "Winter")
            {
                if (type == "Hotel")
                {
                    sum = days * 40 * 0.9;
                }
                else if (type == "Camping")
                {
                    sum = days * 10 * 0.9;
                }
            }
            Console.WriteLine($"{sum:f2}");

        }
    }
}
