using FinancialDatabaseManagementApplication.FinancialClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FinancialDatabaseManagementApplication
{
    class DataAccessCompany
    {
        public List<COMPANY_INFO_Model> GetCompany(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnName("FinancialDatabase")))
            {
                var outputCompany = connection.Query<COMPANY_INFO_Model>($"select ")
            }
        }
    }
}
