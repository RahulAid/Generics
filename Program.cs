namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Value");
            int firstValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Value");
            int secondValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Value");
            int thirdValue = Convert.ToInt32(Console.ReadLine());

            MaximumValue.MaximumIntNumber(firstValue, secondValue, thirdValue);
        }
    }
}