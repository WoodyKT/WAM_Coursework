using WAM_Coursework.FileHandlers;

namespace WAM_Coursework.Users
{
    public class CurrentUser
    {
        public User User;

        public static readonly CurrentUser Instance = new CurrentUser();

        public void setUser(User user)
        {
            User = user;
        }
    }
}
