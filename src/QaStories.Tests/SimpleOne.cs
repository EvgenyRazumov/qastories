using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QaStories.Tests
{
    public class SimpleOne
    {
        [Test]
        public void Test01()
        {
            Assert.AreEqual(0, 0);
        }

        [Test]
        public void Test02()
        {
            Assert.AreEqual(1, 0);
        }
    }
}
