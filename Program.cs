namespace Generics
{
    internal class Program
    {
        public static void data(int[] inputArray)
        {
            Console.WriteLine("Array with Datatype Int : ");
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }

        public static void data(double[] inputArray)
        {
            Console.WriteLine("\nArray with Datatype Double : ");
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }

        public static void data(char[] inputArray)
        {
            Console.WriteLine("\nArray with Datatype Char : ");
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Program");

            int[] intArray = { 2, 4, 6, 8, 10 };
            double[] doubleArray = { 2.1, 2.2, 2.3, 2.4, 2.5 };
            char[] charArray = { 'G', 'E', 'N', 'E', 'R', 'I', 'C', 'S' };

            Program.data(intArray);
            Program.data(doubleArray);
            Program.data(charArray);

            Console.ReadLine();
        }
    }
}