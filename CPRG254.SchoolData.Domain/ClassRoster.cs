using CPRG254.SchoolData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.SchoolData.Domain
{
    public class ClassRoster : IClassRoster
    {
        public int Id { get; set; }
        public int CourseSectionId { get; set; }
        public int StudentId { get; set; }
        public DateTime DateRegistered { get; set; }
    }
}
