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
            story.Title(title);
            return story;
        }

        public static Story Headline(this Story story, string headline)
        {
            story.Headline(headline);
            return story;
        }
    }

    public class StoryTest
    {
        public StoryTest()
        {
            Story.Create
                .Title("Title")
                .Headline("Headline");

            Console.WriteLine(Story.Title);
        }
    }

}
