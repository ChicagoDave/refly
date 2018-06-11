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
            return graph.Match<StoryModel>("Story", null, null).FirstOrDefault<StoryModel>();
        }

        public void Save(StoryModel story)
        {
            if (story.Id == null)
            {
                graph.Create<StoryModel>("Story", story, null);
                return;
            }

            StoryModel current = Get();

            graph.Set<StoryModel>("Story", story, null);
        }
    }
}
