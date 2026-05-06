using System;

namespace WAM_Coursework.Conferences
{
    /// <summary>
    /// A conference with slots for speaker applications to be assigned to.
    /// </summary>
    public class Conference
    {
        public ConferenceRecord record = new ConferenceRecord();

        public Conference()
        {
        }

        /// <summary>
        /// Conference constructor.
        /// </summary>
        /// <param name="title">conference title.</param>
        /// <param name="location">physical location of conference.</param>
        /// <param name="startDate">conference start date and time.</param>
        /// <param name="endDate">conference end date and time.</param>
        /// <param name="applicationDeadline">date and time when speaker applications close.</param>
        public Conference(string title, string location, DateTime startDate, DateTime endDate, DateTime applicationDeadline)
        {
            record.Title = title;
            record.Location = location;
            record.StartDate = startDate;
            record.EndDate = endDate;
            record.ApplicationDeadline = applicationDeadline;
            record.Id = FileHandlers.FileManager.CreateNewId<ConferenceRecord>(FileHandlers.FileManager.StorageFile.conferences);
        }
    }
}
