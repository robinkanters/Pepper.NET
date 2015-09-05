namespace Pepper.NET.Tests.Communication.Request
{
    using System;
    using NET.Communication.Request;
    using NET.Communication.Response;
    using NUnit.Framework;

    public class RecentUpdateRequestTest
    {
        public RecentUpdateRequest Request { get; set; }

        [SetUp]
        public void SetUp()
        {
            var authenticationToken = string.Empty;
            Request = new RecentUpdateRequest(authenticationToken);
        }

        [Test]
        public void Execute_WithNoArguments_ReturnsBetweenZeroAndSixtyUpdates()
        {
            var response = (RecentUpdateResponse) Request.Execute();

            for (var i = 0; i < Math.Max(response.Data.Length, 10); i++)
                Console.WriteLine(response.Data[i].ToString());

            Assert.That(response.Data.Length, Is.GreaterThan(0));
            Assert.That(response.Data.Length, Is.LessThanOrEqualTo(60));
        }
    }
}
