namespace Tdd.Exercise5
{
    public class Movie
    {
        private int _rating;

        public void LeaveReview(int rating)
        {
            _rating = rating;
        }

        public int AverageRating => _rating;
    }
}