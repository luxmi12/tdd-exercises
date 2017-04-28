
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

        [Fact]
        public void ProvideAverageRatingForMultipleReviews()
        {
            _movie.LeaveReview(5);
            _movie.LeaveReview(4);
            _movie.LeaveReview(3);

            _movie.AverageRating.ShouldBe(4);
        }

        [Fact]
        public void RoundAverageRating()
        {
            _movie.LeaveReview(5);
            _movie.LeaveReview(5);
            _movie.LeaveReview(4);

            _movie.AverageRating.ShouldBe(5);
        }
    }
}