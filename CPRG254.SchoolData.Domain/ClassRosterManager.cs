using CPRG254.Framework.Data;
using CPRG254.SchoolData.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.SchoolData.Domain
{
    public class ClassRosterManager : IRepository<IClassRoster>
    {
        private string connectionString = "SchoolDataConnection";

        #region Singleton
        private static ClassRosterManager _roster;

        private ClassRosterManager() { }

        public static ClassRosterManager RosterInstance
        {
            get
            {
                if(_roster == null)
                {
                    _roster = new ClassRosterManager();
                }
                return _roster;
            }
        }
        #endregion

        #region Class Roster Collection Data
        public IList<IClassRoster> Items
        {
            get
            {

                IList<IClassRoster> roster = new List<IClassRoster>();
                DataGateWay access = new DataGateWay(connectionString);
                string sql = @"use SchoolData
                               SELECT * FROM ClassRoster";
                IClassRoster ros = null;

                try
                {

                    using (var reader = access.ExecuteQuery(sql, null, CommandType.Text))
                    {
                        while(reader.Read())
                        {
                            ros = new ClassRoster()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                CourseSectionId = reader.GetInt32(reader.GetOrdinal("CourseSectionId")),
                                StudentId = reader.GetInt32(reader.GetOrdinal("StudentId")),
                                DateRegistered = reader.GetDateTime(reader.GetOrdinal("DateRegistered"))
                            };
                            roster.Add(ros);
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Error retrieving roster data!", ex);
                }
                return roster;
            }
        }
        #endregion

        #region Add Student to CLass Roster
        public int Add(IClassRoster item)
        {
            DataGateWay access = new DataGateWay(connectionString);

            string sql = @"use SchoolData
                           INSERT INTO ClassRoster(CourseSectionId,StudentId,DateRegistered)
                           VALUES(@CourseSectionId,@StudentId,@DateRegistered)";

            IDataParameter Coursepar = access.CreateParameter;
            Coursepar.ParameterName = "@CourseSectionId";
            Coursepar.Value = item.CourseSectionId;
            Coursepar.DbType = DbType.Int32;

            IDataParameter stdpar = access.CreateParameter;
            stdpar.ParameterName = "@StudentId";
            stdpar.Value = item.StudentId;
            stdpar.DbType = DbType.Int32;

            IDataParameter DatePar = access.CreateParameter;
            DatePar.ParameterName = "@DateRegistered";
            DatePar.Value = item.DateRegistered;
            DatePar.DbType = DbType.DateTime;

            IDataParameter[] pars = new IDataParameter[] { Coursepar, stdpar, DatePar };

            var rowAffected = access.ExecuteTransaction(sql, pars, CommandType.Text);
            return rowAffected;
        }
        #endregion

        #region Unused methods
        [Obsolete("Unused Method, no implementation", false)]
        public int Delete(IClassRoster item) { throw new NotImplementedException(); }

        [Obsolete("Unused Method, no implementation", false)]
        public int Update(IClassRoster item) { throw new NotImplementedException(); }
        #endregion 
    }
}
