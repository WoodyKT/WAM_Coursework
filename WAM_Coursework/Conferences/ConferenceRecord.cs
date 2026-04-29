using System;

namespace WAM_Coursework.Conferences
{
    /// <summary>
    /// Database record for a conference.
    /// </summary>
    public class ConferenceRecord : HasId

    {
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }


    }
}
