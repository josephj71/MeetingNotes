using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesModels
{
    public class NoteAction
    {
        public int Id { get; set; }
        public int NoteId { get; set; }
        public string Action { get; set; }
        public int AssignerId { get; set; }
        public int AssigneeId { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CompletedDate { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
