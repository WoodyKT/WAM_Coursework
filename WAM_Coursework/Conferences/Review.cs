namespace WAM_Coursework.Conferences
{
    public class Review
    {
       ReviewRecord record = new ReviewRecord();

        public Review(int Id, int TalkId, int Score, string Comment)
        {
            this.Score = Score;
            this.Comment = Comment;
            this.Id = Id;
            this.attatchedReviewId = TalkId;
        }

        public int Id { get => record.Id; set => record.Id = value; }

        public int Score { get => record.Score; set => record.Score = value; }
        public string Comment { get => record.Comment; set => record.Comment = value; }

        public int attatchedReviewId { get => record.attatchedReviewId; set => record.attatchedReviewId = value; }

    }
}
