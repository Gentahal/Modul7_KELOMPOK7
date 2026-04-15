using System;
using System.Collections.Generic;
using System.Text.Json;

public class FilmFavorit
{
    public string title { get; set; }
    public string director { get; set; }
    public string year { get; set; }
    public string genre { get; set; }
    public double rating { get; set; }
    public int durationMinutes { get; set; }

    public bool isWatched { get; set; }

    public void ReadJson()
    {
        string json1 = File.ReadAllText("jurnal7_1_103022400067.json");

        var filmFavorit = JsonSerializer.Deserialize<FilmFavorit>(json1);

        Console.WriteLine($"Title: {filmFavorit.title} Director: {director} Year: {year} Genre: {genre} Rating: {rating} DurationMinutes {durationMinutes}");
    }

}
