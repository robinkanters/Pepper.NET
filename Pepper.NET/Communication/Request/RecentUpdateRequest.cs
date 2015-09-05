namespace Pepper.NET.Communication.Request
{
    using System.IO;
    using System.Net;
    using Model;
    using Newtonsoft.Json;
    using Response;

    public class RecentUpdateRequest : ApiRequest
    {
        public const int DEFAULT_STREAM_LIMIT = 60;
        public string AuthenticationToken { get; set; }

        public RecentUpdateRequest(string authenticationToken)
        {
            AuthenticationToken = authenticationToken;
        }

        public override IApiResponse Execute()
        {
            return Execute(DEFAULT_STREAM_LIMIT, 0);
        }

        public IApiResponse Execute(int limit)
        {
            return Execute(limit, 0);
        }

        public IApiResponse Execute(int limit, int offset)
        {
            var uri = $"https://api.pepper.nl/recentupdate?limit={limit}&offset={offset}";

            var request = WebRequest.Create(uri);
            request.Headers.Add("X-Pepper-AuthenticationToken", AuthenticationToken);

            var response = request.GetResponse();
            var dataStream = response.GetResponseStream();
            var reader = new StreamReader(dataStream);
            var responseFromServer = reader.ReadToEnd();

            var theData = JsonConvert.DeserializeObject<RecentUpdateResponse>(responseFromServer);

            return theData;
        }
    }
}
