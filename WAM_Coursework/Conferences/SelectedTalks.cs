using System;

namespace WAM_Coursework.Conferences
{
    public class SelectedTalks : HasId
    {
        SelectedTalksRecord record = new SelectedTalksRecord();

        /// <summary>
        /// SelectedTalks constructor.
        /// </summary>
        /// <param name="talkId">ID of selected talk.</param>
        /// <param name="startTime">Start date and time of assigned slot.</param>
        public SelectedTalks(int talkId, DateTime startTime)
        {
            record.talkId = talkId;
            record.startTime = startTime;
        }
    }
}
