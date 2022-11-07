namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 100, 300, 400, 500, 600 };

            MaximumValue<int> maximumValue = new MaximumValue<int>(arr);
            maximumValue.PrintMaxValue();
        }
    }
}