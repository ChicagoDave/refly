using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

using refly.models;
using refly.graph;

using Autofac;

namespace refly.graph.test
{
    [TestClass]
    public class GraphTests
    {
        IGraph graph = null;

        [TestInitialize]
        public void InitTests()
        {
            graph = new Graph();
        }

        [TestMethod]
        public void MatchLabelTest()
        {
            var story = graph.Match<StoryModel>("story", null, null);

            Assert.AreEqual<int>(0, story.Count);

            DateTimeOffset testDate = DateTimeOffset.Parse("02/27/2018");

            graph.Create<StoryModel>("story", new StoryModel()
            {
                Title = "Cloak of Darkness",
                Headline = "An example IF story",
                Author = "David Cornelson",
                CreateDate = testDate,
                Version = "1.0.0",
                MaximumScore = 2
            }, null);

            var newStory = graph.Match<StoryModel>("story", null, null).FirstOrDefault<StoryModel>();

            Assert.AreEqual(newStory.Title, "Cloak of Darkness");
            Assert.AreEqual(newStory.Headline, "An example IF story");
            Assert.AreEqual(newStory.Author, "David Cornelson");
            Assert.AreEqual(newStory.CreateDate, testDate);
            Assert.AreEqual(newStory.Version, "1.0.0");
            Assert.AreEqual(newStory.MaximumScore, 2);

        }

        [TestMethod]
        public void UpdateTest()
        {
            var story = graph.Match<StoryModel>("update-story", null, null);

            Assert.AreEqual<int>(0, story.Count);

            DateTimeOffset testDate = DateTimeOffset.Parse("02/27/2018");

            graph.Create<StoryModel>("update-story", new StoryModel()
            {
                Title = "Cloak of Darkness",
                Headline = "An example IF story",
                Author = "David Cornelson",
                CreateDate = testDate,
                Version = "1.0.0",
                MaximumScore = 2
            }, null);

            var newStory = graph.Match<StoryModel>("update-story", null, null).FirstOrDefault<StoryModel>();

            newStory.MaximumScore = 5;
            graph.Set<StoryModel>("update-story", newStory, null);

            var updatedStory = graph.Match<StoryModel>("update-story", null, null).FirstOrDefault<StoryModel>();

            Assert.AreEqual(updatedStory.Title, "Cloak of Darkness");
            Assert.AreEqual(updatedStory.Headline, "An example IF story");
            Assert.AreEqual(updatedStory.Author, "David Cornelson");
            Assert.AreEqual(updatedStory.CreateDate, testDate);
            Assert.AreEqual(updatedStory.Version, "1.0.0");
            Assert.AreEqual(updatedStory.MaximumScore, 5);

        }
    }
}
