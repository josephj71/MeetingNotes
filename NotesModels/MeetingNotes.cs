using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesModels
{
    public class MeetingNotes
    {
        public int ID { get; set; }
        public int MeetingID { get; set; }
        public int UserId { get; set; }
        public string Note { get; set; }
    }
}
