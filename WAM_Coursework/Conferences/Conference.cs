using System;

namespace WAM_Coursework.Conferences
{

    public class Conference
    {
        ConferenceRecord record = new ConferenceRecord();

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
