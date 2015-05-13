using System;
using Kapta.Model;
using NUnit.Framework;

namespace Kapta.Tests.Model
{
    [TestFixture]
    public class NewGoalModelTests
    {
        private NewGoalModel m_SUT;

        [SetUp]
        public void Setup()
        {
            m_SUT = new NewGoalModel();
        }

        [Test]
        public void Constructor_Valid()
        {
            Assert.That(new NewGoalModel(), Is.Not.Null);
        }

        [Test]
        public void Name_Valid()
        {
            var expected = "test name";
            m_SUT.Name = expected;
            Assert.That(m_SUT.Name, Is.EqualTo(expected));
        }

        [Test]
        public void Description_Valid()
        {
            var expected = "test description";
            m_SUT.Description = expected;
            Assert.That(m_SUT.Description, Is.EqualTo(expected));
        }

        [Test]
        public void StartDate_Valid()
        {
            var expected = DateTime.Today;
            m_SUT.StartDate = expected;
            Assert.That(m_SUT.StartDate, Is.EqualTo(expected));
        }

        [Test]
        public void DueDate_Valid()
        {
            var expected = DateTime.Today.AddDays(10);
            m_SUT.DueDate = expected;
            Assert.That(m_SUT.DueDate, Is.EqualTo(expected));
        }

        [Test]
        public void IsPrivate_Valid()
        {
            var expected = true;
            m_SUT.IsPrivate = expected;
            Assert.That(m_SUT.IsPrivate, Is.EqualTo(expected));
        }

        [Test]
        public void ObjectiveID_Valid()
        {
            var expected = "test objective";
            m_SUT.ObjectiveID = expected;
            Assert.That(m_SUT.ObjectiveID, Is.EqualTo(expected));
        }
    }
}
