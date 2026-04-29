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
