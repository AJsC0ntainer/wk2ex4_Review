namespace w2ex4_Review;
class Program
{
    public static double a, b;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Hypotenuse Calculator!");
        Console.Write("Enter the length of the first side (a): ");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of the first side (b): ");
        b = Convert.ToDouble(Console.ReadLine());

        DisplayResult();

        Console.WriteLine("Thanks for using Hypotenuse Calculator!");

        Console.Read();

    }

    public static void DisplayResult()
    {
        double c = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
        Console.WriteLine($"The length of the hypotenuse is: {c:F2}");
    }
}

