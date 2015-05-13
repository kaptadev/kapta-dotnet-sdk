using NUnit.Framework;

namespace Kapta.Tests
{
    [TestFixture]
    public class KaptaClientTests
    {
        private KaptaClient m_SUT;

        [SetUp]
        public void Setup()
        {
            m_SUT = new KaptaClient();
        }

        [Test]
        public void Constructor_Valid()
        {
            Assert.That(new KaptaClient(), Is.Not.Null);
        }

        [Test]
        public void Persons_ValidInit()
        {
            Assert.That(m_SUT.Persons, Is.Not.Null);
        }

        [Test]
        public void Persons_ValidReuse()
        {
            Assert.That(m_SUT.Persons, Is.EqualTo(m_SUT.Persons));
        }

        [Test]
        public void Objectives_ValidInit()
        {
            Assert.That(m_SUT.Objectives, Is.Not.Null);
        }

        [Test]
        public void Objectives_ValidReuse()
        {
            Assert.That(m_SUT.Objectives, Is.EqualTo(m_SUT.Objectives));
        }

        [Test]
        public void Goals_ValidInit()
        {
            Assert.That(m_SUT.Goals, Is.Not.Null);
        }

        [Test]
        public void Goals_ValidReuse()
        {
            Assert.That(m_SUT.Goals, Is.EqualTo(m_SUT.Goals));
        }

        [Test]
        public void GoalNotes_ValidInit()
        {
            Assert.That(m_SUT.GoalNotes, Is.Not.Null);
        }

        [Test]
        public void GoalNotes_ValidReuse()
        {
            Assert.That(m_SUT.GoalNotes, Is.EqualTo(m_SUT.GoalNotes));
        }

        [Test]
        public void GoalTasks_ValidInit()
        {
            Assert.That(m_SUT.GoalTasks, Is.Not.Null);
        }

        [Test]
        public void GoalTasks_ValidReuse()
        {
            Assert.That(m_SUT.GoalTasks, Is.EqualTo(m_SUT.GoalTasks));
        }
    }
}
