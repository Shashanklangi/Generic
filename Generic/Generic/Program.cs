
namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 110, 123, 613, 723, 231, 444, 568, };
            MaxNumber<int> maxNumber = new MaxNumber<int>(intArray);
            Console.WriteLine("The Maximum Integer is " + maxNumber.MaxMethod());

            double[] doubleArray = { 41.54, 34.1, 5.33, 89.19, 1.71 };
            MaxNumber<double> maxDouble = new MaxNumber<double>(doubleArray);
            Console.WriteLine("The Maximum Float Value is " + maxDouble.MaxMethod());

            string[] stringArray = { "Apple", "Lemon", "Banana", "Pineapple","Grapes" };
            MaxNumber<string> maxString = new MaxNumber<string>(stringArray);
            Console.WriteLine("The Maximum String Value is " + maxString.MaxMethod());
        }
    }
}