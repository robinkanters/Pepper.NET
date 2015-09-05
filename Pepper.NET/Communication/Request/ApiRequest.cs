namespace Pepper.NET
{
    using Communication;
    using Communication.Response;

    abstract class ApiRequest
    {
        public IApiResponse execute()
        {
            return null;
        }
    }
}
