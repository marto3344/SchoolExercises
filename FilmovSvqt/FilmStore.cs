using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmovSvqt
{
    public class FilmStore
    {
        private List<Film> films = new List<Film>();
        public FilmStore()
        {

        }
        public void AddFilm(Film film)
        {
            films.Add(film);
        }
        public override string ToString()
        {
            string result = "";
            foreach (var film in films)
            {
                result += film.ToString() + "\n";
            }
            return result;
        }
    }
}
