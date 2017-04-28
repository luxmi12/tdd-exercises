
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
        [InlineData(Rating.Excellent)]
        [InlineData(Rating.Poor)]
        public void ProvideAverageRatingForSingleReview(Rating rating)
        {
            _movie.LeaveReview(rating);
            _movie.AverageRating.ShouldBe(rating);
        }

        [Fact]
        public void ProvideAverageRatingForMultipleReviews()
        {
            _movie.LeaveReview(Rating.Excellent);
            _movie.LeaveReview(Rating.Good);
            _movie.LeaveReview(Rating.Average);

            _movie.AverageRating.ShouldBe(Rating.Good);
        }

        [Fact]
        public void RoundAverageRating()
        {
            _movie.LeaveReview(Rating.Excellent);
            _movie.LeaveReview(Rating.Excellent);
            _movie.LeaveReview(Rating.Good);

            _movie.AverageRating.ShouldBe(Rating.Excellent);
        }

        [Theory]
        [InlineData(Rating.Excellent, 2)]
        [InlineData(Rating.Good, 1)]
        public void ReportNumberOfReviewsForEachRating(Rating rating, int numberOfReviews)
        {
            _movie.LeaveReview(Rating.Excellent);
            _movie.LeaveReview(Rating.Excellent);
            _movie.LeaveReview(Rating.Good);

            _movie.NumberOfReviewsFor(rating).ShouldBe(numberOfReviews);
        }
    }
}