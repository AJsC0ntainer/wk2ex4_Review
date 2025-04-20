namespace w2ex4_Review;
class Program
{
    // public variables to store the sides of the triangle
    public static double a, b;
    static void Main(string[] args)
    {
        // greet the user
        Console.WriteLine("Welcome to the Hypotenuse Calculator!");
        // ask for the first side (a) and store it
        Console.Write("Enter the length of the first side (a): ");
        a = Convert.ToDouble(Console.ReadLine());
        // ask for the second side (b) and store it
        Console.Write("Enter the length of the first side (b): ");
        b = Convert.ToDouble(Console.ReadLine());
        // call method to calculate and show hypotenuse
        DisplayResult();
        // end message to the user
        Console.WriteLine("Thanks for using Hypotenuse Calculator!");
        // keeps the console window open
        Console.Read();
    }
    // method that calculates hypotenuse using pythagorean formula
    public static void DisplayResult()
    {
        // use Math.Pow to square sides, Math.Sqrt to get square root
        double c = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));
        // print result rounded to 2 decimals
        Console.WriteLine($"The length of the hypotenuse is: {c:F2}");
    }
}
//Pushed to GitHub wk3ex4 repo.