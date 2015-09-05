namespace Pepper.NET.Communication.Request
{
    using Communication.Response;

    public abstract class ApiRequest
    {
        public abstract IApiResponse Execute();
    }
}
