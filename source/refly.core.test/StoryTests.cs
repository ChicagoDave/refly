using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using refly.core.World;

namespace refly.core.test
{
    [TestClass]
    public class StoryTests
    {
        [TestMethod]
        public void StoryCreationTest()
        {
            Story.Create
                .Title("Cloak of Darkness")
                .Headline("An example IF story")
                .Author("David Cornelson")
                .Version("1.0.0")
                .CreateDate("20-Feb-2018")
                .MaximumScore(100);

            Assert.AreEqual(Story.Title, "Cloak of Darkness");
            Assert.AreEqual(Story.Headline, "An example IF story");
            Assert.AreEqual(Story.Author, "David Cornelson");
            Assert.AreEqual(Story.Version, "1.0.0");
            Assert.AreEqual(Story.CreateDate, DateTimeOffset.Parse("20-Feb-2018"));
            Assert.AreEqual(Story.MaximumScore, 100);
        }
    }
}
