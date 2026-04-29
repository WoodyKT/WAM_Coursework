namespace WAM_Coursework.Conferences
{
    /// <summary>
    /// Database record for a talk.
    /// </summary>
    public class TalkRecord : HasId
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Datetime { get; set; }
        public string SpeakerEmail { get; set; }
        public string SpeakerAffiliation { get; set; }
        public string Reviewer1Email { get; set; }
        public string Reviewer2Email { get; set; }
        public bool ReviewPassed { get; set; } = false;

    }
}
