using System.Collections.Generic;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Users
{
    internal class Speaker : User
    {
        public Speaker(string email, string firstName, string lastName, string passwordHash)
      : base(email, firstName, lastName, passwordHash, UserConstants.SpeakerRole) { }

        /// <summary>
        /// Takes string talk information submitted via form and splits it to convert into a Talk object, 
        /// then saves object to CSV database.
        /// </summary>
        /// <param name="args">String of application form inputs (talk title and description) </param>
        public override void CreateAction(string args)
        {
            string[] arguments = args.Split(',');

            Talk newTalk = new Talk(arguments[0], arguments[1], CurrentUser.Instance.User.record.Email);
            FileManager.WriteRecords(new List<Talk> { newTalk }, FileManager.StorageFile.talks);
        }

    }
}
