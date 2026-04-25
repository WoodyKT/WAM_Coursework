using System.Collections.Generic;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Users
{
    internal class Reviewer : User
    {
        public Reviewer(string email, string firstName, string lastName, string passwordHash)
   : base(email, firstName, lastName, passwordHash, UserConstants.ReviewerRole) { }

        public override void CreateAction(string args)
        {
            string[] arguments = args.Split(',');

            Review newReview = new Review(int.Parse(arguments[0]), arguments[1], int.Parse(arguments[2]));
            FileManager.WriteRecords(new List<Review> { newReview }, FileManager.StorageFile.reviews);
        }
    }
    
}

