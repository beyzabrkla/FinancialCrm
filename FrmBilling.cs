using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;


namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        private Users currentUser;

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public FrmBilling(Users user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource=values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnNewBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text.Trim();
            string amountText = txtBillAmount.Text.Trim();
            string period = txtBillPeriod.Text.Trim();

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(amountText) || string.IsNullOrEmpty(period))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sayısal değer kontrolü
            if (!decimal.TryParse(amountText, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Geçerli bir fatura tutarı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kayıt işlemi
            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;

            db.Bills.Add(bills);
            db.SaveChanges();

            MessageBox.Show("Ödeme başarıyla sisteme eklendi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Listeyi güncelle
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

            // Alanları temizle
            txtBillTitle.Clear();
            txtBillAmount.Clear();
            txtBillPeriod.Clear();
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            string idText = txtBillId.Text.Trim();

            // Boşluk kontrolü
            if (string.IsNullOrEmpty(idText))
            {
                MessageBox.Show("Lütfen silinecek fatura ID'sini giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sayısal ID kontrolü
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Geçerli bir fatura ID'si giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kayıt var mı kontrolü
            var removeValue = db.Bills.Find(id);
            if (removeValue == null)
            {
                MessageBox.Show("Belirtilen ID'ye ait fatura bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Silme işlemi
            db.Bills.Remove(removeValue);
            db.SaveChanges();

            MessageBox.Show("Ödeme başarıyla sistemden silindi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Listeyi güncelle
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

            // Alanı temizle
            txtBillId.Clear();
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string idText = txtBillId.Text.Trim();
            string title = txtBillTitle.Text.Trim();
            string amountText = txtBillAmount.Text.Trim();
            string period = txtBillPeriod.Text.Trim();

            // Boş alan kontrolü
            if (string.IsNullOrEmpty(idText) || string.IsNullOrEmpty(title) || string.IsNullOrEmpty(amountText) || string.IsNullOrEmpty(period))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sayısal ID ve tutar kontrolü
            if (!int.TryParse(idText, out int id))
            {
                MessageBox.Show("Geçerli bir fatura ID'si giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(amountText, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Geçerli bir fatura tutarı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kayıt var mı kontrolü
            var bill = db.Bills.Find(id);
            if (bill == null)
            {
                MessageBox.Show("Belirtilen ID'ye ait fatura bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Güncelleme işlemi
            bill.BillTitle = title;
            bill.BillAmount = amount;
            bill.BillPeriod = period;
            db.SaveChanges();

            MessageBox.Show("Ödeme başarıyla güncellendi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Listeyi güncelle
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

            // Alanları temizle
            txtBillId.Clear();
            txtBillTitle.Clear();
            txtBillAmount.Clear();
            txtBillPeriod.Clear();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm=new FrmBanks(currentUser);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnExpensesForm_Click(object sender, EventArgs e)
        {
            FrmExpenses frm=new FrmExpenses(currentUser);
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

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard(currentUser);
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frm=new FrmSettings(currentUser);
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
