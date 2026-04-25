using System.Linq;
using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Users
{
    public static class UserFactory
    {
        public static User CreateUser(string email, string firstName, string lastName, string password, string role)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            User created = null;
            switch (role)
            {
                case UserConstants.ReviewerRole:
                    created = new Reviewer(email, firstName, lastName, passwordHash);
                    break;
                case UserConstants.SpeakerRole:
                    created = new Speaker(email, firstName, lastName, passwordHash);
                    break;
                default:
                    break;
            }
            created.SaveAccount();
            return created;
        }

        public static User GetUser(string email)
        {
            var users = FileManager.ReadRecords<UserRecord>(FileManager.StorageFile.users);
            var user = users.FirstOrDefault(u => u.Email == email);
            if (user == null) return null;
            switch (user.Role)
            {
                case UserConstants.ReviewerRole:
                    return new Reviewer(user.Email, user.FirstName, user.LastName, user.PasswordHash);
                case UserConstants.SpeakerRole:
                    return new Speaker(user.Email, user.FirstName, user.LastName, user.PasswordHash);
                default:
                    break;
            }
            //no found
            return null;
        }
    }
}
