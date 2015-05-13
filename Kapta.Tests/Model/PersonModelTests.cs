using Kapta.Model;
using NUnit.Framework;

namespace Kapta.Tests.Model
{
    [TestFixture]
    public class PersonModelTests
    {
        [Test]
        public void Constructor_Valid()
        {
            Assert.That(new PersonModel(), Is.Not.Null);
        }

        [Test]
        public void Constructor_Values_Valid()
        {
            var id = "test id";
            var employeeID = "test employee id";
            var firstName = "test first";
            var lastName = "test last";
            var email = "test@example.com";
            var jobTitle = "test title";
            var location = "test location";
            var isNew = true;
            var team = new TeamModel("team id", "team name");
            var manager = new PersonLightModel("manager id", "manager first", "manager last");

            var sut = new PersonModel(id, employeeID, firstName, lastName, email, jobTitle, location, isNew, team, manager);

            Assert.That(sut.ID, Is.EqualTo(id), "id");
            Assert.That(sut.EmployeeID, Is.EqualTo(employeeID), "employee id");
            Assert.That(sut.FirstName, Is.EqualTo(firstName), "first name");
            Assert.That(sut.LastName, Is.EqualTo(lastName), "last name");
            Assert.That(sut.Email, Is.EqualTo(email), "email");
            Assert.That(sut.JobTitle, Is.EqualTo(jobTitle), "job title");
            Assert.That(sut.Location, Is.EqualTo(location), "location");
            Assert.That(sut.IsNew, Is.EqualTo(isNew), "is new");
            Assert.That(sut.Team, Is.EqualTo(team), "team");
            Assert.That(sut.Manager, Is.EqualTo(manager), "manager");
        }
    }
}
