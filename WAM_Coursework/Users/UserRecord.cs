namespace WAM_Coursework.Users
{
    public class UserRecord
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
        public int[] RelevantConferenceIds { get; set; }
    }
}
