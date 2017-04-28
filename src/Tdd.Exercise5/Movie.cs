using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tdd.Exercise5
{
    public class Movie
    {
        private IList<int> _ratings = new List<int>();

        public void LeaveReview(int rating)
        {
            _ratings.Add(rating);
        }

        public int AverageRating => (int) _ratings.Average();
    }
}