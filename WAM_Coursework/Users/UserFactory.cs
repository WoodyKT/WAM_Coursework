using System.Linq;
using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Users
{
    /// <summary>
    /// Handles user creation and access from the database.
    /// </summary>
    public static class UserFactory
    {
        /// <summary>
        /// Takes in user-submitted details for a new account, including flag for speaker or reviewer account.
        /// Hashes password and creates Speaker or Reviewer object as required to be returned.
        /// </summary>
        /// <param name="email">User's email address.</param>
        /// <param name="firstName">User's first name.</param>
        /// <param name="lastName">User's last name.</param>
        /// <param name="password">Plaintext password entered by user (to be hashed).</param>
        /// <param name="role">Defines whether account to be created should be a speaker or reviewer account.</param>
        /// <returns>Created user object.</returns>
        public static User CreateUser(string email, string firstName, string lastName, string password, string role, string affiliation)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            User created = null;
            switch (role)
            {
                case UserConstants.ReviewerRole:
                    created = new Reviewer(email, firstName, lastName, passwordHash, affiliation);
                    break;
                case UserConstants.SpeakerRole:
                    created = new Speaker(email, firstName, lastName, passwordHash, affiliation);
                    break;
                case UserConstants.ManagerRole:
                    created = new Manager(email, firstName, lastName, passwordHash, affiliation);
                    break;
                default:
                    break;
            }
            created.SaveAccount();
            return created;
        }

        /// <summary>
        /// Searches CSV database for a user by email address.
        /// </summary>
        /// <param name="email">the email address to be searched for.</param>
        /// <returns>A copy of the matching user object if match found.</returns>
        public static User GetUser(string email)
        {
            var users = FileManager.ReadRecords<UserRecord>(FileManager.StorageFile.users);
            var user = users.FirstOrDefault(u => u.Email == email);
            if (user == null) return null;
            switch (user.Role)
            {
                case UserConstants.ReviewerRole:
                    return new Reviewer(user.Email, user.FirstName, user.LastName, user.PasswordHash, user.Affiliation);
                case UserConstants.SpeakerRole:
                    return new Speaker(user.Email, user.FirstName, user.LastName, user.PasswordHash, user.Affiliation);
                case UserConstants.ManagerRole:
                    return new Manager(user.Email, user.FirstName, user.LastName, user.PasswordHash, user.Affiliation);
                default:
                    break;
            }
            //no found
            return null;
        }
    }
}
