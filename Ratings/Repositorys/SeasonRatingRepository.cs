using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ISeasonRatingRepository
    {
        void AddRating(SeasonRating rating);
    }

    public class SeasonRatingRepository : BaseSqlRepository, ISeasonRatingRepository
    {
        public SeasonRatingRepository(IConnectionStringProvider connectionStringProvider)
            : base(connectionStringProvider)
        {
        }

        public void AddRating(SeasonRating rating)
        {
            var command = GetCommand("AddSeasonRating", System.Data.CommandType.StoredProcedure);

            AddParameter(command, "@PersonId", rating.Person.Id);
            AddParameter(command, "@SeasonId", rating.Season.Id);
            AddParameter(command, "@Rating", rating.Rating);
            AddParameter(command, "@YearViewed", rating.YearViewed);

            ExecuteNonQueryChecked(command);
        }
    }
}
