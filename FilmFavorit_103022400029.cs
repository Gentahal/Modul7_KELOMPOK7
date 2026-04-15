using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Mod7_103022400067
{
    internal class FilmFavorit_103022400029
    {
        public string title { get; set; }

        public string director { get; set; }

        public string year { get; set; }

        public string genre { get; set; }

        public double rating { get; set; }

        public float durationMinutes { get; set; }

        public bool isWatched { get; set; }



        public void ReadJson()
        {
            string jsonString = File.ReadAllText("jurnal7_1_103022400029.json");
            FilmFavorit_103022400029 film = JsonSerializer.Deserialize<FilmFavorit_103022400029>(jsonString);
            Console.WriteLine($"Judul: {film.title}\n, director: {film.director}\n, tahun: {film.year}\n, genre: {film.genre}\n, rating: {film.rating}\n, durasi: {film.durationMinutes} menit\n, sudah menonton: {film.isWatched}");
        }
    }
}
