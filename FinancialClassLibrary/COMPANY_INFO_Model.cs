using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialDatabaseManagementApplication.FinancialClassLibrary
{
    public class COMPANY_INFO_Model
    {
        public string Company_Ticker { get; set; }
        public string Company { get; set; }
        public string Exchange_Ticker { get; set; }
        public string Ind_CODE { get; set; }
        public string SuperSector_CODE { get; set; }
        public string Sector_CODE { get; set; }
        public string SubSector_CODE { get; set; }
    }
}
