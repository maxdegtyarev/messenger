namespace messengerApplication
{
    partial class RegisterForm
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
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.regCheck = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.regBirth = new System.Windows.Forms.MonthCalendar();
            this.label_status = new MaterialSkin.Controls.MaterialLabel();
            this.step_first = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.regName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.regSurname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.regPassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.regLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.step_first.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialFlatButton1.Location = new System.Drawing.Point(743, 371);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(210, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "Зарегистрироваться";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // regCheck
            // 
            this.regCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.regCheck.AutoSize = true;
            this.regCheck.BackColor = System.Drawing.SystemColors.Control;
            this.regCheck.Depth = 0;
            this.regCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regCheck.Font = new System.Drawing.Font("Roboto", 10F);
            this.regCheck.ForeColor = System.Drawing.Color.Black;
            this.regCheck.Location = new System.Drawing.Point(16, 370);
            this.regCheck.Margin = new System.Windows.Forms.Padding(0);
            this.regCheck.MouseLocation = new System.Drawing.Point(-1, -1);
            this.regCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.regCheck.Name = "regCheck";
            this.regCheck.Ripple = true;
            this.regCheck.Size = new System.Drawing.Size(493, 30);
            this.regCheck.TabIndex = 3;
            this.regCheck.Text = "Я прочитал(а) условия использования данного продукта";
            this.regCheck.UseVisualStyleBackColor = false;
            this.regCheck.CheckedChanged += new System.EventHandler(this.regCheck_CheckedChanged);
            this.regCheck.MouseEnter += new System.EventHandler(this.regCheck_MouseEnter);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 20);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(317, 24);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Укажите дату, когда вы родились:\r\n";
            // 
            // regBirth
            // 
            this.regBirth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regBirth.Location = new System.Drawing.Point(403, 65);
            this.regBirth.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.regBirth.MaxDate = new System.DateTime(2009, 12, 31, 0, 0, 0, 0);
            this.regBirth.MinDate = new System.DateTime(1909, 1, 1, 0, 0, 0, 0);
            this.regBirth.Name = "regBirth";
            this.regBirth.TabIndex = 2;
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_status.Depth = 0;
            this.label_status.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_status.Location = new System.Drawing.Point(31, 417);
            this.label_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_status.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 24);
            this.label_status.TabIndex = 11;
            // 
            // step_first
            // 
            this.step_first.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.step_first.Controls.Add(this.tabPage1);
            this.step_first.Controls.Add(this.tabPage2);
            this.step_first.Controls.Add(this.tabPage3);
            this.step_first.Depth = 0;
            this.step_first.Location = new System.Drawing.Point(16, 138);
            this.step_first.Margin = new System.Windows.Forms.Padding(4);
            this.step_first.MouseState = MaterialSkin.MouseState.HOVER;
            this.step_first.Name = "step_first";
            this.step_first.SelectedIndex = 0;
            this.step_first.Size = new System.Drawing.Size(935, 480);
            this.step_first.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.regLogin);
            this.tabPage1.Controls.Add(this.materialLabel6);
            this.tabPage1.Controls.Add(this.materialFlatButton2);
            this.tabPage1.Controls.Add(this.materialLabel5);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.regName);
            this.tabPage1.Controls.Add(this.regSurname);
            this.tabPage1.Controls.Add(this.regPassword);
            this.tabPage1.Controls.Add(this.materialLabel4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(927, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основная информация";
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(847, 371);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(69, 36);
            this.materialFlatButton2.TabIndex = 11;
            this.materialFlatButton2.Text = "Далее";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(33, 22);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(374, 24);
            this.materialLabel5.TabIndex = 10;
            this.materialLabel5.Text = "Укажите основную информацию о себе:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(33, 108);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(53, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Имя:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(33, 169);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(97, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Фамилия:";
            // 
            // regName
            // 
            this.regName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regName.Depth = 0;
            this.regName.Hint = "";
            this.regName.Location = new System.Drawing.Point(263, 103);
            this.regName.Margin = new System.Windows.Forms.Padding(4);
            this.regName.MouseState = MaterialSkin.MouseState.HOVER;
            this.regName.Name = "regName";
            this.regName.PasswordChar = '\0';
            this.regName.SelectedText = "";
            this.regName.SelectionLength = 0;
            this.regName.SelectionStart = 0;
            this.regName.Size = new System.Drawing.Size(279, 28);
            this.regName.TabIndex = 0;
            this.regName.UseSystemPasswordChar = false;
            // 
            // regSurname
            // 
            this.regSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regSurname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regSurname.Depth = 0;
            this.regSurname.Hint = "";
            this.regSurname.Location = new System.Drawing.Point(263, 164);
            this.regSurname.Margin = new System.Windows.Forms.Padding(4);
            this.regSurname.MouseState = MaterialSkin.MouseState.HOVER;
            this.regSurname.Name = "regSurname";
            this.regSurname.PasswordChar = '\0';
            this.regSurname.SelectedText = "";
            this.regSurname.SelectionLength = 0;
            this.regSurname.SelectionStart = 0;
            this.regSurname.Size = new System.Drawing.Size(279, 28);
            this.regSurname.TabIndex = 1;
            this.regSurname.UseSystemPasswordChar = false;
            // 
            // regPassword
            // 
            this.regPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regPassword.Depth = 0;
            this.regPassword.Hint = "";
            this.regPassword.Location = new System.Drawing.Point(263, 220);
            this.regPassword.Margin = new System.Windows.Forms.Padding(4);
            this.regPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.regPassword.Name = "regPassword";
            this.regPassword.PasswordChar = '\0';
            this.regPassword.SelectedText = "";
            this.regPassword.SelectionLength = 0;
            this.regPassword.SelectionStart = 0;
            this.regPassword.Size = new System.Drawing.Size(279, 28);
            this.regPassword.TabIndex = 9;
            this.regPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(33, 225);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(194, 24);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Придумайте пароль:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialFlatButton3);
            this.tabPage2.Controls.Add(this.regBirth);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(927, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дата рождения";
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Location = new System.Drawing.Point(862, 371);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(69, 36);
            this.materialFlatButton3.TabIndex = 12;
            this.materialFlatButton3.Text = "Далее";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            this.materialFlatButton3.Click += new System.EventHandler(this.materialFlatButton3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.regCheck);
            this.tabPage3.Controls.Add(this.label_status);
            this.tabPage3.Controls.Add(this.materialFlatButton1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(927, 451);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Конечное соглашение";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 7);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(884, 345);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "Условия использования:\nЧто-нибудь там\nЧто-то ещё\nАбы как";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.step_first;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(16, 102);
            this.materialTabSelector1.Margin = new System.Windows.Forms.Padding(4);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(935, 28);
            this.materialTabSelector1.TabIndex = 13;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // regLogin
            // 
            this.regLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.regLogin.Depth = 0;
            this.regLogin.Hint = "";
            this.regLogin.Location = new System.Drawing.Point(263, 273);
            this.regLogin.Margin = new System.Windows.Forms.Padding(4);
            this.regLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.regLogin.Name = "regLogin";
            this.regLogin.PasswordChar = '\0';
            this.regLogin.SelectedText = "";
            this.regLogin.SelectionLength = 0;
            this.regLogin.SelectionStart = 0;
            this.regLogin.Size = new System.Drawing.Size(279, 28);
            this.regLogin.TabIndex = 13;
            this.regLogin.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(33, 278);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(182, 24);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Придумайте логин:";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 617);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.step_first);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.step_first.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialCheckBox regCheck;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.MonthCalendar regBirth;
        private MaterialSkin.Controls.MaterialLabel label_status;
        private MaterialSkin.Controls.MaterialTabControl step_first;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField regName;
        private MaterialSkin.Controls.MaterialSingleLineTextField regSurname;
        private MaterialSkin.Controls.MaterialSingleLineTextField regPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialSingleLineTextField regLogin;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}