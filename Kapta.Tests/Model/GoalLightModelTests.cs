﻿using Kapta.Model;
using NUnit.Framework;

namespace Kapta.Tests.Model
{
    [TestFixture]
    public class GoalLightModelTests
    {
        [Test]
        public void Constructor_Valid()
        {
            Assert.That(new GoalLightModel(), Is.Not.Null);
        }

        [Test]
        public void Constructor_Values_Valid()
        {
            var id = "test id";
            var name = "test name";
            var sut = new GoalLightModel(id, name);

            Assert.That(sut.ID, Is.EqualTo(id), "id");
            Assert.That(sut.Name, Is.EqualTo(name), "name");
        }
    }
}
