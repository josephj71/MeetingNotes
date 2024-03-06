using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesDataAccess.Models
{
    public class MeetingModel
    {
        public int ID { get; set; }
        public string MeetingName { get; set; }
        public string Description { get; set; }
        public DateTime MeetingDate { get; set; }


    }
}
