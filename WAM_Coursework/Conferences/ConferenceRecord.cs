using System;

namespace WAM_Coursework.Conferences
{
    public class ConferenceRecord : HasId
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ApplicationDeadline { get; set; }


    }
}
