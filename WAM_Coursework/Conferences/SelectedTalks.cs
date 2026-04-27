using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAM_Coursework.Conferences
{
    public class SelectedTalks : HasId
    {
        SelectedTalksRecord record = new SelectedTalksRecord();
        public SelectedTalks(int talkId, DateTime startTime)
        {
            record.talkId = talkId;
            record.startTime = startTime;
        }
    }
}
