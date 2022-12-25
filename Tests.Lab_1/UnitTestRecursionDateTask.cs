using Lab_1.menu_tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Lab_1
{
    [TestFixture]
    public class UnitTestRecursionDateTask
    {
        [SetUp]
        public void Setup() { }

        [Test]
        public void TestCalcDateSegment()
        {
            int result = RecursionDateTask.CalcDateSegment((DateOnly.Parse("12.12.2022"), DateOnly.Parse("15.12.2022")),
                                                           (DateOnly.Parse("13.12.2022"), DateOnly.Parse("16.12.2022")));

            Assert.That(result, Is.EqualTo(3));
        }


        [Test]
        public void TestLeftCalcDateSegment()
        {
            int result = RecursionDateTask.CalcDateSegment((DateOnly.Parse("12.12.2022"), DateOnly.Parse("15.12.2022")),
                                                           (DateOnly.Parse("09.12.2022"), DateOnly.Parse("13.12.2022")));

            Assert.That(result, Is.EqualTo(2));
        }


        [Test]
        public void TestRightCalcDateSegment()
        {
            int result = RecursionDateTask.CalcDateSegment((DateOnly.Parse("12.12.2022"), DateOnly.Parse("15.12.2022")),
                                                           (DateOnly.Parse("13.12.2022"), DateOnly.Parse("16.12.2022")));

            Assert.That(result, Is.EqualTo(3));
        }


        [Test]
        public void TestZeroDateSegment()
        {
            int result = RecursionDateTask.CalcDateSegment((DateOnly.Parse("13.12.2022"), DateOnly.Parse("15.12.2022")),
                                                           (DateOnly.Parse("13.12.2022"), DateOnly.Parse("20.11.2022")));

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void TestIsPrimeFuncStackOverflow()
        {
            bool result = RecursionDateTask.IsPrime(2);

            Assert.That(result, Is.EqualTo(true));
        }
    }
}
