namespace WAM_Coursework.Conferences
{
    public class Review
    {
       ReviewRecord record = new ReviewRecord();

        public Review(int reviewId, int score, string comment)
        {
            record.Score = score;
            record.Comment = comment;
            record.id = reviewId;
        }

        public int id { get => record.id; set => record.id = value; }

        public int score { get => record.Score; set => record.Score = value; }
        public string comment { get => record.Comment; set => record.Comment = value; }

    }
}
