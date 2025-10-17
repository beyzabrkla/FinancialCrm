namespace FinancialCrm
{
    partial class FrmExpenses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnBankTransactionsForm = new System.Windows.Forms.Button();
            this.btnExpensesForm = new System.Windows.Forms.Button();
            this.btnBillsForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Panel();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.lblBankName = new System.Windows.Forms.Label();
            this.cmbReceived = new System.Windows.Forms.ComboBox();
            this.cmbReceiverId = new System.Windows.Forms.ComboBox();
            this.lblReceiverId = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRemoveTransaction = new System.Windows.Forms.Button();
            this.btnSendMoney = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.btnList.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnBankTransactionsForm);
            this.panel1.Controls.Add(this.btnExpensesForm);
            this.panel1.Controls.Add(this.btnBillsForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 550);
            this.panel1.TabIndex = 7;
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExit.Location = new System.Drawing.Point(43, 305);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(153, 36);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Çıkış Yap";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettings.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSettings.Location = new System.Drawing.Point(43, 263);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(153, 36);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDashboard.Location = new System.Drawing.Point(43, 221);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(153, 36);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBankTransactionsForm
            // 
            this.btnBankTransactionsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBankTransactionsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankTransactionsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankTransactionsForm.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBankTransactionsForm.Location = new System.Drawing.Point(43, 179);
            this.btnBankTransactionsForm.Name = "btnBankTransactionsForm";
            this.btnBankTransactionsForm.Size = new System.Drawing.Size(153, 36);
            this.btnBankTransactionsForm.TabIndex = 4;
            this.btnBankTransactionsForm.Text = "Banka Hareketleri";
            this.btnBankTransactionsForm.UseVisualStyleBackColor = true;
            this.btnBankTransactionsForm.Click += new System.EventHandler(this.btnBankTransactionsForm_Click);
            // 
            // btnExpensesForm
            // 
            this.btnExpensesForm.Cursor = System.Windows.Forms.Cursors.No;
            this.btnExpensesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpensesForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExpensesForm.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnExpensesForm.Location = new System.Drawing.Point(43, 137);
            this.btnExpensesForm.Name = "btnExpensesForm";
            this.btnExpensesForm.Size = new System.Drawing.Size(153, 36);
            this.btnExpensesForm.TabIndex = 3;
            this.btnExpensesForm.Text = "Giderler";
            this.btnExpensesForm.UseVisualStyleBackColor = true;
            // 
            // btnBillsForm
            // 
            this.btnBillsForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBillsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillsForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillsForm.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBillsForm.Location = new System.Drawing.Point(43, 95);
            this.btnBillsForm.Name = "btnBillsForm";
            this.btnBillsForm.Size = new System.Drawing.Size(153, 36);
            this.btnBillsForm.TabIndex = 2;
            this.btnBillsForm.Text = "Faturalar";
            this.btnBillsForm.UseVisualStyleBackColor = true;
            this.btnBillsForm.Click += new System.EventHandler(this.btnBillsForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBanksForm.Location = new System.Drawing.Point(43, 53);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(153, 36);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.No;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Location = new System.Drawing.Point(43, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.Transparent;
            this.btnList.Controls.Add(this.cmbBank);
            this.btnList.Controls.Add(this.lblBankName);
            this.btnList.Controls.Add(this.cmbReceived);
            this.btnList.Controls.Add(this.cmbReceiverId);
            this.btnList.Controls.Add(this.lblReceiverId);
            this.btnList.Controls.Add(this.button2);
            this.btnList.Controls.Add(this.btnRemoveTransaction);
            this.btnList.Controls.Add(this.btnSendMoney);
            this.btnList.Controls.Add(this.txtAmount);
            this.btnList.Controls.Add(this.lblAmount);
            this.btnList.Controls.Add(this.txtDescription);
            this.btnList.Controls.Add(this.lblDescription);
            this.btnList.Controls.Add(this.lblReceived);
            this.btnList.Location = new System.Drawing.Point(202, 0);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(757, 235);
            this.btnList.TabIndex = 9;
            // 
            // cmbBank
            // 
            this.cmbBank.BackColor = System.Drawing.Color.OldLace;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(96, 164);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(232, 21);
            this.cmbBank.TabIndex = 17;
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankName.Location = new System.Drawing.Point(37, 164);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(53, 19);
            this.lblBankName.TabIndex = 16;
            this.lblBankName.Text = "Banka:";
            // 
            // cmbReceived
            // 
            this.cmbReceived.BackColor = System.Drawing.Color.OldLace;
            this.cmbReceived.FormattingEnabled = true;
            this.cmbReceived.Location = new System.Drawing.Point(96, 60);
            this.cmbReceived.Name = "cmbReceived";
            this.cmbReceived.Size = new System.Drawing.Size(232, 21);
            this.cmbReceived.TabIndex = 15;
            // 
            // cmbReceiverId
            // 
            this.cmbReceiverId.BackColor = System.Drawing.Color.OldLace;
            this.cmbReceiverId.FormattingEnabled = true;
            this.cmbReceiverId.Location = new System.Drawing.Point(96, 26);
            this.cmbReceiverId.Name = "cmbReceiverId";
            this.cmbReceiverId.Size = new System.Drawing.Size(232, 21);
            this.cmbReceiverId.TabIndex = 14;
            // 
            // lblReceiverId
            // 
            this.lblReceiverId.AutoSize = true;
            this.lblReceiverId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReceiverId.Location = new System.Drawing.Point(33, 26);
            this.lblReceiverId.Name = "lblReceiverId";
            this.lblReceiverId.Size = new System.Drawing.Size(57, 19);
            this.lblReceiverId.TabIndex = 13;
            this.lblReceiverId.Text = "Alıcı Id:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OldLace;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(408, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Listele";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnRemoveTransaction
            // 
            this.btnRemoveTransaction.BackColor = System.Drawing.Color.OldLace;
            this.btnRemoveTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTransaction.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveTransaction.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRemoveTransaction.Location = new System.Drawing.Point(408, 154);
            this.btnRemoveTransaction.Name = "btnRemoveTransaction";
            this.btnRemoveTransaction.Size = new System.Drawing.Size(168, 36);
            this.btnRemoveTransaction.TabIndex = 10;
            this.btnRemoveTransaction.Text = "İşlem Sil";
            this.btnRemoveTransaction.UseVisualStyleBackColor = false;
            this.btnRemoveTransaction.Click += new System.EventHandler(this.btnRemoveTransaction_Click);
            // 
            // btnSendMoney
            // 
            this.btnSendMoney.BackColor = System.Drawing.Color.OldLace;
            this.btnSendMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMoney.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSendMoney.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSendMoney.Location = new System.Drawing.Point(408, 89);
            this.btnSendMoney.Name = "btnSendMoney";
            this.btnSendMoney.Size = new System.Drawing.Size(168, 36);
            this.btnSendMoney.TabIndex = 8;
            this.btnSendMoney.Text = "Para Gönder";
            this.btnSendMoney.UseVisualStyleBackColor = false;
            this.btnSendMoney.Click += new System.EventHandler(this.btnSendMoney_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.OldLace;
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmount.Location = new System.Drawing.Point(96, 122);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(232, 27);
            this.txtAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.Location = new System.Drawing.Point(35, 125);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(55, 19);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Miktar:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.OldLace;
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDescription.Location = new System.Drawing.Point(96, 89);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(232, 27);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDescription.Location = new System.Drawing.Point(18, 93);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(72, 19);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Açıklama:";
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblReceived.Location = new System.Drawing.Point(24, 59);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(66, 19);
            this.lblReceived.TabIndex = 0;
            this.lblReceived.Text = "Alıcı Adı:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(202, 241);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(757, 298);
            this.panel3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(748, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 549);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giderler";
            this.Load += new System.EventHandler(this.FrmExpenses_Load);
            this.panel1.ResumeLayout(false);
            this.btnList.ResumeLayout(false);
            this.btnList.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnBankTransactionsForm;
        private System.Windows.Forms.Button btnExpensesForm;
        private System.Windows.Forms.Button btnBillsForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel btnList;
        private System.Windows.Forms.Button btnRemoveTransaction;
        private System.Windows.Forms.Button btnSendMoney;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblReceiverId;
        private System.Windows.Forms.ComboBox cmbReceived;
        private System.Windows.Forms.ComboBox cmbReceiverId;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Label lblBankName;
    }
}