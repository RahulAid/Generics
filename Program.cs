namespace Generics
{
    public class PrintArray<T>
    {
        public T[] inputArray;

        public PrintArray(T[] inputArray)
        {
            this.inputArray = inputArray;
        }

        public void toPrint()
        {
            Console.WriteLine($"\n Array of Type {typeof(T)} : ");
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Generics Program");

            int[] intArray = { 2, 4, 6, 8, 10 };
            double[] doubleArray = { 2.1, 2.2, 2.3, 2.4, 2.5 };
            char[] charArray = { 'G', 'E', 'N', 'E', 'R', 'I', 'C', 'S' };

            new PrintArray<int>(intArray).toPrint();
            new PrintArray<double>(doubleArray).toPrint();
            new PrintArray<char>(charArray).toPrint();

            Console.ReadLine();
        }
    }
}