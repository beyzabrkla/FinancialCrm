using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBankTransactions : Form
    {
        private Users currentUser;

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public FrmBankTransactions(Users user)
        {
            InitializeComponent();
            currentUser = user;
        }
               
        private void FrmBankTransactions_Load(object sender, EventArgs e)
        {
            //Son Havale Hareketleri
            var bankProcess1 = db.BankProcesses.OrderBy(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = (bankProcess1.Amount ?? 0).ToString("N2") + " ₺  / " + (bankProcess1.ProcessDate?.ToShortDateString() ?? " ");
            lblDescription1.Text ="-"+bankProcess1.Description;

            var bankProcess2 = db.BankProcesses.OrderBy(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = (bankProcess2.Amount ?? 0).ToString("N2") + " ₺  / " + (bankProcess2.ProcessDate?.ToShortDateString() ?? " ");
            lblDescription2.Text ="-"+bankProcess2.Description;

            var bankProcess3 = db.BankProcesses.OrderBy(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = (bankProcess3.Amount ?? 0).ToString("N2") + " ₺  / " + (bankProcess3.ProcessDate?.ToShortDateString() ?? " ");
            lblDescription3.Text ="-"+bankProcess3.Description;

            var bankProcess4 = db.BankProcesses.OrderBy(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = (bankProcess4.Amount ?? 0).ToString("N2") + " ₺  / " + (bankProcess4.ProcessDate?.ToShortDateString() ?? " ");
            lblDescription4.Text ="-"+bankProcess4.Description;

            var bankProcess5 = db.BankProcesses.OrderBy(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = (bankProcess5.Amount ?? 0).ToString("N2") + " ₺  / " + (bankProcess5.ProcessDate?.ToShortDateString() ?? " ");
            lblDescription5.Text ="-"+bankProcess5.Description;

            var bankProcess6 = db.BankProcesses.OrderBy(x => x.BankProcessId).Take(6).Skip(5).FirstOrDefault();
            lblBankProcess6.Text = (bankProcess6.Amount ?? 0).ToString("N2") + " ₺  / " + (bankProcess6.ProcessDate?.ToShortDateString() ?? " ");
            lblDescription6.Text ="-"+bankProcess6.Description;

            var bankProcess7 = db.BankProcesses.OrderBy(x => x.BankProcessId).Take(7).Skip(6).FirstOrDefault();
            lblBankProcess7.Text = (bankProcess7.Amount ?? 0).ToString("N2") + " ₺  / " + (bankProcess7.ProcessDate?.ToShortDateString() ?? " ");
            lblDescription7.Text ="-" + bankProcess7.Description;

            var bankProcess8 = db.BankProcesses.OrderBy(x => x.BankProcessId).Take(8).Skip(7).FirstOrDefault();
            lblBankProcess8.Text = (bankProcess8.Amount ?? 0).ToString("N2") + " ₺  / " + (bankProcess8.ProcessDate?.ToShortDateString() ??  " ");
            lblDescription8.Text ="-"+ bankProcess8.Description;

            var bankProcess9 = db.BankProcesses.OrderBy(x => x.BankProcessId).Take(9).Skip(8).FirstOrDefault();
            lblBankProcess9.Text = (bankProcess9.Amount ?? 0).ToString("N2") + " ₺  / " + (bankProcess9.ProcessDate?.ToShortDateString() ?? " ");
            lblDescription9.Text ="-" + bankProcess9.Description;

            var bankProcess10 = db.BankProcesses.OrderBy(x => x.BankProcessId).Take(10).Skip(9).FirstOrDefault();
            lblBankProcess10.Text = (bankProcess10.Amount ?? 0).ToString("N2") + " ₺  / " + (bankProcess10.ProcessDate?.ToShortDateString() ?? " ");
            lblDescription10.Text ="-"+bankProcess10.Description;


            //Son Ödeme Hareketleri
            var bill1 = db.Spendings.OrderBy(x => x.SpendingId).Take(1).FirstOrDefault();
            lblBill1.Text=(bill1.SpendingAmount ?? 0).ToString("N2")+ " ₺ / "+ (bill1.SpendingDate?.ToShortDateString()?? " ");
            lblBillDescription1.Text = "-" + bill1.SpendingTitle;

            var bill2 = db.Spendings.OrderBy(x => x.SpendingId).Take(2).Skip(1).FirstOrDefault();
            lblBill2.Text = (bill2.SpendingAmount ?? 0).ToString("N2") + " ₺ / " + (bill2.SpendingDate?.ToShortDateString() ?? " ");
            lblBillDescription2.Text="-" + bill2.SpendingTitle;

            var bill3 = db.Spendings.OrderBy(x => x.SpendingId).Take(3).Skip(2).FirstOrDefault();
            lblBill3.Text = (bill3.SpendingAmount ?? 0).ToString("N2") + "₺ / " + (bill3.SpendingDate?.ToString() ?? " ");
            lblBillDescription3.Text = "-" + bill3.SpendingTitle;


            var bill4 = db.Spendings.OrderBy(x => x.SpendingId).Take(4).Skip(3).FirstOrDefault();
            lblBill4.Text = (bill4.SpendingAmount ?? 0).ToString("N2") + " ₺ / " + (bill4.SpendingDate?.ToShortDateString() ?? " ");
            lblBillDescription4.Text = "-" + bill4.SpendingTitle;

            var bill5 = db.Spendings.OrderBy(x => x.SpendingId).Take(5).Skip(4).FirstOrDefault();
            lblBill5.Text = (bill5.SpendingAmount ?? 0).ToString("N2") + " ₺ / " + (bill5.SpendingDate?.ToShortDateString() ?? " ");
            lblBillDescription5.Text = "-" + bill5.SpendingTitle;

            var bill6 = db.Spendings.OrderBy(x => x.SpendingId).Take(6).Skip(5).FirstOrDefault();
            lblBill6.Text = (bill6.SpendingAmount ?? 0).ToString("N2") + " ₺ / " + (bill6.SpendingDate?.ToString() ?? " ");
            lblBillDescription6.Text = "-" + bill6.SpendingTitle;

            var bill7 = db.Spendings.OrderBy(x => x.SpendingId).Take(7).Skip(6).FirstOrDefault();
            lblBill7.Text = (bill7.SpendingAmount ?? 0).ToString("N2") + " ₺ / " + (bill7.SpendingDate?.ToShortDateString() ?? " ");
            lblBillDescription7.Text = "-" + bill7.SpendingTitle;

            var bill8 = db.Spendings.OrderBy(x => x.SpendingId).Take(8).Skip(7).FirstOrDefault();
            lblBill8.Text = (bill8.SpendingAmount ?? 0).ToString("N2") + " ₺ / " + (bill8.SpendingDate?.ToShortDateString() ?? " ");
            lblBillDescription8.Text = "-" + bill8.SpendingTitle;

            var bill9 = db.Spendings.OrderBy(x => x.SpendingId).Take(9).Skip(8).FirstOrDefault();
            lblBill9.Text = (bill9.SpendingAmount ?? 0).ToString("N2") + " ₺ / " + (bill9.SpendingDate?.ToString() ?? " ");
            lblBillDescription9.Text = "-" + bill9.SpendingTitle;

            var bill10 = db.Spendings.OrderBy(x => x.SpendingId).Take(10).Skip(9).FirstOrDefault();
            lblBill10.Text = (bill10.SpendingAmount ?? 0).ToString("N2") + " ₺ / " + (bill10.SpendingDate?.ToString() ?? " ");
            lblBillDescription10.Text = "-" + bill10.SpendingTitle;

        }


        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks(currentUser);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling(currentUser);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnExpensesForm_Click(object sender, EventArgs e)
        {
            FrmExpenses frm = new FrmExpenses(currentUser);
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
