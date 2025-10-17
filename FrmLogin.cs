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

    public partial class FrmLogin : Form
    {
        public Users LoggedInUser { get; private set; }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = txtUsername.Text.Trim();
            string Password = txtPassword.Text;

            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı doğrulama
            var user = db.Users.FirstOrDefault(x => x.UserName == Username && x.Password == Password);

            if (user != null)
            {
                LoggedInUser = user; // Giriş yapan kullanıcıyı sakla
                this.DialogResult = DialogResult.OK; // Giriş başarılı → Program.cs bunu yakalayacak
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

