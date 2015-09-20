using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class SeasonRating
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public Season Season { get; set; }
        public double Rating { get; set; }
        public DateTime YearViewed { get; set; }
    }
}
