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
    public class CourseManager : IRepository<ICourse>
    {
        private string connectionName = "SchoolDataConnection";

        #region CourseManager Singleton
        private static CourseManager _course;

        private CourseManager() { }

        public static CourseManager CourseInstance
        {
            get
            {
                if(_course == null)
                {
                    _course = new CourseManager();
                }
                return _course;
            }
        }
        #endregion

        #region Course Collection Data
        public IList<ICourse> Items
        {
            get
            {
                DataGateWay access = new DataGateWay(connectionName);
                IList<ICourse> courses = new List<ICourse>();
                string sql = @"use SchoolData
                               SELECT * FROM Course";
                ICourse course = null;
                try
                {
                    using (var reader = access.ExecuteQuery(sql, null, CommandType.Text))
                    {
                        while (reader.Read())
                        {
                            course = new Course()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Code = reader.GetString(reader.GetOrdinal("Code")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                                Fee = reader.GetDecimal(reader.GetOrdinal("Fee")),
                                DepartmentId = reader.GetInt32(reader.GetOrdinal("DepartmentId")),
                            };
                            courses.Add(course);
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Error retrieving data from database !", ex);
                }
                return courses;
            }
        }
        #endregion

        #region Add New Course
        public int Add(ICourse item)
        {
            DataGateWay access = new DataGateWay(connectionName);
            string sql = @"use SchoolData
                           INSERT INTO Course(Code,Name,Description,Fee,DepartmentId)
                           VALUES(@Code,@Name,@Description,@Fee,@DepartmentId)";

            IDataParameter CodePar = access.CreateParameter;
            CodePar.ParameterName = "@Code";
            CodePar.DbType = DbType.String;
            CodePar.Value = item.Code;

            IDataParameter NamePar = access.CreateParameter;
            NamePar.ParameterName = "@Name";
            NamePar.DbType = DbType.String;
            NamePar.Value = item.Name;

            IDataParameter DescriptionPar = access.CreateParameter;
            DescriptionPar.ParameterName = "@Description";
            DescriptionPar.DbType = DbType.String;
            DescriptionPar.Value = item.Description;

            IDataParameter FeePar = access.CreateParameter;
            FeePar.ParameterName = "@Fee";
            FeePar.DbType = DbType.Decimal;
            FeePar.Value = item.Fee;

            IDataParameter DepartmentIdPar = access.CreateParameter;
            DepartmentIdPar.ParameterName = "@DepartmentId";
            DepartmentIdPar.DbType = DbType.Int32;
            DepartmentIdPar.Value = item.DepartmentId;

            IDataParameter[] pars = 
                new IDataParameter[] { CodePar, NamePar, DescriptionPar, FeePar, DepartmentIdPar };

            var rownAffected = access.ExecuteTransaction(sql, pars, CommandType.Text);
            return rownAffected;
        }
        #endregion

        #region Update Existing Course Data
        public int Update(ICourse item)
        {
            DataGateWay access = new DataGateWay(connectionName);
            string sql = @"use SchoolData
                           UPDATE Course
                           SET Code = @Code, 
                               Name = @Name,
                               Description = @Description,
                               Fee = @Fee,
                               DepartmentId = @DepartmentId
                           WHERE Id = @Id";

            IDataParameter IdPar = access.CreateParameter;
            IdPar.ParameterName = "@Id";
            IdPar.DbType = DbType.Int32;
            IdPar.Value = item.Id;

            IDataParameter CodePar = access.CreateParameter;
            CodePar.ParameterName = "@Code";
            CodePar.DbType = DbType.String;
            CodePar.Value = item.Code;

            IDataParameter NamePar = access.CreateParameter;
            NamePar.ParameterName = "@Name";
            NamePar.DbType = DbType.String;
            NamePar.Value = item.Name;

            IDataParameter DescriptionPar = access.CreateParameter;
            DescriptionPar.ParameterName = "@Description";
            DescriptionPar.DbType = DbType.String;
            DescriptionPar.Value = item.Description;

            IDataParameter FeePar = access.CreateParameter;
            FeePar.ParameterName = "@Fee";
            FeePar.DbType = DbType.Decimal;
            FeePar.Value = item.Fee;

            IDataParameter DepartmentIdPar = access.CreateParameter;
            DepartmentIdPar.ParameterName = "@DepartmentId";
            DepartmentIdPar.DbType = DbType.Int32;
            DepartmentIdPar.Value = item.DepartmentId;

            IDataParameter[] pars =
                new IDataParameter[] { IdPar, CodePar, NamePar, DescriptionPar, FeePar, DepartmentIdPar };

            var rownAffected = access.ExecuteTransaction(sql, pars, CommandType.Text);
            return rownAffected;
        }
        #endregion

        #region Unused Delete Course Method
        [Obsolete("Unused Method, no implementation", false)]
        public int Delete(ICourse item) { throw new NotImplementedException(); }
        #endregion
    }
}
