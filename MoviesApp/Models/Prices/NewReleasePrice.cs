namespace MoviesApp.Models.Prices;

public class NewReleasePrice : Price
{
    public override Type GetPriceType() => Type.NewRelease;

    public override double GetCharge(int daysRented) => daysRented * 3;

    public override int GetFrequentRenterPoints(int daysRented) => daysRented > 1 ? 2 : 1;
}
