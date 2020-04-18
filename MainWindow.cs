using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialDatabaseManagementApplication
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void CompanySearchBox_ButtonClick(object sender, EventArgs e)
        {
            DataAccessCompany db = new DataAccessCompany();
            CompanyName.Text = db.GetCompanyName(CompanySearchBox.Text).Company;
            IndustryTextLabel.Text = db.GetIndustryName(db.GetCompanyName(CompanySearchBox.Text).Ind_CODE).Industry + " " + db.GetCompanyName(CompanySearchBox.Text).Ind_CODE;
            SuperSectorTextLabel.Text = db.GetSuperSectorName(db.GetCompanyName(CompanySearchBox.Text).SuperSector_CODE).SuperSector + " " + db.GetCompanyName(CompanySearchBox.Text).SuperSector_CODE;
            SectorTextLabel.Text = db.GetSectorName(db.GetCompanyName(CompanySearchBox.Text).Sector_CODE).Sector + " " + db.GetCompanyName(CompanySearchBox.Text).Sector_CODE;
            SubSectorTextLabel.Text = db.GetSubSectorName(db.GetCompanyName(CompanySearchBox.Text).SubSector_CODE).SubSector + " " + db.GetCompanyName(CompanySearchBox.Text).SubSector_CODE;
            ExchangeMembershipTextLabel.Text = db.GetExchangeName(db.GetCompanyName(CompanySearchBox.Text).Exchange_ticker).Name + " " + db.GetCompanyName(CompanySearchBox.Text).Exchange_ticker;
        }
    }
}
