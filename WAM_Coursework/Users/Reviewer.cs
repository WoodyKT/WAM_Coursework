using System.Collections.Generic;
using WAM_Coursework.Conferences;
using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Users
{
    /// <summary>
    /// A reviewer account.
    /// </summary>
    internal class Reviewer : User
    {
        /// <summary>
        /// Reviewer constructor.
        /// </summary>
        /// <param name="email">Reviewer email address.</param>
        /// <param name="firstName">Reviewer first name.</param>
        /// <param name="lastName">Reviewer surname.</param>
        /// <param name="passwordHash">Hashed reviewer password.</param>
        public Reviewer(string email, string firstName, string lastName, string passwordHash)
   : base(email, firstName, lastName, passwordHash, UserConstants.ReviewerRole) { }

        /// <summary>
        /// Create review
        /// </summary>
        /// <param name="args">reviewid,talkid, score, comment</param>
        public override void CreateAction(string args)
        {
            string[] arguments = args.Split(',');

            Review newReview = new Review(int.Parse(arguments[0]), int.Parse(arguments[1]), int.Parse(arguments[2]), arguments[3]);
            FileManager.WriteRecords(new List<Review> { newReview }, FileManager.StorageFile.reviews);
        }
    }

}

