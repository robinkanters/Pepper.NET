namespace Pepper.NET.Communication.Response
{
    using Json;

    public class RecentUpdateResponse : IApiResponse
    {
        public Update[] Data;

        public override string ToString()
        {
            return $"Data: {Data}";
        }
    }
}
