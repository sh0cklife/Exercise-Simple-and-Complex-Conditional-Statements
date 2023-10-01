namespace _10._SummerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            string clothing = "";
            string shoes = "";

            if (day == "Evening")
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }else if (day == "Afternoon" && temp <= 18)
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }
            else if (day == "Morning" && temp > 18 && temp <= 24)
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }else if ((day == "Morning" && temp >= 25) || (day == "Afternoon" && temp > 18 && temp <= 24))
            {
                clothing = "T-Shirt";
                shoes = "Sandals";
            }
            else if (day == "Morning" &  temp <= 18)
            {
                clothing = "Sweatshirt";
                shoes = "Sneakers";
            }else if (day == "Afternoon" && temp >= 25)
            {
                clothing = "Swim Suit";
                shoes = "Barefoot";
            }
            Console.WriteLine($"It's {temp} degrees, get your {clothing} and {shoes}.");
        }
    }
}