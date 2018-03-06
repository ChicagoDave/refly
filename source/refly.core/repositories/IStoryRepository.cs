using System;
using System.Collections.Generic;
using System.Text;

using refly.models;

namespace refly.core.repositories
{
    public interface IStoryRepository
    {
        void Save(StoryModel story);
        StoryModel Get();
    }
}
