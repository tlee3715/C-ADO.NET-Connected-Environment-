using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.SchoolData.Interfaces
{
    public interface IDepartment
    {
        int Id { get; set; }
        string Code { get; set; }
        string Name { get; set; }
    }
}
