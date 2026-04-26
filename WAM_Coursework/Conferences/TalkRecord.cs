namespace WAM_Coursework.Conferences
{
    public class TalkRecord : HasId
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Datetime { get; set; }
        public string SpeakerEmail { get; set; }
        public bool ReviewPassed { get; set; } = false;
    }
}
