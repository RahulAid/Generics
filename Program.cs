namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Value");
            float firstValue = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Second Value");
            float secondValue = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter Third Value");
            float thirdValue = Convert.ToSingle(Console.ReadLine());

            MaximumValue.MaximumFloatNumber(firstValue, secondValue, thirdValue);
        }
    }
}