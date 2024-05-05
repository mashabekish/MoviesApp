namespace MoviesApp.Models.Prices;

public abstract class Price
{
    public abstract Type GetPriceType();
    public abstract double GetCharge(int daysRented);

    public virtual int GetFrequentRenterPoints(int daysRented) => 1;
}
