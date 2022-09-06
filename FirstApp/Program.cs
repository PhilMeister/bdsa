// See https://aka.ms/new-console-template for more information
using FirstApp;

public class Program
{
    public static void Main(string[] args)
    {
        var input = int.Parse(args[0]);
        var result = "";
        
        var output = LeapYearCheck.IsLeapYear(input) switch
        {
            true => result = "yay",
            false => result ="nay",
        };

        Console.WriteLine(result);
        Console.WriteLine("Hello, World!");

    }   

}





