namespace WAM_Coursework.Users
{
    /// <summary>
    /// The conference manager account.
    /// </summary>
    internal class Manager : User
    {
        /// <summary>
        /// Conference manager constructor.
        /// </summary>
        /// <param name="email">CM email.</param>
        /// <param name="firstName">CM first name.</param>
        /// <param name="lastName">CM surname.</param>
        /// <param name="passwordHash">hashed CM password.</param>
        public Manager(string email, string firstName, string lastName, string passwordHash, string affiliation)
   : base(email, firstName, lastName, passwordHash, UserConstants.ManagerRole, affiliation) { }

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