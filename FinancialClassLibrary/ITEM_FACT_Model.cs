using System;
using System.Collections.Generic;
using System.Text;

namespace FinancialDatabaseManagementApplication.FinancialClassLibrary
{
    public class ITEM_FACT_Model
    {
        public string Item_ID { get; set; }
        public string TICKER { get; set; }
        public string YEAR { get; set; }
        public string Value { get; set; }
    }
}
