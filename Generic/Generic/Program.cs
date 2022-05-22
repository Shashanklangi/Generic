
namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Generics Number = new Generics();
            double MaximumNumber = Number.data(11.54, 67.82, 24.1);
            Console.WriteLine("Maximum Floating Integer is " + MaximumNumber);

        }
    }
}