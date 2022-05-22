
namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Generics Number = new Generics();
            int MaximumNumber = Number.data(11, 67, 24);
            Console.WriteLine("Maximum Integer is " + MaximumNumber);

        }
    }
}