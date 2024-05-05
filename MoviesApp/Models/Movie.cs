using MoviesApp.Models.Prices;

namespace MoviesApp.Models;

public class Movie
{
    private readonly string _title;
    private Price _price;

    public Movie(string title, Type priceType)
    {
        _title = title;
        SetPriceType(priceType);
    }

    public string GetTitle() => _title;

    public void SetPriceType(Type type)
    {
        _price = type switch
        {
            Type.Regular => new RegularPrice(),
            Type.NewRelease => new NewReleasePrice(),
            Type.Childrens => new ChildrensPrice(),
            _ => throw new ArgumentException("Incorrect Price Code"),
        };
    }

    public double GetCharge(int daysRented) => _price.GetCharge(daysRented);
    public int GetFrequentRenterPoints(int daysRented) => _price.GetFrequentRenterPoints(daysRented);
}
