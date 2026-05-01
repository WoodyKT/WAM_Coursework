using System;
using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Conferences
{
    /// <summary>
    /// An application for a conference talk submitted by a speaker.
    /// </summary>
    public class Talk
    {
        private TalkRecord record = new TalkRecord();

        /// <summary>
        /// Talk class constructor.
        /// </summary>
        /// <param name="title">Title of talk.</param>
        /// <param name="description">Description of the talk's content.</param>
        /// <param name="speakerEmail">Email address of speaker proposing the talk.</param>
        public Talk(string title, string description, string speakerEmail, string speakerAffiliation, string reviewer1email, string reviewer2email)
        {
            record.Title = title;
            record.Description = description;
            record.SpeakerEmail = speakerEmail;
            record.Reviewer1Email = reviewer1email;
            record.Reviewer2Email = reviewer2email;
            record.SpeakerAffiliation = speakerAffiliation;
            record.Id = FileManager.CreateNewId<TalkRecord>(FileManager.StorageFile.talks);
            record.Datetime = DateTime.Now.ToString();
            record.ReviewPassed = false;
        }

        public int Id { get => record.Id; set => record.Id = value; }
        public string Title { get => record.Title; set => record.Title = value; }
        public string Description { get => record.Description; set => record.Description = value; }
        public string Datetime { get => record.Datetime; set => record.Datetime = value; }
        public string SpeakerEmail { get => record.SpeakerEmail; set => record.SpeakerEmail = value; }
        public string SpeakerAffiliation { get => record.SpeakerAffiliation; set => record.SpeakerAffiliation = value; }
        public string Reviewer1Email { get => record.Reviewer1Email; set => record.Reviewer1Email = value; }
        public string Reviewer2Email { get => record.Reviewer2Email; set => record.Reviewer2Email = value; }
        public bool ReviewPassed { get => record.ReviewPassed; set => record.ReviewPassed = value; }

    }
}
