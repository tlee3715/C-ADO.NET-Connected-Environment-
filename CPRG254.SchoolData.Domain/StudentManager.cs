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
    public class StudentManager : IRepository<IStudent>
    {
        private string connectionName = "SchoolDataConnection";

        #region Singleton
        private static StudentManager _student;

        private StudentManager() { }

        public static StudentManager StudentInstance
        {
            get
            {
                if(_student == null)
                {
                    _student = new StudentManager();
                }
                return _student;
            }
        }
        #endregion

        #region Student Collection Data
        public IList<IStudent> Items
        {
            get
            {
                DataGateWay access = new DataGateWay(connectionName);
                IList<IStudent> students = new List<IStudent>();
                string sql = @"use SchoolData
                               SELECT * FROM Student";
                IStudent std = null;
                try
                {
                    using (var reader = access.ExecuteQuery(sql, null, CommandType.Text))
                    {
                        while(reader.Read())
                        {
                            std = new Student()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                Address = reader.GetString(reader.GetOrdinal("Address")),
                                City = reader.GetString(reader.GetOrdinal("City")),
                                ProvinceId = reader.GetInt32(reader.GetOrdinal("ProvinceId")),
                                PostalCode = reader.GetString(reader.GetOrdinal("PostalCode")),
                                Phone = CheckNull.GetString(reader,"Phone"),
                                Email = CheckNull.GetString(reader,"Email"),
                                DepartmentId = reader.GetInt32(reader.GetOrdinal("DepartmentId"))
                            };
                            students.Add(std);
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Error retrieving data from database !", ex);
                }
                return students;
            }
        }
        #endregion

        #region Add New Student
        public int Add(IStudent item)
        {
            DataGateWay access = new DataGateWay(connectionName);
            string sql = @"use SchoolData
                           INSERT INTO Student(FirstName,LastName,Address,City,ProvinceId,PostalCode,Phone,Email,DepartmentId)
                           VALUES(@FirstName,@LastName,@Address,@City,@ProvinceId,@PostalCode,@Phone,@Email,@DepartmentId)";
            
            IDataParameter firstnamePar = access.CreateParameter;
            firstnamePar.ParameterName = "@FirstName";
            firstnamePar.DbType = DbType.String;
            firstnamePar.Value = item.FirstName;

            IDataParameter lastnamePar = access.CreateParameter;
            lastnamePar.ParameterName = "@LastName";
            lastnamePar.DbType = DbType.String;
            lastnamePar.Value = item.LastName;

            IDataParameter AddressPar = access.CreateParameter;
            AddressPar.ParameterName = "@Address";
            AddressPar.DbType = DbType.String;
            AddressPar.Value = item.Address;

            IDataParameter CityPar = access.CreateParameter;
            CityPar.ParameterName = "@City";
            CityPar.DbType = DbType.String;
            CityPar.Value = item.City;

            IDataParameter ProvincePar = access.CreateParameter;
            ProvincePar.ParameterName = "@ProvinceId";
            ProvincePar.DbType = DbType.Int32;
            ProvincePar.Value = item.ProvinceId;

            IDataParameter PostalCodePar = access.CreateParameter;
            PostalCodePar.ParameterName = "@PostalCode";
            PostalCodePar.DbType = DbType.String;
            PostalCodePar.Value = item.PostalCode;

            IDataParameter PhonePar = access.CreateParameter;
            PhonePar.ParameterName = "@Phone";
            PhonePar.DbType = DbType.String;
            PhonePar.Value = item.Phone;

            IDataParameter EmailPar = access.CreateParameter;
            EmailPar.ParameterName = "@Email";
            EmailPar.DbType = DbType.String;
            EmailPar.Value = item.Email;

            IDataParameter DepartmentPar = access.CreateParameter;
            DepartmentPar.ParameterName = "@DepartmentId";
            DepartmentPar.DbType = DbType.Int32;
            DepartmentPar.Value = item.DepartmentId;

            IDataParameter[] pars = 
                new IDataParameter[] { firstnamePar, lastnamePar, AddressPar, CityPar, ProvincePar, PostalCodePar, PhonePar, EmailPar, DepartmentPar };
            var rownAffected = access.ExecuteTransaction(sql, pars, CommandType.Text);
            return rownAffected;
        }
        #endregion

        #region Update existing student data
        public int Update(IStudent item)
        {
            DataGateWay access = new DataGateWay(connectionName);

            string sql = @"use SchoolData
                           UPDATE Student
                           SET FirstName = @FirstName, 
                               LastName = @LastName, 
                               Address = @Address, 
                               City = @City, 
                               ProvinceId = @ProvinceId, 
                               PostalCode = @PostalCode,
                               Phone = @Phone,
                               Email = @Email,
                               DepartmentId = @DepartmentId
                           WHERE Id = @Id";

            IDataParameter IdPar = access.CreateParameter;
            IdPar.ParameterName = "@Id";
            IdPar.DbType = DbType.Int32;
            IdPar.Value = item.Id;

            IDataParameter firstnamePar = access.CreateParameter;
            firstnamePar.ParameterName = "@FirstName";
            firstnamePar.DbType = DbType.String;
            firstnamePar.Value = item.FirstName;

            IDataParameter lastnamePar = access.CreateParameter;
            lastnamePar.ParameterName = "@LastName";
            lastnamePar.DbType = DbType.String;
            lastnamePar.Value = item.LastName;

            IDataParameter AddressPar = access.CreateParameter;
            AddressPar.ParameterName = "@Address";
            AddressPar.DbType = DbType.String;
            AddressPar.Value = item.Address;

            IDataParameter CityPar = access.CreateParameter;
            CityPar.ParameterName = "@City";
            CityPar.DbType = DbType.String;
            CityPar.Value = item.City;

            IDataParameter ProvincePar = access.CreateParameter;
            ProvincePar.ParameterName = "@ProvinceId";
            ProvincePar.DbType = DbType.Int32;
            ProvincePar.Value = item.ProvinceId;

            IDataParameter PostalCodePar = access.CreateParameter;
            PostalCodePar.ParameterName = "@PostalCode";
            PostalCodePar.DbType = DbType.String;
            PostalCodePar.Value = item.PostalCode;

            IDataParameter PhonePar = access.CreateParameter;
            PhonePar.ParameterName = "@Phone";
            PhonePar.DbType = DbType.String;
            PhonePar.Value = item.Phone;

            IDataParameter EmailPar = access.CreateParameter;
            EmailPar.ParameterName = "@Email";
            EmailPar.DbType = DbType.String;
            EmailPar.Value = item.Email;

            IDataParameter DepartmentPar = access.CreateParameter;
            DepartmentPar.ParameterName = "@DepartmentId";
            DepartmentPar.DbType = DbType.Int32;
            DepartmentPar.Value = item.DepartmentId;

            IDataParameter[] pars =
                new IDataParameter[] { IdPar, firstnamePar, lastnamePar, AddressPar, CityPar, ProvincePar, PostalCodePar, PhonePar, EmailPar, DepartmentPar };
            var rownAffected = access.ExecuteTransaction(sql, pars, CommandType.Text);
            return rownAffected;
        }
        #endregion

        #region Unused Delete Student Method
        [Obsolete("Unused Method, no implementation", false)]
        public int Delete(IStudent item) { throw new NotImplementedException(); }
        #endregion
    }
}
