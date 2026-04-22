using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            record.Id = new Random().Next(1, int.MaxValue);//make unique
            record.Datetime = DateTime.Now.ToString();
            record.reviewPassed = false;
        }

        public int Id { get => record.Id; set => record.Id = value; }
        public string Title { get => record.Title; set => record.Title = value; }
        public string Description { get => record.Description; set => record.Description = value; }
        public string Datetime { get => record.Datetime; set => record.Datetime = value; }
        public string SpeakerEmail { get => record.SpeakerEmail; set => record.SpeakerEmail = value; }
        public bool ReviewPassed { get => record.reviewPassed; set => record.reviewPassed = value; }
    }
}
