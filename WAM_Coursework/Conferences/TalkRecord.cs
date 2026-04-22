using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAM_Coursework.Conferences
{
    public class TalkRecord
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Datetime { get; set; }
        public string SpeakerEmail { get; set; }
        public bool reviewPassed { get; set; } = false;
    }
}
