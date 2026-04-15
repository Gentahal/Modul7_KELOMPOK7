using Mod7_103022400067;

class Program
{
    static void Main()
    {
        FilmFavorit filmFavorit = new FilmFavorit();
        filmFavorit.ReadJson();

        Watchlist_103022400067 watchlist = new Watchlist_103022400067(); 
        watchlist.ReadJson();
    }
}