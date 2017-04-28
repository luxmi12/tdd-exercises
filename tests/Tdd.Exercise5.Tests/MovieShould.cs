
using Shouldly;
using Xunit;

namespace Tdd.Exercise5.Tests
{
    public class MovieShould
    {
        private Movie _movie;

        public MovieShould()
        {
            _movie = new Movie();
        }

        [Theory]
        [InlineData(5)]
        [InlineData(1)]
        public void ProvideAverageRatingForSingleReview(int rating)
        {
            _movie.LeaveReview(rating);
            _movie.AverageRating.ShouldBe(rating);
        }
    }
}