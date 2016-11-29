using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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







    }
}
