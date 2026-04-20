using System.Linq;
using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Users
{
    public abstract class User
    {
        UserRecord record = new UserRecord();

        public User(string email, string firstName, string lastName, string passwordHash, string role)
        {
            record.Email = email;
            record.FirstName = firstName;
            record.LastName = lastName;
            record.PasswordHash = passwordHash;
            record.Role = role;
            SaveAccount();
        }

        public static bool AttemptLogin(string email, string password)
        {
            var users = FileManager.ReadRecords<UserRecord>(FileManager.StorageFile.users);
            var user = users.FirstOrDefault(u => u.Email == email);
            if (user == null) return false;
            return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
        }

        public void SaveAccount()
        {
            var existing = FileManager.ReadRecords<UserRecord>(FileManager.StorageFile.users);
            existing.Add(record);
            FileManager.WriteRecords(existing, FileManager.StorageFile.users);
        }
    }
}