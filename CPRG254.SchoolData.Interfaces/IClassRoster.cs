using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.SchoolData.Interfaces
{
    public interface IClassRoster
    {
        int Id { get; set; }
        int CourseSectionId { get; set; }
        int StudentId { get; set; }
        DateTime DateRegistered { get; set; }
    }
}
