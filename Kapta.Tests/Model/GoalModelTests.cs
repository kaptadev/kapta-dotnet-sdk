using System;
using Kapta.Model;
using NUnit.Framework;

namespace Kapta.Tests.Model
{
    [TestFixture]
    public class GoalModelTests
    {
        [Test]
        public void Constructor_Valid()
        {
            Assert.That(new GoalModel(), Is.Not.Null);
        }

        [Test]
        public void Constructor_Values_Valid()
        {
            var id = "test id";
            var name = "test name";
            var description = "test description";
            var startDate = DateTime.Today.AddDays(-1);
            var dueDate = DateTime.Today.AddDays(10);
            var endDate = DateTime.Now;
            var state = "Active";
            var status = "On Track";
            var percentageComplete = 57;
            var isPrivate = true;
            var assignedTo = new PersonLightModel("person id", "person first", "person last");
            var objective = new ObjectiveLightModel("obj id", "obj name");

            var sut = new GoalModel(id, name, description, startDate, dueDate, endDate, state, status, percentageComplete, isPrivate, assignedTo, objective);

            Assert.That(sut.ID, Is.EqualTo(id), "id");
            Assert.That(sut.Name, Is.EqualTo(name), "name");
            Assert.That(sut.Description, Is.EqualTo(description), "description");
            Assert.That(sut.StartDate, Is.EqualTo(startDate), "start date");
            Assert.That(sut.DueDate, Is.EqualTo(dueDate), "due date");
            Assert.That(sut.EndDate, Is.EqualTo(endDate), "end date");
            Assert.That(sut.State, Is.EqualTo(state), "state");
            Assert.That(sut.Status, Is.EqualTo(status), "status");
            Assert.That(sut.PercentageComplete, Is.EqualTo(percentageComplete), "percentage complete");
            Assert.That(sut.IsPrivate, Is.EqualTo(isPrivate), "is private");
            Assert.That(sut.AssignedTo, Is.EqualTo(assignedTo), "assigned to");
            Assert.That(sut.Objective, Is.EqualTo(objective), "objective");
        }
    }
}
