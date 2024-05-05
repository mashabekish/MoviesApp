namespace MoviesApp.Models.Statements;

public class TextStatement : Statement
{
    public override string GetHeader(Customer customer)
        => $"Прокат {customer.GetName()}\n";

    public override string GetRental(Rental rental)
        => $"\t{rental.GetMovie().GetTitle()}\t{rental.GetCharge()}\n";

    public override string GetFooter(Customer customer)
        => $"Сумма задолженности: {customer.GetTotalCharge()}\n" +
           $"Вы заработали {customer.GetTotalFrequentRenterPoints()} бонусных очков";
}
