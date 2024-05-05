using MoviesApp.Models;
using NUnit.Framework;
using Type = MoviesApp.Models.Type;

namespace MoviesApp.Tests;

public class CustomerTests
{
    private Customer _customer;

    [SetUp]
    public void Setup()
    {
        _customer = new Customer("Customer1");
        _customer.AddRental(new Rental(new Movie("Movie1", (Type)0), 5));
        _customer.AddRental(new Rental(new Movie("Movie2", (Type)1), 10));
        _customer.AddRental(new Rental(new Movie("Movie3", (Type)2), 15));
    }

    [Test]
    public void AddRental_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() =>
            _customer.AddRental(new Rental(new Movie("Movie4", (Type)3), 20)),
            "Incorrect Price Code");
    }

    [Test]
    public void GetTextStatement_ShouldReturnCorrectResult()
    {
        var expectedResult = "������ Customer1" +
            "\n\tMovie1\t6,5" +
            "\n\tMovie2\t30" +
            "\n\tMovie3\t19,5" +
            "\n����� �������������: 56" +
            "\n�� ���������� 4 �������� �����";

        var result = _customer.GetTextStatement();
        Assert.That(string.Equals(result, expectedResult));
    }

    [Test]
    public void GetHtmlStatement_ShouldReturnCorrectResult()
    {
        var expectedResult = "<�1>������ <��>Customer1</EM></H1><P>" +
            "\nMovie1: 6,5<BR>" +
            "\nMovie2: 30<BR>" +
            "\nMovie3: 19,5<BR>" +
            "\n<�>����� ������������� <��>56</EM><P>" +
            "\n�� ���������� <��>4</��> �������� �����<�>";

        var result = _customer.GetHtmlStaternent();
        Assert.That(string.Equals(result, expectedResult));
    }
}
