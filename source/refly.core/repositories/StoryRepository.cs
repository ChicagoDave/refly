using System;
using System.Collections.Generic;
using System.Text;

using refly.graph;
using refly.core.models;
using System.Linq;

namespace refly.core.repositories
{
    public class StoryRepository : IStoryRepository
    {
        private IGraph graph = null;

        public StoryRepository(IGraph graph)
        {
            this.graph = graph;
        }

        public StoryModel Get()
        {
            return graph.Match<StoryModel>("Story").FirstOrDefault<StoryModel>();
        }

        public void Save(StoryModel story)
        {
            graph.Save<StoryModel>("Story", story);
        }
    }
}
