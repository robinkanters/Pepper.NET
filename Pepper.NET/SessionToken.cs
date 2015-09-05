namespace Pepper.NET
{
    using System;

    public class SessionToken
    {
        public SessionToken(Guid token)
        {
            Token = token;
        }

        public Guid Token { get; private set; }
    }
}