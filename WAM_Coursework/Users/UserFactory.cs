using System;
using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Users
{
    public static class UserFactory
    {
        public static void CreateAccount(string email, string firstName, string lastName, string password, string role)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);
            string userInfo = $"{email},{firstName},{lastName},{passwordHash},{role},";
            FileManager.WriteToFile(userInfo, FileManager.StorageFile.users);
        }
    }
}
