using Lab_1;
using Lab_1.menu_tasks;

namespace Tests.Lab_1
{
    [TestFixture]
    public class UnitTestCalcTask
    {
        private CalcTask calcTask;

        [SetUp]
        public void Setup()
        {
            calcTask = new CalcTask();
        }

        [Test]
        public void TestExecute()
        {
            calcTask.Init(2, 3, 4);

            calcTask.Execute();

            Assert.That(calcTask.Result, Is.EqualTo(14.12));
        }

        [Test]
        public void TestExecuteValidationException()
        {
            calcTask.Init(0, 3, 4);

            Assert.Catch<ValidationException>(calcTask.Execute);
        }

        [Test]
        public void TestCalcMethod()
        {
            calcTask.Init(1, -4, 2);

            Assert.Catch<ValidationException>(calcTask.Execute);
        }
    }
}