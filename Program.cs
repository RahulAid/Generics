namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Value");
            string? firstValue = Console.ReadLine();

            Console.WriteLine("Enter Second Value");
            string? secondValue = Console.ReadLine();

            Console.WriteLine("Enter Third Value");
            string? thirdValue = Console.ReadLine();

            MaximumValue.MaximumStringValue(firstValue, secondValue, thirdValue);
        }
    }
}