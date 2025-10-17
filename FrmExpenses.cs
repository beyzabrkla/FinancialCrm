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
    public partial class FrmExpenses : Form
    {
        private Users currentUser;

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public FrmExpenses(Users user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void FrmExpenses_Load(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;

            // Banka bilgilerini göster
            var bankList = db.Banks
                .Select(b => new
                {
                    b.BankId,
                    b.BankTitle,
                    b.BankAccountNumber,
                    b.BankBalance
                }).ToList();

            dataGridView1.DataSource = bankList;

            // Kullanıcı adı
            var userList = db.Users.ToList();
            cmbReceived.DataSource = new BindingSource(userList, null);
            cmbReceived.DisplayMember = "UserName";
            cmbReceived.ValueMember = "UserId";

            // Kullanıcı ID
            cmbReceiverId.DataSource = new BindingSource(userList, null);
            cmbReceiverId.DisplayMember = "UserId";
            cmbReceiverId.ValueMember = "UserId";

            // Banka ComboBox
            cmbBank.DataSource = db.Banks.ToList();
            cmbBank.DisplayMember = "BankTitle";
            cmbBank.ValueMember = "BankId";
            cmbBank.SelectedIndex = -1;
        }

        private void cmbReceived_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReceived.SelectedValue != null)
            {
                cmbReceiverId.SelectedValue = cmbReceived.SelectedValue;
            }
        }

        private void cmbReceiverId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReceiverId.SelectedValue != null)
            {
                cmbReceived.SelectedValue = cmbReceiverId.SelectedValue;
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;

            dataGridView1.DataSource = db.BankProcesses
                .ToList()
                .Select(x => new
                {
                    x.BankProcessId,
                    x.Description,
                    x.Amount,
                    x.ProcessDate,
                    x.ProcessType,
                    x.ProcessUser,
                    ReceiverName = db.Users.FirstOrDefault(u => u.UserId == x.ReceiverId)?.UserName, // ✅ Alıcının adı
                    x.Point,
                    BankName = db.Banks.FirstOrDefault(b => b.BankId == x.BankId)?.BankTitle
                }).ToList();
        }
       
        private void btnRemoveTransaction_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek işlemi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int silinenSayisi = 0;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int processId = Convert.ToInt32(row.Cells["BankProcessId"].Value);// ID üzerinden sil

                var process = db.BankProcesses.FirstOrDefault(x =>
                    x.BankProcessId == processId &&
                    x.SenderId == currentUser.UserId);


                if (process != null)
                {
                    db.BankProcesses.Remove(process);
                    silinenSayisi++;
                }
            }

            db.SaveChanges();

            MessageBox.Show($"{silinenSayisi} işlem başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Listeyi güncelle
            btnList_Click(null, null);

            // Alanları temizle
            txtDescription.Clear();
            txtAmount.Clear();
            cmbBank.SelectedIndex = -1;
            cmbReceiverId.SelectedIndex = -1;
            cmbReceived.SelectedIndex = -1;
        }

        private void btnSendMoney_Click(object sender, EventArgs e)
        {
            string title = txtDescription.Text.Trim();
            decimal amount;

            if (!decimal.TryParse(txtAmount.Text, out amount) || amount <= 0)
            {
                MessageBox.Show("Geçerli bir miktar giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbBank.SelectedIndex == -1 || cmbReceiverId.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen banka ve alıcı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int receiverId = Convert.ToInt32(cmbReceiverId.SelectedValue);
            int bankId = Convert.ToInt32(cmbBank.SelectedValue);
            string selectedName = cmbReceived.Text.Trim();

            var receiver = db.Users.FirstOrDefault(x => x.UserId == receiverId);
            if (receiver == null)
            {
                MessageBox.Show("Alıcı bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (receiver.UserId == currentUser.UserId)
            {
                MessageBox.Show("Kendinize para gönderemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!string.Equals(receiver.UserName.Trim(), selectedName, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Seçilen kullanıcı adı ve ID eşleşmiyor. Lütfen doğru kullanıcıyı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentUser == null)
            {
                MessageBox.Show("Oturum açan kullanıcı bilgisi alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedBank = db.Banks.FirstOrDefault(b => b.BankId == bankId);
            if (selectedBank == null)
            {
                MessageBox.Show("Seçilen banka sistemde bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedBank.BankBalance < amount)
            {
                MessageBox.Show("Seçilen bankada yeterli bakiye yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bakiye düşür
            selectedBank.BankBalance -= amount;

            // İşlem oluştur
            BankProcesses process = new BankProcesses
            {
                SenderId = currentUser.UserId,
                ReceiverId = receiver.UserId,
                Description = title,
                Amount = amount,
                ProcessDate = DateTime.Now,
                ProcessType = "Gönderilen Havale",
                ProcessUser = currentUser.UserName,
                BankId = bankId,
                Point = (int)selectedBank.BankBalance
            };

            db.BankProcesses.Add(process);
            db.SaveChanges();

            MessageBox.Show("Para gönderme işlemi başarıyla tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Temizle
            cmbReceiverId.SelectedIndex = -1;
            cmbReceived.SelectedIndex = -1;
            cmbBank.SelectedIndex = -1;
            txtDescription.Clear();
            txtAmount.Clear();
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
