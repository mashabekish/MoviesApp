namespace MoviesApp.Models.Statements;

public class HtmlStatement : Statement
{
    public override string GetHeader(Customer customer)
        => $"<Н1>Прокат <ЕМ>{customer.GetName()}</EM></H1><P>\n";

    public override string GetRental(Rental rental)
        => $"{rental.GetMovie().GetTitle()}: {rental.GetCharge()}<BR>\n";

    public override string GetFooter(Customer customer)
        => $"<Р>Сумма задолженности <ЕМ>{customer.GetTotalCharge()}</EM><P>\n" +
           $"Вы заработали <ЕМ>{customer.GetTotalFrequentRenterPoints()}</ЕМ> бонусных очков<Р>";
}
