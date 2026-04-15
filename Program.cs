using Mod7_103022400067;

class Program
{
    static void Main()
    {
        FilmFavorit filmFavorit = new FilmFavorit();
        filmFavorit.ReadJson();
        Console.WriteLine();


        Watchlist_103022400067 watchlist = new Watchlist_103022400067(); 
        watchlist.ReadJson();
        Console.WriteLine();



        GenreDictionary_103022400067 gdf = new GenreDictionary_103022400067();
        gdf.ReadJson();
        Console.WriteLine();
    }
}