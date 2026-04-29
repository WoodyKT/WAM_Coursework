using System.Collections.Generic;

namespace WAM_Coursework.Users
{
    /// <summary>
    /// A database record for a user.
    /// </summary>
    public class UserRecord
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public List<int> RelevantIds { get; set; }
    }
}
