namespace WAM_Coursework.Users
{
    internal class Reviewer : User
    {
        public Reviewer(string email, string firstName, string lastName, string passwordHash)
   : base(email, firstName, lastName, passwordHash, UserConstants.ReviewerRole) { }
    }
}
