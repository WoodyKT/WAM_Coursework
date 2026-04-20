namespace WAM_Coursework.Users
{
    internal class Speaker : User
    {
        public Speaker(string email, string firstName, string lastName, string passwordHash)
      : base(email, firstName, lastName, passwordHash, UserConstants.SpeakerRole) { }



    }
}
