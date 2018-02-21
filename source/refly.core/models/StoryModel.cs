using System;
using System.Collections.Generic;
using System.Text;

namespace refly.core.models
{
    public class StoryModel
    {
        public string Title { get; set; }
        public string Headline { get; set; }
        public string Author { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public string Version { get; set; }
        public int MaximumScore { get; set; }
    }
}
