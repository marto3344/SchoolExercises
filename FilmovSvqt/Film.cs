using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmovSvqt
{
    public class Film
    {
        private string filmName;

        public string FilmName
        {
            get { return this.filmName; }
            set { this.filmName = value; }
        }
        private DateTime dateOfPremier;
        public DateTime DateOfPremier
        {
            get { return this.dateOfPremier; }
            set { this.dateOfPremier = value; }
        }
        private string genre;
        private string Genre
        {
            get { return this.genre; }
            set { this.genre = value; }
        }


        public Film()
        {

        }
        public Film(string name,DateTime dateOfPremier,string genre)
        {
            this.FilmName = name;
            this.DateOfPremier = dateOfPremier;
            this.genre = genre;
        }
        public override string ToString()
        {
            return $"Movie: {this.FilmName}, genre - {this.genre}, date {this.DateOfPremier.ToString("dd/MM/yyyy")} year";
        }
    }
}
