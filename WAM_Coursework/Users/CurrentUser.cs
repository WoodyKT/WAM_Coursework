namespace WAM_Coursework.Users
{
    /// <summary>
    /// The user who is currently signed into the application.
    /// </summary>
    public class CurrentUser
    {
        public User User;

        public static readonly CurrentUser Instance = new CurrentUser();
    }
}
