namespace WAM_Coursework.Conferences
{
    /// <summary>
    /// Database record for a conference.
    /// </summary>
    internal class ConferenceRecord : HasId
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Datetime { get; set; }
        public string Reviewers { get; set; }
        public string Status { get; set; }
    }
}
