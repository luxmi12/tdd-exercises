using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tdd.Exercise5
{
    public class Movie
    {
        private IList<Rating> _ratings = new List<Rating>();

        public void LeaveReview(Rating rating)
        {
            _ratings.Add(rating);
        }

        public Rating AverageRating
        {
            get
            {
                var average = _ratings.Select(r => Convert.ToInt32(r)).Average();
                return (Rating)(int) Math.Round(average);
            }
        }

        public int NumberOfReviewsFor(Rating rating)
        {
            return _ratings.Count(r => r == rating);
        }
    }
}