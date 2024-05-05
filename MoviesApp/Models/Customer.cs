using MoviesApp.Models.Statements;

namespace MoviesApp.Models;

public class Customer(string name)
{
    private readonly string _name = name;
    private readonly List<Rental> _rentals = [];

    public string GetName() => _name;
    public List<Rental> GetRentals() => _rentals;
    public void AddRental(Rental arg) => _rentals.Add(arg);

    public string GetTextStatement() => new TextStatement().GenerateStatement(this);
    public string GetHtmlStaternent() => new HtmlStatement().GenerateStatement(this);

    public double GetTotalCharge()
    {
        double result = 0;
        foreach (Rental each in _rentals)
            result += each.GetCharge();
        return result;
    }

    public int GetTotalFrequentRenterPoints()
    {
        int result = 0;
        foreach (Rental each in _rentals)
            result += each.GetFrequentRenterPoints();
        return result;
    }
}
