namespace WAM_Coursework.Conferences
{
    /// <summary>
    /// A review of a talk submitted by an assigned reviewer.
    /// </summary>
    public class Review
    {
        ReviewRecord record = new ReviewRecord();
        /// <summary>
        /// Review class constructor.
        /// </summary>
        /// <param name="Id">Review ID.</param>
        /// <param name="TalkId">ID of talk associated with review.</param>
        /// <param name="Score">Rating out of 10 given to talk.</param>
        /// <param name="Comment">String of feedback on talk provided by reviewer.</param>
 public Review(int Id, int attachedTalkId, int Score, string Comment)>>>>>>> master
        {
            this.Score = Score;
            this.Comment = Comment;
            this.Id = Id;
            this.attachedTalkId = attachedTalkId;
        }

        public int Id { get => record.Id; set => record.Id = value; }

        public int Score { get => record.Score; set => record.Score = value; }
        public string Comment { get => record.Comment; set => record.Comment = value; }

        public int attachedTalkId { get => record.attachedTalkId; set => record.attachedTalkId = value; }

    }
}
