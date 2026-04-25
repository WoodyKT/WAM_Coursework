using System.Collections.Generic;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Users
{
    internal class Speaker : User
    {
        public Speaker(string email, string firstName, string lastName, string passwordHash)
      : base(email, firstName, lastName, passwordHash, UserConstants.SpeakerRole) { }

        public override void CreateAction(string args)
        {
            string[] arguments = args.Split(',');

            Talk newTalk = new Talk(arguments[0], arguments[1], CurrentUser.Instance.User.record.Email);
            FileManager.WriteRecords(new List<Talk> { newTalk }, FileManager.StorageFile.talks);
        }

    }
}
