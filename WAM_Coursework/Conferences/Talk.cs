using System;
using System.Collections.Generic;
using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Conferences
{
    public class Talk
    {
        private TalkRecord record = new TalkRecord();

        public Talk(string title, string description, string speakerEmail)
        {
            record.Title = title;
            record.Description = description;
            record.SpeakerEmail = speakerEmail;

            record.Id = FileManager.CreateNewId<TalkRecord>(FileManager.StorageFile.talks);
            record.Datetime = DateTime.Now.ToString();
            record.ReviewPassed = false;
        }

        public int Id { get => record.Id; set => record.Id = value; }
        public string Title { get => record.Title; set => record.Title = value; }
        public string Description { get => record.Description; set => record.Description = value; }
        public string Datetime { get => record.Datetime; set => record.Datetime = value; }
        public string SpeakerEmail { get => record.SpeakerEmail; set => record.SpeakerEmail = value; }
        public bool ReviewPassed { get => record.ReviewPassed; set => record.ReviewPassed = value; }

        public List<int> ReviewIds { get => record.ReviewIds; set => record.ReviewIds = value; }
    }
}
