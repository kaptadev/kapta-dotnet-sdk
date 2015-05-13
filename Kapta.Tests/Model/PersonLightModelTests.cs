using Kapta.Model;
using NUnit.Framework;

namespace Kapta.Tests.Model
{
    [TestFixture]
    public class PersonLightModelTests
    {
        [Test]
        public void Constructor_Valid()
        {
            Assert.That(new PersonLightModel(), Is.Not.Null);
        }

        [Test]
        public void Constructor_Values_Valid()
        {
            var id = "test id";
            var firstName = "test first";
            var lastName = "test last";

            var sut = new PersonLightModel(id, firstName, lastName);

            Assert.That(sut.ID, Is.EqualTo(id), "id");
            Assert.That(sut.FirstName, Is.EqualTo(firstName), "first name");
            Assert.That(sut.LastName, Is.EqualTo(lastName), "last name");
        }
    }
}
