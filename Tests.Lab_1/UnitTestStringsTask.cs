using Lab_1;
using Lab_1.menu_tasks;
using Lab_1.regex_strings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Lab_1
{
    [TestFixture]
    public class UnitTestStringsTask
    {

        [SetUp]
        public void Setup() { }

        [Test]
        public void TestNormalizeString()
        {
            string result = StringsTask.NormalizeString("    stepan@mail.ru    ");

            Assert.That(result, Is.EqualTo("stepan@mail.ru"));
        }

        [Test]
        public void TestIsRegexValid()
        {
            Assert.DoesNotThrow(() => StringsTask.IsRegexValid("stepan@mail.ru", new EmailRegexString()));
        }

        [Test]
        public void TestIsRegexValidException()
        {
            Assert.Catch<ValidationException>(() => StringsTask.IsRegexValid("stepan@mail.ru", new PhoneNumberRegexString()));
        }

        [Test]
        public void TestIsReverse()
        {
            Assert.DoesNotThrow(() => StringsTask.IsReverse("stepan@mail.ru", "ur.liam@napets"));
        }

        [Test]
        public void TestIsReverseException()
        {
            Assert.Catch<ValidationException>(() => StringsTask.IsReverse("stepan@mail.ru", "stepan@mail.ru"));
        }

        [Test]
        public void TestIsEqual()
        {
            Assert.DoesNotThrow(() => StringsTask.IsEqual("stepan@mail.ru", "stepan@mail.ru"));
        }

        [Test]
        public void TestIsEqualException()
        {
            Assert.Catch<ValidationException>(() => StringsTask.IsEqual("stepan@mail.ru", "step@mail.ru"));
        }

        [Test]
        public void TestReverse()
        {
            Assert.That(StringsTask.Reverse("stepan@mail.ru"), Is.EqualTo("ur.liam@napets"));

            Assert.That(StringsTask.Reverse("ur.liam@napets"), Is.EqualTo("stepan@mail.ru"));
        }
    }
}
