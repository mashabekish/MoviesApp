using MoviesApp.Models;
using Type = MoviesApp.Models.Type;

namespace MoviesApp;

public class Program
{
    static void Main()
    {
        var customer = new Customer("Customer1");
        customer.AddRental(new Rental(new Movie("Movie1", Type.Regular), 5));
        customer.AddRental(new Rental(new Movie("Movie2", Type.NewRelease), 10));
        customer.AddRental(new Rental(new Movie("Movie3", Type.Childrens), 15));

        var textResult = customer.GetTextStatement();
        Console.WriteLine(textResult);

        Console.WriteLine();

        var htmlResult = customer.GetHtmlStaternent();
        Console.WriteLine(htmlResult);
    }
}
