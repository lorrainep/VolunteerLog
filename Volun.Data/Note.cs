using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volun.Data
{
    public class Note
    {
        public int NoteId { get; set; }
        public Guid OwnerId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        //DateTimeOffset carries timezone info with it
        public DateTimeOffset CreateUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
