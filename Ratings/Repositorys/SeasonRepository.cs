using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ISeasonRepository
    {
        void AddSeason(Season season);
    }

    public class SeasonRepository : BaseSqlRepository, ISeasonRepository
    {
        public SeasonRepository(IConnectionStringProvider connectionStringProvider)
            : base(connectionStringProvider)
        {
        }

        public void AddSeason(Season season)
        {
            var command = GetCommand("AddSeason", System.Data.CommandType.StoredProcedure);

            AddParameter(command, "@ProgrammeId", season.Programme.Id);
            AddParameter(command, "@SeasonNumber", season.SeasonNumber);
            AddParameter(command, "@EpisodeCount", season.EpisodeCount);
            AddParameter(command, "@FinishYear", season.FinishYear);

            ExecuteNonQueryChecked(command);
        }
    }
}
