using Kapta.Model;
using NUnit.Framework;

namespace Kapta.Tests.Model
{
    [TestFixture]
    public class ObjectiveLightModelTests
    {
        private ObjectiveLightModel m_SUT;

        [SetUp]
        public void Setup()
        {
            m_SUT = new ObjectiveLightModel();
        }

        [Test]
        public void Constructor_Valid()
        {
            Assert.That(new ObjectiveLightModel(), Is.Not.Null);
        }

        [Test]
        public void Constructor_Values_Valid()
        {
            var id = "test id";
            var name = "test name";

            var sut = new ObjectiveLightModel(id, name);

            Assert.That(sut.ID, Is.EqualTo(id), "id");
            Assert.That(sut.Name, Is.EqualTo(name), "name");
        }
    }
}
