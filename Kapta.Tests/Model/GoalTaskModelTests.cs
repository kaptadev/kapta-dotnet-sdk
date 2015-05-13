using System;
using Kapta.Model;
using NUnit.Framework;

namespace Kapta.Tests.Model
{
    [TestFixture]
    public class GoalTaskModelTests
    {
        [Test]
        public void Constructor_Valid()
        {
            Assert.That(new GoalTaskModel(), Is.Not.Null);
        }

        [Test]
        public void Constructor_Values_Valid()
        {
            var id = "test id";
            var text = "test text";
            var dueDate = DateTime.Now.AddDays(3);
            var isCompleted = true;
            var goal = new GoalLightModel("goal id", "goal name");

            var sut = new GoalTaskModel(id, text, dueDate, isCompleted, goal);

            Assert.That(sut.ID, Is.EqualTo(id), "id");
            Assert.That(sut.Text, Is.EqualTo(text), "text");
            Assert.That(sut.DueDate, Is.EqualTo(dueDate), "due date");
            Assert.That(sut.IsCompleted, Is.EqualTo(isCompleted), "is completed");
            Assert.That(sut.Goal, Is.EqualTo(goal), "goal");
        }
    }
}
