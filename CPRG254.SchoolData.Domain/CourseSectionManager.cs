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
    public class CourseSectionManager : IRepository<ICourseSection>
    {
        private string connectionString = "SchoolDataConnection";

        #region Singleton
        private static CourseSectionManager _course;

        private CourseSectionManager() { }

        public static CourseSectionManager CourseSectionInstance
        {
            get
            {
                if(_course == null)
                {
                    _course = new CourseSectionManager();
                }
                return _course;
            }
        }
        #endregion

        #region Get CourseSection Collection Data
        public IList<ICourseSection> Items
        {
            get
            {
                IList<ICourseSection> sections = new List<ICourseSection>();
                DataGateWay access = new DataGateWay(connectionString);
                string sql = @"use SchoolData
                               SELECT * FROM CourseSection";
                ICourseSection section = null;
                try
                {
                    using (var reader = access.ExecuteQuery(sql, null, CommandType.Text))
                    {
                        while (reader.Read())
                        {
                            section = new CourseSection()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                CourseId = reader.GetInt32(reader.GetOrdinal("CourseId")),
                                SectionCode = reader.GetString(reader.GetOrdinal("SectionCode")),
                                StartDate = reader.GetDateTime(reader.GetOrdinal("StartDate")),
                                EndDate = reader.GetDateTime(reader.GetOrdinal("EndDate")),
                                RoomNumber = CheckNull.GetString(reader,"RoomNumber")
                            };
                            sections.Add(section);
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Error retrieving data from database", ex);
                }
                return sections;
            }
        }
        #endregion

        #region Add Course Section
        public int Add(ICourseSection item)
        {
            DataGateWay access = new DataGateWay(connectionString);
            string sql = @"use SchoolData
                           INSERT INTO CourseSection(CourseId,SectionCode,StartDate,EndDate,RoomNumber)
                           VALUES(@CourseId,@SectionCode,@StartDate,@EndDate,@RoomNumber)";
                           
            IDataParameter CourseIdPar = access.CreateParameter;
            CourseIdPar.ParameterName = "@CourseId";
            CourseIdPar.Value = item.CourseId;
            CourseIdPar.DbType = DbType.Int32;

            IDataParameter SectionCodePar = access.CreateParameter;
            SectionCodePar.ParameterName = "@SectionCode";
            SectionCodePar.Value = item.SectionCode;
            SectionCodePar.DbType = DbType.String;

            IDataParameter StartDatePar = access.CreateParameter;
            StartDatePar.ParameterName = "@StartDate";
            StartDatePar.Value = item.StartDate;
            StartDatePar.DbType = DbType.DateTime;

            IDataParameter EndDatePar = access.CreateParameter;
            EndDatePar.ParameterName = "@EndDate";
            EndDatePar.Value = item.EndDate;
            EndDatePar.DbType = DbType.DateTime;

            IDataParameter RoomNumberPar = access.CreateParameter;
            RoomNumberPar.ParameterName = "@RoomNumber";
            RoomNumberPar.Value = item.RoomNumber;
            RoomNumberPar.DbType = DbType.String;

            IDataParameter[] pars = new IDataParameter[] { CourseIdPar, SectionCodePar, StartDatePar, EndDatePar, RoomNumberPar };

            var rowAffected = access.ExecuteTransaction(sql, pars, CommandType.Text);
            return rowAffected;
        }
        #endregion

        #region Update Course Section
        public int Update(ICourseSection item)
        {
            DataGateWay access = new DataGateWay(connectionString);
            string sql = @"use SchoolData
                           UPDATE CourseSection
                           SET CourseId = @CourseId,
                               SectionCode = @SectionCode,
                               StartDate = @StartDate,
                               EndDate = @EndDate,
                               RoomNumber = @RoomNumber
                           WHERE Id = @Id";

            IDataParameter IdPar = access.CreateParameter;
            IdPar.ParameterName = "@Id";
            IdPar.Value = item.Id;
            IdPar.DbType = DbType.Int32;

            IDataParameter CourseIdPar = access.CreateParameter;
            CourseIdPar.ParameterName = "@CourseId";
            CourseIdPar.Value = item.CourseId;
            CourseIdPar.DbType = DbType.Int32;

            IDataParameter SectionCodePar = access.CreateParameter;
            SectionCodePar.ParameterName = "SectionCode";
            SectionCodePar.Value = item.SectionCode;
            SectionCodePar.DbType = DbType.String;

            IDataParameter StartDatePar = access.CreateParameter;
            StartDatePar.ParameterName = "@StartDate";
            StartDatePar.Value = item.StartDate;
            StartDatePar.DbType = DbType.DateTime;

            IDataParameter EndDatePar = access.CreateParameter;
            EndDatePar.ParameterName = "@EndDate";
            EndDatePar.Value = item.EndDate;
            EndDatePar.DbType = DbType.DateTime;

            IDataParameter RoomNumberPar = access.CreateParameter;
            RoomNumberPar.ParameterName = "@RoomNumber";
            RoomNumberPar.Value = item.RoomNumber;
            RoomNumberPar.DbType = DbType.String;

            IDataParameter[] pars = new IDataParameter[] { IdPar, CourseIdPar, SectionCodePar, StartDatePar, EndDatePar, RoomNumberPar };

            var rowAffected = access.ExecuteTransaction(sql, pars, CommandType.Text);
            return rowAffected;
        }
        #endregion

        #region Unused method
        [Obsolete("Unused Method, no implementation", false)]
        public int Delete(ICourseSection item) { throw new NotImplementedException(); }
        #endregion
    }
}
