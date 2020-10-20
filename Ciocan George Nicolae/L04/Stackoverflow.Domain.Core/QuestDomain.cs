using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using static PortExt;
using Primitives.IO;
using Stackoverflow.Domain.Schema;
using static Stackoverflow.Domain.Schema.QuestRESULT;

namespace Stackoverflow.Domain.Core
{
    public static class QuestDomain
    {
        public static Port<ICreateQuest> CreateQuest(string titlu, string intrebare,string tag) => NewPort<QuestCMD, ICreateQuest>(new QuestCMD(titlu, intrebare, tag));
    }
}
