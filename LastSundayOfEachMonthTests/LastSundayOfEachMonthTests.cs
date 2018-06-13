using LastSundayOfEachMonth;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastSundayOfEachMonthTests
{
    [TestFixture]
    public class LastSundayOfEachMonthTests
    {
        [Test]
        public void GetLastSundayInMonth_GivenTheYear2013_ShouldReturnLastSundayOfMonth1()
        {
            //---------------Arrange-------------------
            LastSunday last = CreateLastSunday();
            var expected = "2013-01-27";
            //---------------Act----------------------
            var actual = last.GetLastSundayInMonth(2013);

            //---------------Assert----------------------
            Assert.AreEqual(actual.First(), expected);
        }

        [Test]
        public void GetLastSundayInMonth_GivenTheYear2013_ShouldReturnLastSundayOfMonth2()
        {
            //---------------Arrange-------------------
            LastSunday last = CreateLastSunday();
            var expected = "2013-02-24";
            //---------------Act----------------------
            var actual = last.GetLastSundayInMonth(2013);

            //---------------Assert----------------------
            Assert.AreEqual(actual.ElementAt(1), expected);
        }

        [Test]
        public void GetLastSundayInMonth_GivenTheYear2013_ShouldReturnLastSundayOfMonth6()
        {
            //---------------Arrange-------------------
            LastSunday last = CreateLastSunday();
            var expected = "2013-06-30";
            //---------------Act----------------------
            var actual = last.GetLastSundayInMonth(2013);

            //---------------Assert----------------------
            Assert.AreEqual(actual.ElementAt(5), expected);
        }
        
        [Test]
        public void GetLastSundayInMonth_GivenTheYear2013_ShouldReturnLastSundayOfMonth11()
        {
            //---------------Arrange-------------------
            LastSunday last = CreateLastSunday();
            var expected = "2013-11-24";
            //---------------Act----------------------
            var actual = last.GetLastSundayInMonth(2013);

            //---------------Assert----------------------
            Assert.AreEqual(actual.ElementAt(10), expected);
        }

        [Test]
        public void GetLastSundayInMonth_GivenTheYear2013_ShouldReturnLastSundayOfMonth12()
        {
            //---------------Arrange-------------------
            LastSunday last = CreateLastSunday();
            var expected = "2013-12-29";
            //---------------Act----------------------
            var actual = last.GetLastSundayInMonth(2013);

            //---------------Assert----------------------
            Assert.AreEqual(actual.Last(), expected);
        }

        [Test]
        public void GetLastSundayInMonth_GivenTheYear2018_ShouldReturnLastSundayOfMonth1()
        {
            //---------------Arrange-------------------
            LastSunday last = CreateLastSunday();
            var expected = "2018-01-28";
            //---------------Act----------------------
            var actual = last.GetLastSundayInMonth(2018);

            //---------------Assert----------------------
            Assert.AreEqual(actual.First(), expected);
        }

        [Test]
        public void GetLastSundayInMonth_GivenTheYear2018_ShouldReturnLastSundayOfMonth6()
        {
            //---------------Arrange-------------------
            LastSunday last = CreateLastSunday();
            var expected = "2018-06-24";
            //---------------Act----------------------
            var actual = last.GetLastSundayInMonth(2018);

            //---------------Assert----------------------
            Assert.AreEqual(actual.ElementAt(5), expected);
        }

        [Test]
        public void GetLastSundayInMonth_GivenTheYear2020_ShouldReturnLastSundayOfMonth2()
        {
            //---------------Arrange-------------------
            LastSunday last = CreateLastSunday();
            var expected = "2020-02-23";
            //---------------Act----------------------
            var actual = last.GetLastSundayInMonth(2020);

            //---------------Assert----------------------
            Assert.AreEqual(actual.ElementAt(1), expected);
        }

        [Test]
        public void GetLastSundayInMonth_GivenTheYear2032_ShouldReturnLastSundayOfMonth2()
        {
            //---------------Arrange-------------------
            LastSunday last = CreateLastSunday();
            var expected = "2032-02-29";
            //---------------Act----------------------
            var actual = last.GetLastSundayInMonth(2032);

            //---------------Assert----------------------
            Assert.AreEqual(actual.ElementAt(1), expected);
        }
        
        private static LastSunday CreateLastSunday()
        {
            return new LastSunday();
        }
    }
}
