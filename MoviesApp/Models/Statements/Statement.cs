namespace MoviesApp.Models.Statements;

public abstract class Statement
{
    public abstract string GetHeader(Customer customer);
    public abstract string GetRental(Rental rental);
    public abstract string GetFooter(Customer customer);

    public string GenerateStatement(Customer customer)
    {
        string result = GetHeader(customer);

        foreach (Rental rental in customer.GetRentals())
            result += GetRental(rental);

        result += GetFooter(customer);
        return result;
    }
}
