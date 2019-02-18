using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Urls;

namespace JenkinsWithNunit
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            string st = UrlClass.GetValue();
            Assert.IsNotEmpty(st);
        }
    }
}
