namespace WAM_Coursework.Conferences
{
    public class ReviewRecord : HasId
    {
        public int Score { get; set; }
        public string Comment { get; set; }


        public int attatchedReviewId { get; set; }
    }
}
