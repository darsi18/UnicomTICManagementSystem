using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Models
{
    public class Timetable
    {
        public int TimetableID {  get; set; }
        public int SubjectID { get;set; }
        public string Day { get; set; }
        public string Time { get; set; }
    }
}
