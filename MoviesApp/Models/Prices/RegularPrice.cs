namespace MoviesApp.Models.Prices;

public class RegularPrice : Price
{
    public override Type GetPriceType() => Type.Regular;

    public override double GetCharge(int daysRented)
    {
        double result = 2;
        if (daysRented > 2)
            result += (daysRented - 2) * 1.5;
        return result;
    }
}
