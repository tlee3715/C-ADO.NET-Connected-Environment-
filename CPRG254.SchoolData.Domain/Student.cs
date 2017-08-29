using CPRG254.SchoolData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.SchoolData.Domain
{
    public class Student : IStudent
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int ProvinceId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }

        public string DisplayFullName => $"{FirstName} {LastName} (ID {Id})";
    }
}
