using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialDatabaseManagementApplication.FinancialClassLibrary
{
    public class STOCK_INFO_Model
    {
        public string Company_Ticker { get; set; }
        public DateTime Day { get; set; }
        public decimal Closed_Adjusted_Price { get; set; }
    }
}
