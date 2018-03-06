using System;
using System.Collections.Generic;
using System.Text;

using refly.graph;
using refly.models;
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
            return graph.Match<StoryModel>("story", null, null).FirstOrDefault<StoryModel>();
        }

        public void Save(StoryModel story)
        {
            graph.Save<StoryModel>("story", story, null);
        }
    }
}
