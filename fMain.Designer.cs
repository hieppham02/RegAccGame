namespace RegAccGame
{
    partial class fMain
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rb_otherBank = new System.Windows.Forms.RadioButton();
            this.rb_mbbank = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_listBank = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_2captchaKey = new System.Windows.Forms.TextBox();
            this.nm_index = new System.Windows.Forms.NumericUpDown();
            this.nm_offset = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_getLuckyMoney = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_loadDatabase = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nm_thread = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.col_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_withdrawPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ipAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_btnSingleActions = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_index)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_offset)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_thread)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1488, 636);
            this.splitContainer1.SplitterDistance = 315;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.nm_thread);
            this.panel2.Controls.Add(this.rb_otherBank);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cb_listBank);
            this.panel2.Controls.Add(this.rb_mbbank);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tb_2captchaKey);
            this.panel2.Controls.Add(this.nm_index);
            this.panel2.Controls.Add(this.nm_offset);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 303);
            this.panel2.TabIndex = 1;
            // 
            // rb_otherBank
            // 
            this.rb_otherBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rb_otherBank.AutoSize = true;
            this.rb_otherBank.Location = new System.Drawing.Point(204, 172);
            this.rb_otherBank.Name = "rb_otherBank";
            this.rb_otherBank.Size = new System.Drawing.Size(88, 17);
            this.rb_otherBank.TabIndex = 13;
            this.rb_otherBank.Text = "Other Banks";
            this.rb_otherBank.UseVisualStyleBackColor = true;
            // 
            // rb_mbbank
            // 
            this.rb_mbbank.AutoSize = true;
            this.rb_mbbank.Checked = true;
            this.rb_mbbank.Location = new System.Drawing.Point(78, 172);
            this.rb_mbbank.Name = "rb_mbbank";
            this.rb_mbbank.Size = new System.Drawing.Size(71, 17);
            this.rb_mbbank.TabIndex = 12;
            this.rb_mbbank.TabStop = true;
            this.rb_mbbank.Text = "MB BANK";
            this.rb_mbbank.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "List bank";
            // 
            // cb_listBank
            // 
            this.cb_listBank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_listBank.FormattingEnabled = true;
            this.cb_listBank.Location = new System.Drawing.Point(78, 134);
            this.cb_listBank.Name = "cb_listBank";
            this.cb_listBank.Size = new System.Drawing.Size(214, 21);
            this.cb_listBank.TabIndex = 10;
            this.cb_listBank.Click += new System.EventHandler(this.cb_listBank_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "2Captcha";
            // 
            // tb_2captchaKey
            // 
            this.tb_2captchaKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_2captchaKey.Location = new System.Drawing.Point(75, 202);
            this.tb_2captchaKey.Name = "tb_2captchaKey";
            this.tb_2captchaKey.Size = new System.Drawing.Size(217, 22);
            this.tb_2captchaKey.TabIndex = 8;
            this.tb_2captchaKey.Text = "0e87250dd658e83bf2b81a68fa53f804";
            // 
            // nm_index
            // 
            this.nm_index.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.nm_index.Location = new System.Drawing.Point(78, 17);
            this.nm_index.Name = "nm_index";
            this.nm_index.Size = new System.Drawing.Size(214, 22);
            this.nm_index.TabIndex = 7;
            // 
            // nm_offset
            // 
            this.nm_offset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nm_offset.Location = new System.Drawing.Point(78, 54);
            this.nm_offset.Name = "nm_offset";
            this.nm_offset.Size = new System.Drawing.Size(214, 22);
            this.nm_offset.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Offset";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Index";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_register);
            this.panel1.Controls.Add(this.btn_getLuckyMoney);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.btn_loadDatabase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 186);
            this.panel1.TabIndex = 0;
            // 
            // btn_register
            // 
            this.btn_register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_register.Location = new System.Drawing.Point(4, 94);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(308, 39);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_getLuckyMoney
            // 
            this.btn_getLuckyMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_getLuckyMoney.Location = new System.Drawing.Point(4, 49);
            this.btn_getLuckyMoney.Name = "btn_getLuckyMoney";
            this.btn_getLuckyMoney.Size = new System.Drawing.Size(308, 39);
            this.btn_getLuckyMoney.TabIndex = 3;
            this.btn_getLuckyMoney.Text = "Lucky money";
            this.btn_getLuckyMoney.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_login.Location = new System.Drawing.Point(4, 139);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(308, 39);
            this.btn_login.TabIndex = 2;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // btn_loadDatabase
            // 
            this.btn_loadDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_loadDatabase.Location = new System.Drawing.Point(4, 4);
            this.btn_loadDatabase.Name = "btn_loadDatabase";
            this.btn_loadDatabase.Size = new System.Drawing.Size(308, 39);
            this.btn_loadDatabase.TabIndex = 0;
            this.btn_loadDatabase.Text = "Load Database";
            this.btn_loadDatabase.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_stt,
            this.col_username,
            this.col_password,
            this.col_withdrawPassword,
            this.col_balance,
            this.col_ipAddress,
            this.col_status,
            this.col_btnSingleActions});
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(1217, 636);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // nm_thread
            // 
            this.nm_thread.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nm_thread.Location = new System.Drawing.Point(78, 93);
            this.nm_thread.Name = "nm_thread";
            this.nm_thread.Size = new System.Drawing.Size(214, 22);
            this.nm_thread.TabIndex = 14;
            this.nm_thread.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Thread";
            // 
            // col_stt
            // 
            this.col_stt.DataPropertyName = "ID";
            this.col_stt.HeaderText = "Index";
            this.col_stt.Name = "col_stt";
            this.col_stt.ReadOnly = true;
            this.col_stt.Width = 50;
            // 
            // col_username
            // 
            this.col_username.DataPropertyName = "USERNAME";
            this.col_username.HeaderText = "Username";
            this.col_username.Name = "col_username";
            this.col_username.ReadOnly = true;
            // 
            // col_password
            // 
            this.col_password.DataPropertyName = "PASSWORD";
            this.col_password.HeaderText = "Password";
            this.col_password.Name = "col_password";
            this.col_password.ReadOnly = true;
            // 
            // col_withdrawPassword
            // 
            this.col_withdrawPassword.DataPropertyName = "WRPASSWORD";
            this.col_withdrawPassword.HeaderText = "WR Password";
            this.col_withdrawPassword.Name = "col_withdrawPassword";
            this.col_withdrawPassword.ReadOnly = true;
            // 
            // col_balance
            // 
            this.col_balance.DataPropertyName = "BALANACE";
            this.col_balance.HeaderText = "Balance";
            this.col_balance.Name = "col_balance";
            this.col_balance.ReadOnly = true;
            this.col_balance.Width = 75;
            // 
            // col_ipAddress
            // 
            this.col_ipAddress.DataPropertyName = "IPADDRESS";
            this.col_ipAddress.HeaderText = "IP Address";
            this.col_ipAddress.Name = "col_ipAddress";
            this.col_ipAddress.ReadOnly = true;
            this.col_ipAddress.Width = 150;
            // 
            // col_status
            // 
            this.col_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_status.DataPropertyName = "STATUS";
            this.col_status.HeaderText = "Status";
            this.col_status.Name = "col_status";
            this.col_status.ReadOnly = true;
            // 
            // col_btnSingleActions
            // 
            this.col_btnSingleActions.HeaderText = "Actions";
            this.col_btnSingleActions.Name = "col_btnSingleActions";
            this.col_btnSingleActions.ReadOnly = true;
            this.col_btnSingleActions.Text = "Click here";
            this.col_btnSingleActions.UseColumnTextForButtonValue = true;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 636);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Main";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_index)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_offset)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_thread)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_loadDatabase;
        private System.Windows.Forms.Button btn_getLuckyMoney;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nm_index;
        private System.Windows.Forms.NumericUpDown nm_offset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_2captchaKey;
        private System.Windows.Forms.ComboBox cb_listBank;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_otherBank;
        private System.Windows.Forms.RadioButton rb_mbbank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nm_thread;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_password;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_withdrawPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ipAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.DataGridViewButtonColumn col_btnSingleActions;
    }
}

