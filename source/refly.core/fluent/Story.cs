using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using refly.core.models;
using refly.core.repository;

namespace refly.core.fluent
{
    public class Story
    {
        public static string Title
        {
            get
            {
                return StoryRepository.StoryData.Title;
            }
            set
            {
                StoryRepository.StoryData.Title = value;
            }
        }

        public static string Headline
        {
            get
            {
                return StoryRepository.StoryData.Headline;
            }
            set
            {
                StoryRepository.StoryData.Headline = value;
            }
        }

        public static string Author
        {
            get
            {
                return StoryRepository.StoryData.Author;
            }
            set
            {
                StoryRepository.StoryData.Author = value;
            }
        }

        public static DateTimeOffset? CreateDate
        {
            get
            {
                return StoryRepository.StoryData.CreateDate;
            }
            set
            {
                StoryRepository.StoryData.CreateDate = value;
            }
        }

        public static string Version
        {
            get
            {
                return StoryRepository.StoryData.Version;
            }
            set
            {
                StoryRepository.StoryData.Version = value;
            }
        }

        public static int MaximumScore
        {
            get
            {
                return StoryRepository.StoryData.MaximumScore;
            }
            set
            {
                StoryRepository.StoryData.MaximumScore = value;
            }
        }

        public StoryModel StoryData
        {
            get
            {
                return StoryRepository.StoryData;
            }
            set
            {
                StoryRepository.StoryData = value;
            }
        }

        public static Story Create
        {
            get
            {
                StoryRepository.StoryData = new StoryModel();

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
