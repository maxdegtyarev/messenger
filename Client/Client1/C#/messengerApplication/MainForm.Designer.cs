namespace messengerApplication
{
    partial class authWindow
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
            this.authReg = new MaterialSkin.Controls.MaterialFlatButton();
            this.authStart = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.input_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.input_password = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label_status = new MaterialSkin.Controls.MaterialLabel();
            this.input_knowme = new MaterialSkin.Controls.MaterialCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // authReg
            // 
            this.authReg.AutoSize = true;
            this.authReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authReg.Depth = 0;
            this.authReg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.authReg.Location = new System.Drawing.Point(25, 362);
            this.authReg.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.authReg.MouseState = MaterialSkin.MouseState.HOVER;
            this.authReg.Name = "authReg";
            this.authReg.Primary = false;
            this.authReg.Size = new System.Drawing.Size(170, 36);
            this.authReg.TabIndex = 0;
            this.authReg.Text = "Зарегистрироваться";
            this.authReg.UseVisualStyleBackColor = true;
            this.authReg.Click += new System.EventHandler(this.authReg_Click);
            // 
            // authStart
            // 
            this.authStart.AutoSize = true;
            this.authStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.authStart.Depth = 0;
            this.authStart.Location = new System.Drawing.Point(216, 362);
            this.authStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.authStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.authStart.Name = "authStart";
            this.authStart.Primary = false;
            this.authStart.Size = new System.Drawing.Size(136, 36);
            this.authStart.TabIndex = 1;
            this.authStart.Text = "Авторизоваться";
            this.authStart.UseVisualStyleBackColor = true;
            this.authStart.Click += new System.EventHandler(this.authStart_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(66, 136);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Имя";
            // 
            // input_name
            // 
            this.input_name.Depth = 0;
            this.input_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_name.Hint = "";
            this.input_name.Location = new System.Drawing.Point(70, 158);
            this.input_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_name.Name = "input_name";
            this.input_name.PasswordChar = '\0';
            this.input_name.SelectedText = "";
            this.input_name.SelectionLength = 0;
            this.input_name.SelectionStart = 0;
            this.input_name.Size = new System.Drawing.Size(232, 23);
            this.input_name.TabIndex = 3;
            this.input_name.UseSystemPasswordChar = false;
            // 
            // input_password
            // 
            this.input_password.Depth = 0;
            this.input_password.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_password.Hint = "";
            this.input_password.Location = new System.Drawing.Point(70, 240);
            this.input_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_password.Name = "input_password";
            this.input_password.PasswordChar = '•';
            this.input_password.SelectedText = "";
            this.input_password.SelectionLength = 0;
            this.input_password.SelectionStart = 0;
            this.input_password.Size = new System.Drawing.Size(232, 23);
            this.input_password.TabIndex = 5;
            this.input_password.UseSystemPasswordChar = true;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(66, 218);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(62, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Пароль";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_status.Depth = 0;
            this.label_status.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_status.Location = new System.Drawing.Point(21, 463);
            this.label_status.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 19);
            this.label_status.TabIndex = 6;
            // 
            // input_knowme
            // 
            this.input_knowme.AutoSize = true;
            this.input_knowme.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.input_knowme.Depth = 0;
            this.input_knowme.Font = new System.Drawing.Font("Roboto", 10F);
            this.input_knowme.Location = new System.Drawing.Point(25, 415);
            this.input_knowme.Margin = new System.Windows.Forms.Padding(0);
            this.input_knowme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.input_knowme.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_knowme.Name = "input_knowme";
            this.input_knowme.Ripple = true;
            this.input_knowme.Size = new System.Drawing.Size(138, 30);
            this.input_knowme.TabIndex = 7;
            this.input_knowme.Text = "Запомнить меня";
            this.input_knowme.UseVisualStyleBackColor = false;
            this.input_knowme.CheckedChanged += new System.EventHandler(this.input_knowme_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(108, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "MaxoGra\'m";
            // 
            // authWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(365, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input_knowme);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.input_name);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.authStart);
            this.Controls.Add(this.authReg);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "authWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.authWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton authReg;
        private MaterialSkin.Controls.MaterialFlatButton authStart;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_name;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_password;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel label_status;
        private MaterialSkin.Controls.MaterialCheckBox input_knowme;
        private System.Windows.Forms.Label label1;
    }
}

