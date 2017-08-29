using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.SchoolData.Interfaces
{
    public interface IStudent
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Address { get; set; }
        string City { get; set; }
        int ProvinceId { get; set; }
        string PostalCode { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        int DepartmentId { get; set; }
    }
}
