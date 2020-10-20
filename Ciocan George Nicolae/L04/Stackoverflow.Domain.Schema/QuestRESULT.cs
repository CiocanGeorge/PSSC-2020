using System;
using System.Collections.Generic;
using System.Text;

namespace Stackoverflow.Domain.Schema
{
    public class QuestRESULT
    {
        public interface ICreateQuest { }

        public class QuestAdd : ICreateQuest { }
        public class QuestNotAdd : ICreateQuest { }
    }
}
