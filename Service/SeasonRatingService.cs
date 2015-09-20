using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface ISeasonRatingService
    {
        void AddSeasonRating(int personId, int seasonId, double rating, DateTime yearViewed);
    }

    public class SeasonRatingService : ISeasonRatingService
    {
        private ISeasonRatingRepository _seasonRatingRepository;

        public SeasonRatingService(ISeasonRatingRepository seasonRatingRepository)
        {
            _seasonRatingRepository = seasonRatingRepository;
        }

        public SeasonRatingService()
        {
            _seasonRatingRepository = new SeasonRatingRepository(new ConnectionStringProvider());
        }

        public void AddSeasonRating(int personId, int seasonId, double rating, DateTime yearViewed)
        {
            var seasonRating = new SeasonRating()
            {
                Person = new Person() { Id = personId },
                Season = new Season() { Id = seasonId},
                Rating = rating,
                YearViewed = yearViewed
            };

            _seasonRatingRepository.AddRating(seasonRating);
        }
    }
}
