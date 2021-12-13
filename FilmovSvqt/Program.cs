using System;

namespace FilmovSvqt
{
    class Program
    {
        static void Main(string[] args)
        {
            var film1 = new Film("Venom 2", new DateTime(2021,10,1), "action");
            var film2 = new Film("Cars", new DateTime(2006, 8, 4), "comedy");
            var film3 = new Film("Fast and furious 9", new DateTime(2021, 6, 25), "action");
            var film4 = new Film("Baywatch", new DateTime(2017,6,2),"comedy");
            var filmStore = new FilmStore();
            filmStore.AddFilm(film1);
            filmStore.AddFilm(film2);
            filmStore.AddFilm(film3);
            filmStore.AddFilm(film4);
            Console.WriteLine(filmStore.ToString());
        }
    }
}
