using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Stackoverflow.Domain.Schema
{
    public class QuestCMD
    {
        public QuestCMD(string titlu, string intrebare,string tag)
        {
            Titlu = titlu;
            Intrebare = intrebare;
            Tag = tag;
        }
        [Required]
        public string Titlu { get; }
        [Required]
        public string Intrebare { get; }
        [Required]
        public string Tag { get; }
    }
}
