using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ISeasonService
    {
        void AddSeason(int programmeId, int seasonNumber, int episodeCount, DateTime finishYear);
    }

    public class SeasonService : ISeasonService
    {
        private ISeasonRepository _seasonRepository;

        public SeasonService(ISeasonRepository seasonRepository)
        {
            _seasonRepository = seasonRepository;
        }

        public SeasonService()
        {
            _seasonRepository = new SeasonRepository(new ConnectionStringProvider());
        }

        public void AddSeason(int programmeId, int seasonNumber, int episodeCount, DateTime finishYear)
        {
            var season = new Season()
            {
                Programme = new Programme() { Id = programmeId },
                SeasonNumber = seasonNumber,
                EpisodeCount = episodeCount,
                FinishYear = finishYear
            };

            _seasonRepository.AddSeason(season);
        }
    }
}
