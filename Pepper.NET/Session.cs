namespace Pepper.NET
{
    public class Session
    {
        public Session(SessionToken sessionToken, UserId userId)
        {
            SessionToken = sessionToken;
            UserId = userId;
        }

        public SessionToken SessionToken { get; set; }
        public UserId UserId { get; set; }
    }
}
