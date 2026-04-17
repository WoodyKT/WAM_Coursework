using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Users
{
    abstract class User
    {
        public string _email { get; private set; }
        public string _firstName { get; private set; }
        public string _lastName { get; private set; }


        public bool AttemptLogin(string email, string password)
        {
            string userInfo = FileManager.GetFromFile(email, FileManager.StorageFile.users);
            string savedPassword = userInfo.Split(',')[3];
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            if (BCrypt.Net.BCrypt.Verify(password, savedPassword))
            {
                return true;
            }
            return false;
        }

        public void CreateAccount(string email, string firstName, string lastName, string password)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            string userInfo = $"{email},{firstName},{lastName},{passwordHash}";
            FileManager.WriteToFile(userInfo, FileManager.StorageFile.users);
        }
    }
}