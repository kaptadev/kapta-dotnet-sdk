using System;
using Kapta.Model;
using NUnit.Framework;

namespace Kapta.Tests.Model
{
    [TestFixture]
    public class NewGoalTaskModelTests
    {
        private NewGoalTaskModel m_SUT;

        [SetUp]
        public void Setup()
        {
            m_SUT = new NewGoalTaskModel();
        }

        [Test]
        public void Constructor_Valid()
        {
            Assert.That(new NewGoalTaskModel(), Is.Not.Null);
        }

        [Test]
        public void Text_Valid()
        {
            var expected = "test text";
            m_SUT.Text = expected;
            Assert.That(m_SUT.Text, Is.EqualTo(expected));
        }

        [Test]
        public void DueDate_Valid()
        {
            var expected = DateTime.Today.AddDays(3);
            m_SUT.DueDate = expected;
            Assert.That(m_SUT.DueDate, Is.EqualTo(expected));
        }
    }
}
