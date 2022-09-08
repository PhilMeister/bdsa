// See https://aka.ms/new-console-template for more information
using FirstApp;

public class Program
{

    //Refactor with Console.ReadLine()
    public static void Main(string[] args)
    {
        if (args != Array.Empty<string>())
        {
        try {
            var input = int.Parse(args[0]);
            if(input >= 1582)
            {
                var result = LeapYearCheck.IsLeapYear(input) switch
                {
                    true => "yay",
                    false => "nay",
                };
                Console.WriteLine(result);
            }
            else
             Console.WriteLine("year must be higher than 1582");
        }
        catch (Exception ex) {
                    Console.WriteLine("input must be an integer", ex.Message);
        }
        }
        else
        Console.WriteLine("Hello, World!");

    }   

}





