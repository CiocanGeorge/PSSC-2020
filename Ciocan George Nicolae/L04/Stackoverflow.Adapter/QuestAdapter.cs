using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Primitives.IO;
using Stackoverflow.Domain.Schema;
using static Stackoverflow.Domain.Schema.QuestRESULT;

namespace Stackoverflow.Adapter
{
    public class QuestAdapter : Adapter<QuestCMD, QuestRESULT>
    {
        public override Task PostConditions(QuestCMD cmd, QuestRESULT result, object state)
        {
            throw new NotImplementedException();
        }
        public override async Task<QuestRESULT> Work(QuestCMD cmd,object state)
        {
            throw new NotFiniteNumberException();
        }
    }
}
