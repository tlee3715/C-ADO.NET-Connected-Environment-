using CPRG254.Framework.Data;
using CPRG254.SchoolData.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CPRG254.SchoolData.Domain
{
    public class DepartmentManager : IRepository<IDepartment>
    {
        private string connectionName = "SchoolDataConnection";

        #region Singleton
        private static DepartmentManager _department;

        private DepartmentManager() { }

        public static DepartmentManager DepartmentInstance
        {
            get
            {
                if(_department == null)
                {
                    _department = new DepartmentManager();
                }
                return _department;
            }
        }

        #endregion

        #region Department Collection Data
        public IList<IDepartment> Items
        {
            get
            {
                IList<IDepartment> departments = new List<IDepartment>();
                DataGateWay access = new DataGateWay(connectionName);
                string sql = @"use SchoolData
                               SELECT * FROM Department";
                IDepartment dept = null;
                try
                {
                    using (var reader = access.ExecuteQuery(sql, null, CommandType.Text))
                    {
                        while(reader.Read())
                        {
                            dept = new Department()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Code = reader.GetString(reader.GetOrdinal("Code")),
                                Name = reader.GetString(reader.GetOrdinal("Name"))
                            };
                            departments.Add(dept);
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Error retrieving data from database", ex);
                }
                return departments;
            }
        }
        #endregion

        #region Unused Methods
        [Obsolete("Unused Method, no implementation", false)]
        public int Add(IDepartment item) { return 0; }

        [Obsolete("Unused Method, no implementation", false)]
        public int Delete(IDepartment item) { return 0; }

        [Obsolete("Unused Method, no implementation", false)]
        public int Update(IDepartment item) { return 0; }
        #endregion
    }
}
