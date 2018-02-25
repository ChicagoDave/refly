using System;
using System.Collections.Generic;
using System.Text;

using refly.core.models;
using refly.core.repositories;

namespace refly.core.services
{
    public class StoryService : IStoryService
    {
        private IStoryRepository storyRepository = null;

        public StoryService(IStoryRepository storyRepository)
        {
            this.storyRepository = storyRepository;
        }

        public StoryModel StoryData
        {
            get
            {
                return storyRepository.Get();
            }
            set
            {
                storyRepository.Save(value);
            }
        }
    }
}
