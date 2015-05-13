using Kapta.Model;
using NUnit.Framework;

namespace Kapta.Tests.Model
{
    [TestFixture]
    public class NewGoalNoteModelTests
    {
        private NewGoalNoteModel m_SUT;

        [SetUp]
        public void Setup()
        {
            m_SUT = new NewGoalNoteModel();
        }

        [Test]
        public void Constructor_Valid()
        {
            Assert.That(new NewGoalNoteModel(), Is.Not.Null);
        }

        [Test]
        public void Text_Valid()
        {
            var expected = "test text";
            m_SUT.Text = expected;
            Assert.That(m_SUT.Text, Is.EqualTo(expected));
        }
    }
}
