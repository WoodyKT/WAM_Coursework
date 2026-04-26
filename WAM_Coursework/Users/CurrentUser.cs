namespace WAM_Coursework.Users
{
    public class CurrentUser
    {
        public User User;

        public static readonly CurrentUser Instance = new CurrentUser();

        /// <summary>
        /// Sets currently logged in user to the user passed in.
        /// </summary>
        /// <param name="user">User to be made active.</param>
        public void setUser(User user)
        {
            User = user;
        }
    }
}
