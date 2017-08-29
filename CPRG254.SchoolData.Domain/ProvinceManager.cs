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
    public class ProvinceManager : IRepository<IProvince>
    {
        private string connectionName = "SchoolDataConnection";

        #region ProvinceManager Singleton
        private static ProvinceManager _province;

        private ProvinceManager() { }

        public static ProvinceManager ProvinceInstance
        {
            get
            {
                if(_province == null)
                {
                    _province = new ProvinceManager();
                }
                return _province;
            }
        }
        #endregion

        #region Province Collection Data
        public IList<IProvince> Items
        {
            get
            {
                IList<IProvince> provinces = new List<IProvince>();
                DataGateWay access = new DataGateWay(connectionName);
                string sql = @"use SchoolData
                               SELECT * FROM Province";
                IProvince prov = null;
                try
                {
                    using (var reader = access.ExecuteQuery(sql, null, CommandType.Text))
                    {
                        while(reader.Read())
                        {
                            prov = new Province()
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Code = reader.GetString(reader.GetOrdinal("Code")),
                                Name = reader.GetString(reader.GetOrdinal("Name"))
                            };
                            provinces.Add(prov);
                        }
                    }
                }
                catch(Exception ex)
                {
                    throw new Exception("Error retrieving data from database", ex);
                }
                return provinces;
            }
        }
        #endregion
 
        #region Unused Methods
        [Obsolete("Unused Method, no implementation",false)]
        public int Add(IProvince item) { return 0; }

        [Obsolete("Unused Method, no implementation",false)]
        public int Delete(IProvince item) { return 0; }

        [Obsolete("Unused Method, no implementation",false)]
        public int Update(IProvince item) { return 0; }
        #endregion
    }
}
