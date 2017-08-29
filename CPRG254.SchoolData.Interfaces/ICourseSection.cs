using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.SchoolData.Interfaces
{
    public interface ICourseSection
    {
        int Id { get; set; }
        int CourseId { get; set; }
        string SectionCode { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        string RoomNumber { get; set; }
    }
}
