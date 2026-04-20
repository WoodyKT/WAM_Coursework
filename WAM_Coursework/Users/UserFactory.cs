namespace WAM_Coursework.Users
{
    public static class UserFactory
    {
        public static User CreateUser(string email, string firstName, string lastName, string password, string role)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            switch (role)
            {
                case UserConstants.ReviewerRole:
                    return new Reviewer(email, firstName, lastName, passwordHash);
                case UserConstants.SpeakerRole:
                    return new Speaker(email, firstName, lastName, passwordHash);
                default:
                    break;
            }
            return null;
        }
    }
}
