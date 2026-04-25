namespace WAM_Coursework.Conferences
{
    public class Review
    {
       ReviewRecord record = new ReviewRecord();

        public Review(int score, string comment, int reviewId)
        {
            record.Score = score;
            record.Comment = comment;
            record.ReviewId = reviewId;
        }

    }
}
