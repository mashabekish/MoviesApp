namespace MoviesApp.Models;

public class Rental(Movie movie, int daysRented)
{
    private readonly Movie _movie = movie;
    private readonly int _daysRented = daysRented;

    public Movie GetMovie() => _movie;

    public double GetCharge() => _movie.GetCharge(_daysRented);
    public int GetFrequentRenterPoints() => _movie.GetFrequentRenterPoints(_daysRented);
}
