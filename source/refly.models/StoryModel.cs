using System;
using System.Collections.Generic;
using System.Text;

using refly.graph.core;

namespace refly.models
{
    public class StoryModel : IVertex
    {
        public Guid? Id { get; set; }
        public string Label { get; set; }
        public Dictionary<string, string> Properties { get; set; }
        public string Title { get; set; }
        public string Headline { get; set; }
        public string Author { get; set; }
        public DateTimeOffset? CreateDate { get; set; }
        public string Version { get; set; }
        public int MaximumScore { get; set; }
    }
}
