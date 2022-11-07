namespace Generics
{
    internal class Program
    {
        public static void data<T>(T[] inputArray)
        {
            Console.WriteLine($"Array with Datatype {typeof(T)} : ");
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

            Program.data<int>(intArray);
            Program.data<double>(doubleArray);
            Program.data<char>(charArray);

            Console.ReadLine();
        }
    }
}