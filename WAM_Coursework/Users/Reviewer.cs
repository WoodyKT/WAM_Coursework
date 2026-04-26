namespace WAM_Coursework.Users
{
    internal class Reviewer : User
    {
        public Reviewer(string email, string firstName, string lastName, string passwordHash)
   : base(email, firstName, lastName, passwordHash, UserConstants.ReviewerRole) { }

        /// <summary>
        /// Not yet implemented.
        /// </summary>
        /// <param name="args"></param>
        public override void CreateAction(string args)
        {
            throw new System.NotImplementedException();
        }
    }
}

