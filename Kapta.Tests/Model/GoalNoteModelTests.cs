using System;
using Kapta.Model;
using NUnit.Framework;

namespace Kapta.Tests.Model
{
    [TestFixture]
    public class GoalNoteModelTests
    {
        [Test]
        public void Constructor_Valid()
        {
            Assert.That(new GoalNoteModel(), Is.Not.Null);
        }

        [Test]
        public void Constructor_Values_Valid()
        {
            var id = 123;
            var text = "test text";
            var dateCreated = DateTime.Now;
            var author = new PersonLightModel("person id", "person first", "person last");
            var goal = new GoalLightModel("goal id", "goal name");

            var sut = new GoalNoteModel(id, text, dateCreated, author, goal);

            Assert.That(sut.ID, Is.EqualTo(id), "id");
            Assert.That(sut.Text, Is.EqualTo(text), "text");
            Assert.That(sut.DateCreated, Is.EqualTo(dateCreated), "date created");
            Assert.That(sut.Author, Is.EqualTo(author), "author");
            Assert.That(sut.Goal, Is.EqualTo(goal), "goal");
        }
    }
}
