using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lab10
{
    class Movie
    {
        public Movie(string name, string category)
        {
            this.name = name;
            this.Category = category;
        }
        internal string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        internal string category;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public enum StarRating
        {

           One,
           Two,
           Three,
           Four,
           Five
        }


        public StarRating Rating { get; set; }

    }

    class MovieContext:DbContext
    {
        public MovieContext():base()
        {

        }

        DbSet<Movie> Movies { get; set; }
    }
   
}
