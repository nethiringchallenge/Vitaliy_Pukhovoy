using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OfficeSpace;
using System.Linq;

namespace OfficeSpaceUnitTest
{
    [TestFixture]
    public class UnitTest
    {
        private FindingSpaceForTeam sp;      // main class fpr finding space
        private int[] flour = new int[3];   // number of cubicles on each flour
        private int count = 16;             // number cubicles on one flour
        private int rest = 0;               //rest cubicles on flour
        private int k = 1;                  //flour

        public UnitTest()
        {
            sp =   new FindingSpaceForTeam();
            flour = Enumerable.Repeat(count, 3).ToArray();
        }
        [Test]
        public void TestMethod1()
        {
            sp.Method(flour, k, rest);
        }

        [Test]
        public void TestMethod2()
        {

        }
        [Test]
        public void TestMethod3()
        {

        }
    }
}
