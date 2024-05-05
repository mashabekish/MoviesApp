namespace MoviesApp.Models.Prices;

public class ChildrensPrice : Price
{
    public override Type GetPriceType() => Type.Childrens;

    public override double GetCharge(int daysRented)
    {
        double result = 1.5;
        if (daysRented > 3)
            result += (daysRented - 3) * 1.5;
        return result;
    }
}
