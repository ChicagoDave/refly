using System;
using System.Collections.Generic;
using System.Text;

using refly.core.models;

namespace refly.core.repository
{
    public class StoryRepository : IStoryRepository
    {
        private static StoryModel storyData { get; set; } = null;
        private static Dictionary<string,PlayerModel> playerData { get; set; } = null;

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

        public static Dictionary<string,PlayerModel> PlayerData
        {
            get
            {
                if (playerData == null)
                {
                    playerData = new Dictionary<string, PlayerModel>();
                }

                return playerData;
            }
            set
            {
                playerData = value;
            }
        }

    }


    public class ItemModel
    {
        public string Name { get; set; }
    }
}
