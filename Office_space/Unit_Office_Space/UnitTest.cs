using System;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OfficeSpace;
using System.Linq;
using System.Reflection;
using System.Collections.Generic;

namespace OfficeSpaceUnitTest
{
    [TestFixture]
    public class UnitTest
    {
        private FindingSpaceForTeam sp;      // main class fpr finding space
        private FillingData dat;
        private int[] flour = new int[3];   // number of cubicles on each flour
        private int count = 16;             // number cubicles on one flour
        private int rest = 0;               //rest cubicles on flour
        private int k = 1;
        private int[] cubicles;
        private int cubicle = 4;
        private int personInTeam = 7;
        private int[] data = { 2, 3, 6, 8, 5 };
        private Dictionary<int, int> dic;   
        

        public UnitTest()
        {
            int[] cubicles = Enumerable.Range(4, 64).Where(c => c % 4 == 0).ToArray();
            sp =   new FindingSpaceForTeam(dic, cubicles, cubicle, personInTeam);
            dat = new FillingData(dic);
            flour = Enumerable.Repeat(count, 3).ToArray();
        }
        [Test]
        public void TestMethod1()
        {
            Assert.Catch<Exception>(() => dat.AddCubicleToDictionary(data, cubicles, cubicle, personInTeam));
        }

        [Test]
        public void TestMethod2()
        {
            
            Assert.Catch<Exception>(() => sp.Method(flour, k, rest));

        }
        [Test]
        public void TestMethod3()
        {
            Assert.Catch<Exception>(() => dat.AddDataManually(cubicles, cubicle, personInTeam));

        }
    }
}
