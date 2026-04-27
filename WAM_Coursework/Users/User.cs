using System.Collections.Generic;
using System.Linq;
using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Users
{
    public abstract class User
    {
        public UserRecord record = new UserRecord();

        public User(string email, string firstName, string lastName, string passwordHash, string role)
        {
            record.Email = email;
            record.FirstName = firstName;
            record.LastName = lastName;
            record.PasswordHash = passwordHash;
            record.Role = role;
        }

        /// <summary>
        /// Attempt to login to an account
        /// </summary>
        /// <param name="email">User email</param>
        /// <param name="password">User password</param>
        /// <returns>True if login is successful, otherwise false</returns>
        public static bool AttemptLogin(string email, string password)
        {
            var users = FileManager.ReadRecords<UserRecord>(FileManager.StorageFile.users);
            var user = users.FirstOrDefault(u => u.Email == email);
            if (user == null) return false;
            if (BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
            {
                CurrentUser.Instance.User = UserFactory.GetUser(user.Email);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Saves created user to CSV database as a list.
        /// </summary>
        public void SaveAccount()
        {
            FileManager.WriteRecords(new List<UserRecord> { record }, FileManager.StorageFile.users);
        }

        /// <summary>
        /// If the id exists, remove it, if not add it to the user
        /// </summary>
        /// <param name="id"></param>
        private void UpdateAccount(int id)
        {
            UserRecord existing = FileManager.ReadRecords<UserRecord>(FileManager.StorageFile.users).FirstOrDefault(u => u.Email == record.Email);
            if (record.RelevantIds.Contains(id))
            {
                record.RelevantIds.Remove(id);
            }
            else
            {
                record.RelevantIds.Add(id);
            }

        }
        public abstract void CreateAction(string args);
    }
}