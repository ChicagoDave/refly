using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace refly.core.World
{
    public class Story
    {
        public static string Title
        {
            get
            {
                return Repository.StoryData.Title;
            }
            set
            {
                Repository.StoryData.Title = value;
            }
        }

        public static string Headline
        {
            get
            {
                return Repository.StoryData.Headline;
            }
            set
            {
                Repository.StoryData.Headline = value;
            }
        }

        public static string Author
        {
            get
            {
                return Repository.StoryData.Author;
            }
            set
            {
                Repository.StoryData.Author = value;
            }
        }

        public static DateTimeOffset? CreateDate
        {
            get
            {
                return Repository.StoryData.CreateDate;
            }
            set
            {
                Repository.StoryData.CreateDate = value;
            }
        }

        public static string Version
        {
            get
            {
                return Repository.StoryData.Version;
            }
            set
            {
                Repository.StoryData.Version = value;
            }
        }

        public static int MaximumScore
        {
            get
            {
                return Repository.StoryData.MaximumScore;
            }
            set
            {
                Repository.StoryData.MaximumScore = value;
            }
        }

        public StoryModel StoryData
        {
            get
            {
                return Repository.StoryData;
            }
            set
            {
                Repository.StoryData = value;
            }
        }


        public static Story Create
        {
            get
            {
                Repository.StoryData = new StoryModel();

                return new Story(); // this is a throwaway instance
            }
        }
    }

    public static class StoryExtensions
    {
        public static Story Title(this Story story, string title)
        {
            story.StoryData.Title = title;
            return story;
        }

        public static Story Headline(this Story story, string headline)
        {
            story.StoryData.Headline = headline;
            return story;
        }

        public static Story Author(this Story story, string author)
        {
            story.StoryData.Author = author;
            return story;
        }

        public static Story CreateDate(this Story story, string createDate)
        {
            story.StoryData.CreateDate = DateTimeOffset.Parse(createDate);
            return story;
        }

        public static Story Version(this Story story, string version)
        {
            story.StoryData.Version = version;
            return story;
        }

        public static Story MaximumScore(this Story story, int maximumScore)
        {
            story.StoryData.MaximumScore = maximumScore;
            return story;
        }
    }

}
