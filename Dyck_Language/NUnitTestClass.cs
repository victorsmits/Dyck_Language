using NUnit.Framework;
using System;
using System.Collections.Generic;
namespace Dyck_Language
{
    [TestFixture()]
    public class NUnitTestClass
    {


        [Test()]
        public void TestIsDyckString()
        {
            var alphabet = new Dictionary<string, string>
            {
                { "(", ")" },
                { "{", "}" },
                { "[", "]" }
            };

            Assert.IsTrue(MainClass.IsDyckString("(", alphabet));
            Assert.IsTrue(MainClass.IsDyckString("bonjour (victor)", alphabet));
            Assert.IsTrue(MainClass.IsDyckString("(())", alphabet));
            Assert.IsTrue(MainClass.IsDyckString("{{}}", alphabet));
            Assert.IsFalse(MainClass.IsDyckString(")(())", alphabet));
            Assert.IsFalse(MainClass.IsDyckString("}(())", alphabet));
            Assert.IsFalse(MainClass.IsDyckString("{(})", alphabet));
        }
    }
}
