using System;
using System.Collections.Generic;
using System.Text;

namespace Stackoverflow.Domain.Schema
{
    public class TagQuest
    {
        public string Tag { get; }
        private TagQuest(string tag)
        {
            Tag = tag;
        }
    }
}
