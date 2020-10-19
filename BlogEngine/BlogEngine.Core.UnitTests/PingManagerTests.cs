using System;
using BlogEngine.Core.Ping;
using NUnit.Framework;

namespace BlogEngine.Core.UnitTests
{
    public class PingManagerTests
    {
        [Test]
        //rename this test...
        public void Test1()
        {
            //investigate the error stack...
            Manager.Send(new Comment(), new Uri("https://cnn.com"));
        }
    }
}