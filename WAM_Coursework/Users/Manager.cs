namespace WAM_Coursework.Users
{
    internal class Manager : User
    {
        public Manager(string email, string firstName, string lastName, string passwordHash)
   : base(email, firstName, lastName, passwordHash, UserConstants.ManagerRole) { }

        /// <summary>
        /// Not yet implemented.
        /// </summary>
        /// <param name="args"></param>
        public override void CreateAction(string args)
        {
            throw new System.NotImplementedException();
        }
    }
}