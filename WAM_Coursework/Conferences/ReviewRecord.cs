namespace WAM_Coursework.Conferences
{
    /// <summary>
    /// Database record for a review.
    /// </summary>
    public class ReviewRecord : HasId
    {
        public int Score { get; set; }
        public string Comment { get; set; }
        public int attachedTalkId { get; set; }
    }
}
