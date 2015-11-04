using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoapplication_Test
{
    using Demoapplication;
    using NUnit.Framework;
    public class DummyTest
    {
        [Test]
        public void dummy_1_success()
        {
            Assert.That(true != false);
        }

        [Test]
        public void newClass_Property()
        {
            var test_instance = new newClass();
            Assert.That(test_instance.TestProperty.Equals("Teststring"));
        }
    }
}

