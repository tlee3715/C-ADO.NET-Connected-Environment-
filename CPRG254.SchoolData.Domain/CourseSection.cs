using CPRG254.SchoolData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.SchoolData.Domain
{
    public class CourseSection : ICourseSection
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string SectionCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RoomNumber { get; set; }

        public string Info => $"Section: {SectionCode} (Start Date: {StartDate.Date.ToLongDateString()})";
    }
}
