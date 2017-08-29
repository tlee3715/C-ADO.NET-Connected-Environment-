using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.SchoolData.Interfaces
{
    public interface ICourse
    {
        int Id { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        decimal Fee { get; set; }
        int DepartmentId { get; set; }
    }
}
