using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        private Users currentUser;

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public FrmBanks(Users user)
        {
            InitializeComponent();
            currentUser = user;
        }


        private void FrmBanks_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Hoş geldin, {currentUser.UserName}";

            //Banka Bakiyeleri
            var ziraatBankBalance = db.Banks.Where(x=>x.BankTitle=="Ziraat Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var vakifBankBalance = db.Banks.Where(x=>x.BankTitle=="VakıfBank").Select(y=>y.BankBalance).FirstOrDefault();
            var isBankBalance = db.Banks.Where(x=>x.BankTitle=="İş Bankası").Select(y=>y.BankBalance).FirstOrDefault();
            var ingBankBalance = db.Banks.Where(x=>x.BankTitle== "ING Bank").Select(y=>y.BankBalance).FirstOrDefault();
            var halkBankBalance = db.Banks.Where(x=>x.BankTitle== "HalkBankası").Select(y=>y.BankBalance).FirstOrDefault();
            var kuveytTurkBalance = db.Banks.Where(x=>x.BankTitle== "KuveytTürk").Select(y=>y.BankBalance).FirstOrDefault();
            var sekerBankBalance = db.Banks.Where(x=>x.BankTitle== "ŞekerBank").Select(y=>y.BankBalance).FirstOrDefault();
            var denizBankBalance = db.Banks.Where(x=>x.BankTitle== "DenizBank").Select(y=>y.BankBalance).FirstOrDefault();
            var akBankBalance = db.Banks.Where(x=>x.BankTitle== "AkBank").Select(y=>y.BankBalance).FirstOrDefault();


            lblZiraatBankBalance.Text = ziraatBankBalance?.ToString("N2") + " ₺";
            lblVakifbankBalance.Text = vakifBankBalance?.ToString("N2") + " ₺";
            lblIsBankBalance.Text = isBankBalance?.ToString("N2") + " ₺";
            lblIngBankBalance.Text = ingBankBalance?.ToString("N2") + " ₺";
            lblHalkBankBalance.Text = halkBankBalance?.ToString("N2") + " ₺";
            lblKuvetturkBalance.Text = kuveytTurkBalance?.ToString("N2") + " ₺";
            lblSekerBankBalance.Text = sekerBankBalance?.ToString("N2") + " ₺";
            lblDenizBankBalance.Text = denizBankBalance?.ToString("N2") + " ₺";
            lblAkBankBalance.Text = akBankBalance?.ToString("N2") + " ₺";
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling(currentUser);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnExpensesForm_Click(Object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses(currentUser);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnBankTransactionsForm_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frm = new FrmBankTransactions(currentUser);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard(currentUser);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm = new FrmSettings(currentUser);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
