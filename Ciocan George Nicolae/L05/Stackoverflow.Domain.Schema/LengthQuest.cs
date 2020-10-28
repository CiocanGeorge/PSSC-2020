using System;
using System.Collections.Generic;
using System.Text;
using LanguageExt.Common;

namespace Stackoverflow.Domain.Schema
{
    public class LengthQuest
    {
        public string Text { get; }
        public LengthQuest(string text)
        {
            text = text;
        }
        public static Result<LengthQuest> Create( string text)
        {
            if(text.Length<1000)
            {
                return new LengthQuest(text);
            }
            else
            {
                return new Result<LengthQuest>(new ArgumentException());
            }
        }
    }
}
