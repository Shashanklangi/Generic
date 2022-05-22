
namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Generics alpha = new Generics();
            string Maxistring = alpha.data("Apple","Banana","Pineapple");
            Console.WriteLine("Maximum string is " + Maxistring);
        }
    }
}