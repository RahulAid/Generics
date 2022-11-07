namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaximumValue<int>.MaximumStringValue(7, 5, 3);

            MaximumValue<float>.MaximumStringValue(9.6f, 48.6f, 52.4f);

            MaximumValue<string>.MaximumStringValue("John", "Fn", "Kennedy");
        }
    }
}