using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models
{
    public class Season
    {
        public int Id { get; set; }
        public Programme Programme { get; set; }
        public int SeasonNumber { get; set; }
        public int EpisodeCount { get; set; }
        public DateTime FinishYear { get; set; }
    }
}
