using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.collections
{
    public class Movie
    {
        public string title { get; set; }
        public ProductionStudio production_studio { get; set; }
        public Genre genre { get; set; }
        public int rating { get; set; }
        public DateTime date_published { get; set; }

        public static bool operator ==(Movie obj1, object obj2)
        {
            return obj1.Equals(obj2);
        }

        public static bool operator !=(Movie obj1, object obj2)
        {
            return !obj1.Equals(obj2);
        }

        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return ((Movie) obj).title == title;

        }

        public override int GetHashCode()
        {
            return title.GetHashCode();
        }
    }
}