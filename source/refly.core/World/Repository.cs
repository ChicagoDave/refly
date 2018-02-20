using System;
using System.Collections.Generic;
using System.Text;

namespace refly.core.World
{
    public class Repository
    {
        private static StoryModel storyData { get; set; } = null;
        private static List<ItemModel> items { get; set; } = null;

        public static StoryModel StoryData
        {
            get
            {
                if (storyData == null)
                {
                    storyData = new StoryModel();
                }

                return storyData;
            }
            set
            {
                storyData = value;
            }
        }
    }

    public class StoryModel
    {
        public string Title { get; set; }
        public string Headline { get; set; }
    }

    public class ItemModel
    {
        public string Name { get; set; }
    }
}
