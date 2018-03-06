using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

using refly.models;
using refly.graph;

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

        //public string Title { get; set; }
        //public string Headline { get; set; }
        //public string Author { get; set; }
        //public DateTimeOffset? CreateDate { get; set; }
        //public string Version { get; set; }
        //public int MaximumScore { get; set; }

        [TestMethod]
        public void MatchLabelTest()
        {
            var story = graph.Match<StoryModel>("story", null, null);

            Assert.IsNull(story);

            graph.Save<StoryModel>("story", new StoryModel()
            {
                Id = Guid.NewGuid(),
                Title = "Cloak of Darkness",
                Headline = "An example IF story",
                Author = "David Cornelson",
                CreateDate = DateTimeOffset.Parse("02/27/2018"),
                Version = "1.0.0",
                MaximumScore = 2
            }, null);

            var newStory = graph.Match<StoryModel>("story", null, null).FirstOrDefault<StoryModel>();

            Assert.AreEqual(newStory.Title, "Cloak of Darkness");

        }
    }
}
