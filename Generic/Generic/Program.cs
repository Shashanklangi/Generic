
namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] intArray = { 19, 213, 635, 734, 231, 56 };
            MaxNumber<int> maxNumber = new MaxNumber<int>(intArray);
            maxNumber.PrintMax();

            double[] doubleArray = { 41.55, 34.112, 156.33, 829.49, 111.71 };
            MaxNumber<double> maxDouble = new MaxNumber<double>(doubleArray);
            maxDouble.PrintMax();

            string[] stringArray = { "Apple", "Grapes", "Banana", "Jackfruit","Pineapple" };
            MaxNumber<string> maxString = new MaxNumber<string>(stringArray);
            maxString.PrintMax(); ;
        }
    }
}