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
    class DataAccess
    {
        public COMPANY_INFO_Model GetCompanyName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnName("FinancialDatabase")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string sql = @"select [Company],[Exchange_ticker],[Ind_CODE],[SuperSector_CODE],[Sector_CODE],[SubSector_CODE] from [COMPANY_INFO] where [Company_Ticker] = @CTICKER";
                var outputCompany = connection.Query<COMPANY_INFO_Model>(sql, new { @CTICKER = name }).SingleOrDefault();
                return outputCompany;
            }
        }
        public Industry_Model GetIndustryName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnName("FinancialDatabase")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string sql = @"select [Industry] from [Industry] where [Ind_CODE] = @ICBtype";
                var outputICB = connection.Query<Industry_Model>(sql, new { @ICBtype = name }).SingleOrDefault();
                return outputICB;
            }
        }
        public SuperSector_Model GetSuperSectorName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnName("FinancialDatabase")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string sql = @"select [SuperSector] from [SuperSector] where [SuperSector_CODE] = @ICBtype";
                var outputICB = connection.Query<SuperSector_Model>(sql, new { @ICBtype = name }).SingleOrDefault();
                return outputICB;
            }
        }
        public Sector_Model GetSectorName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnName("FinancialDatabase")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string sql = @"select [Sector] from [Sector] where [Sector_CODE] = @ICBtype";
                var outputICB = connection.Query<Sector_Model>(sql, new { @ICBtype = name }).SingleOrDefault();
                return outputICB;
            }
        }
        public SubSector_Model GetSubSectorName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnName("FinancialDatabase")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string sql = @"select [SubSector] from [SubSector] where [SubSector_CODE] = @ICBtype";
                var outputICB = connection.Query<SubSector_Model>(sql, new { @ICBtype = name }).SingleOrDefault();
                return outputICB;
            }
        }
        public EXCHANGE_INFO_Model GetExchangeName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnName("FinancialDatabase")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string sql = @"select [Name],[Exchange_Ticker] from [EXCHANGE_INFO] where [Exchange_Ticker] = @EXCHANGE";
                var output = connection.Query<EXCHANGE_INFO_Model>(sql, new { @EXCHANGE = name }).SingleOrDefault();
                return output;
            }
        }
        public List<COMPANY_INFO_Model> GetCompany (string name, string icb)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnName("FinancialDatabase")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
                string sql;
                switch (icb)
                {
                    case "Industry": sql = @"select [Company],[Exchange_ticker],[Company_Ticker] from [COMPANY_INFO] where [Ind_CODE] = @ICB"; break;
                    case "SuperSector": sql = @"select [Company],[Exchange_ticker],[Company_Ticker] from [COMPANY_INFO] where [SuperSector_CODE] = @ICB"; break;
                    case "Sector": sql = @"select [Company],[Exchange_ticker],[Company_Ticker] from [COMPANY_INFO] where [Sector_CODE] = @ICB"; break;
                    case "SubSector": sql = @"select [Company],[Exchange_ticker],[Company_Ticker] from [COMPANY_INFO] where [SubSector_CODE] = @ICB"; break;
                    default: throw new ArgumentOutOfRangeException();
                }
                var output = connection.Query<COMPANY_INFO_Model>(sql, new { @ICB = name }).ToList();
                return output;
            }
        }
        public List<ITEM_SETTING_Model> GetStatementItem()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnName("FinancialDatabase")))
            {
                if (connection.State == ConnectionState.Closed) connection.Open();
            }
        }
    }
}
