using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using refly.graph.core;
using refly.models;
using refly.core.services;

namespace refly.core.fluent
{
    public class Story
    {
        private static IStoryService storyService = null;

        public Story() { }

        public Story(IStoryService storyService)
        {
            Story.storyService = storyService;
        }

        public static string Title
        {
            get
            {
                return storyService.StoryData.Title;
            }
            set
            {
                storyService.StoryData.Title = value;
            }
        }

        public static string Headline
        {
            get
            {
                return storyService.StoryData.Headline;
            }
            set
            {
                storyService.StoryData.Headline = value;
            }
        }

        public static string Author
        {
            get
            {
                return storyService.StoryData.Author;
            }
            set
            {
                storyService.StoryData.Author = value;
            }
        }

        public static DateTimeOffset? CreateDate
        {
            get
            {
                return storyService.StoryData.CreateDate;
            }
            set
            {
                storyService.StoryData.CreateDate = value;
            }
        }

        public static string Version
        {
            get
            {
                return storyService.StoryData.Version;
            }
            set
            {
                storyService.StoryData.Version = value;
            }
        }

        public static int MaximumScore
        {
            get
            {
                return storyService.StoryData.MaximumScore;
            }
            set
            {
                storyService.StoryData.MaximumScore = value;
            }
        }

        public StoryModel StoryData
        {
            get
            {
                return storyService.StoryData;
            }
            set
            {
                storyService.StoryData = value;
            }
        }

        public static Story Create
        {
            get
            {
                storyService.StoryData = new StoryModel();

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
