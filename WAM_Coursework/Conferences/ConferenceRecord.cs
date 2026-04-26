namespace WAM_Coursework.Conferences
{
    internal class ConferenceRecord : HasId
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Datetime { get; set; }
        public string Reviewers { get; set; }
        public string Status { get; set; }
    }
}
