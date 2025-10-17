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
    public partial class FrmSettings : Form
    {
        private Users currentUser;

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        public FrmSettings(Users user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string yeniKullaniciAdi = txtUsername.Text.Trim();
            string yeniSifre = txtPassword.Text;

            // Boş alan kontrolü
            if (string.IsNullOrWhiteSpace(yeniKullaniciAdi) || string.IsNullOrWhiteSpace(yeniSifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            // Örnek: Giriş yapan kullanıcı ID'si 1 ise
            var user = db.Users.FirstOrDefault(x => x.UserId == 1);

            if (user != null)
            {
                // Bilgiler aynı mı kontrol et
                if (user.UserName == yeniKullaniciAdi && user.Password == yeniSifre)
                {
                    MessageBox.Show("Girilen bilgiler zaten kayıtlı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Güncelleme yapmadan çık
                }

                // Bilgiler farklıysa güncelle
                user.UserName = yeniKullaniciAdi;
                user.Password = yeniSifre;

                db.SaveChanges();

                MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
