using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volun.Models
{
    public class LogDetail
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }

        public override string ToString() => $"[{NoteId}] Title";
       
    }
}
