namespace messengerApplication
{
    partial class Profile
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
            this.components = new System.ComponentModel.Container();
            this.view_contact = new MaterialSkin.Controls.MaterialTabControl();
            this.view_information = new System.Windows.Forms.TabPage();
            this.input_surname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.input_name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button_updateinfo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label_hash = new MaterialSkin.Controls.MaterialLabel();
            this.label_info_hash = new MaterialSkin.Controls.MaterialLabel();
            this.label_info_surname = new MaterialSkin.Controls.MaterialLabel();
            this.label_infoname = new MaterialSkin.Controls.MaterialLabel();
            this.label_seconds = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nocom_1 = new messengerApplication.PanelNoComponent();
            this.label_contacts_info = new MaterialSkin.Controls.MaterialLabel();
            this.layout_contacts = new System.Windows.Forms.FlowLayoutPanel();
            this.view_messagelist = new System.Windows.Forms.TabPage();
            this.no_com2 = new messengerApplication.PanelNoComponent();
            this.label_info_with = new MaterialSkin.Controls.MaterialLabel();
            this.layout_messagelist = new System.Windows.Forms.FlowLayoutPanel();
            this.view_user = new System.Windows.Forms.TabPage();
            this.no_com3 = new messengerApplication.PanelNoComponent();
            this.layout_user = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.main_panel = new MaterialSkin.Controls.MaterialTabSelector();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.view_contact.SuspendLayout();
            this.view_information.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.view_messagelist.SuspendLayout();
            this.view_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // view_contact
            // 
            this.view_contact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.view_contact.Controls.Add(this.view_information);
            this.view_contact.Controls.Add(this.tabPage2);
            this.view_contact.Controls.Add(this.view_messagelist);
            this.view_contact.Controls.Add(this.view_user);
            this.view_contact.Depth = 0;
            this.view_contact.Location = new System.Drawing.Point(0, 119);
            this.view_contact.Margin = new System.Windows.Forms.Padding(2);
            this.view_contact.MouseState = MaterialSkin.MouseState.HOVER;
            this.view_contact.Name = "view_contact";
            this.view_contact.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.view_contact.SelectedIndex = 0;
            this.view_contact.Size = new System.Drawing.Size(591, 280);
            this.view_contact.TabIndex = 0;
            this.view_contact.SelectedIndexChanged += new System.EventHandler(this.view_contact_SelectedIndexChanged);
            // 
            // view_information
            // 
            this.view_information.BackColor = System.Drawing.Color.White;
            this.view_information.Controls.Add(this.input_surname);
            this.view_information.Controls.Add(this.input_name);
            this.view_information.Controls.Add(this.button_updateinfo);
            this.view_information.Controls.Add(this.label_hash);
            this.view_information.Controls.Add(this.label_info_hash);
            this.view_information.Controls.Add(this.label_info_surname);
            this.view_information.Controls.Add(this.label_infoname);
            this.view_information.Controls.Add(this.label_seconds);
            this.view_information.Controls.Add(this.materialLabel1);
            this.view_information.Location = new System.Drawing.Point(4, 22);
            this.view_information.Margin = new System.Windows.Forms.Padding(2);
            this.view_information.Name = "view_information";
            this.view_information.Padding = new System.Windows.Forms.Padding(2);
            this.view_information.Size = new System.Drawing.Size(583, 254);
            this.view_information.TabIndex = 0;
            this.view_information.Text = "Основная информация";
            // 
            // input_surname
            // 
            this.input_surname.Depth = 0;
            this.input_surname.Hint = "";
            this.input_surname.Location = new System.Drawing.Point(159, 41);
            this.input_surname.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_surname.Name = "input_surname";
            this.input_surname.PasswordChar = '\0';
            this.input_surname.SelectedText = "";
            this.input_surname.SelectionLength = 0;
            this.input_surname.SelectionStart = 0;
            this.input_surname.Size = new System.Drawing.Size(236, 23);
            this.input_surname.TabIndex = 11;
            this.input_surname.UseSystemPasswordChar = false;
            // 
            // input_name
            // 
            this.input_name.Depth = 0;
            this.input_name.Hint = "";
            this.input_name.Location = new System.Drawing.Point(159, 12);
            this.input_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_name.Name = "input_name";
            this.input_name.PasswordChar = '\0';
            this.input_name.SelectedText = "";
            this.input_name.SelectionLength = 0;
            this.input_name.SelectionStart = 0;
            this.input_name.Size = new System.Drawing.Size(236, 23);
            this.input_name.TabIndex = 10;
            this.input_name.UseSystemPasswordChar = false;
            // 
            // button_updateinfo
            // 
            this.button_updateinfo.Depth = 0;
            this.button_updateinfo.Location = new System.Drawing.Point(28, 152);
            this.button_updateinfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_updateinfo.Name = "button_updateinfo";
            this.button_updateinfo.Primary = true;
            this.button_updateinfo.Size = new System.Drawing.Size(192, 28);
            this.button_updateinfo.TabIndex = 9;
            this.button_updateinfo.Text = "Обновить информацию";
            this.button_updateinfo.UseVisualStyleBackColor = true;
            this.button_updateinfo.Click += new System.EventHandler(this.button_updateinfo_Click);
            // 
            // label_hash
            // 
            this.label_hash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_hash.AutoSize = true;
            this.label_hash.Depth = 0;
            this.label_hash.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_hash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_hash.Location = new System.Drawing.Point(167, 224);
            this.label_hash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_hash.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_hash.Name = "label_hash";
            this.label_hash.Size = new System.Drawing.Size(58, 19);
            this.label_hash.TabIndex = 8;
            this.label_hash.Text = "[HASH]";
            // 
            // label_info_hash
            // 
            this.label_info_hash.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_info_hash.AutoSize = true;
            this.label_info_hash.Depth = 0;
            this.label_info_hash.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_info_hash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_info_hash.Location = new System.Drawing.Point(24, 224);
            this.label_info_hash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_info_hash.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_info_hash.Name = "label_info_hash";
            this.label_info_hash.Size = new System.Drawing.Size(139, 19);
            this.label_info_hash.TabIndex = 7;
            this.label_info_hash.Text = "Хеш авторизации:";
            // 
            // label_info_surname
            // 
            this.label_info_surname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_info_surname.AutoSize = true;
            this.label_info_surname.Depth = 0;
            this.label_info_surname.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_info_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_info_surname.Location = new System.Drawing.Point(24, 45);
            this.label_info_surname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_info_surname.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_info_surname.Name = "label_info_surname";
            this.label_info_surname.Size = new System.Drawing.Size(119, 19);
            this.label_info_surname.TabIndex = 5;
            this.label_info_surname.Text = "Ваша фамилия:";
            // 
            // label_infoname
            // 
            this.label_infoname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_infoname.AutoSize = true;
            this.label_infoname.Depth = 0;
            this.label_infoname.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_infoname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_infoname.Location = new System.Drawing.Point(24, 16);
            this.label_infoname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_infoname.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_infoname.Name = "label_infoname";
            this.label_infoname.Size = new System.Drawing.Size(82, 19);
            this.label_infoname.TabIndex = 3;
            this.label_infoname.Text = "Ваше имя:";
            // 
            // label_seconds
            // 
            this.label_seconds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_seconds.AutoSize = true;
            this.label_seconds.Depth = 0;
            this.label_seconds.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_seconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_seconds.Location = new System.Drawing.Point(220, 193);
            this.label_seconds.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_seconds.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_seconds.Name = "label_seconds";
            this.label_seconds.Size = new System.Drawing.Size(17, 19);
            this.label_seconds.TabIndex = 2;
            this.label_seconds.Text = "0";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(24, 193);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(196, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Прошло секунд с запуска:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.nocom_1);
            this.tabPage2.Controls.Add(this.label_contacts_info);
            this.tabPage2.Controls.Add(this.layout_contacts);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(583, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Контакты";
            // 
            // nocom_1
            // 
            this.nocom_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nocom_1.AutoSize = true;
            this.nocom_1.Location = new System.Drawing.Point(3, 3);
            this.nocom_1.Name = "nocom_1";
            this.nocom_1.Size = new System.Drawing.Size(650, 337);
            this.nocom_1.TabIndex = 2;
            // 
            // label_contacts_info
            // 
            this.label_contacts_info.AutoSize = true;
            this.label_contacts_info.Depth = 0;
            this.label_contacts_info.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_contacts_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_contacts_info.Location = new System.Drawing.Point(8, 2);
            this.label_contacts_info.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_contacts_info.Name = "label_contacts_info";
            this.label_contacts_info.Size = new System.Drawing.Size(308, 19);
            this.label_contacts_info.TabIndex = 1;
            this.label_contacts_info.Text = "Список пользователей в моих контактах:";
            // 
            // layout_contacts
            // 
            this.layout_contacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout_contacts.AutoScroll = true;
            this.layout_contacts.Location = new System.Drawing.Point(6, 23);
            this.layout_contacts.Margin = new System.Windows.Forms.Padding(2);
            this.layout_contacts.Name = "layout_contacts";
            this.layout_contacts.Size = new System.Drawing.Size(598, 228);
            this.layout_contacts.TabIndex = 0;
            // 
            // view_messagelist
            // 
            this.view_messagelist.BackColor = System.Drawing.Color.White;
            this.view_messagelist.Controls.Add(this.no_com2);
            this.view_messagelist.Controls.Add(this.label_info_with);
            this.view_messagelist.Controls.Add(this.layout_messagelist);
            this.view_messagelist.Location = new System.Drawing.Point(4, 22);
            this.view_messagelist.Margin = new System.Windows.Forms.Padding(2);
            this.view_messagelist.Name = "view_messagelist";
            this.view_messagelist.Padding = new System.Windows.Forms.Padding(2);
            this.view_messagelist.Size = new System.Drawing.Size(583, 254);
            this.view_messagelist.TabIndex = 2;
            this.view_messagelist.Text = "Сообщения";
            // 
            // no_com2
            // 
            this.no_com2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.no_com2.AutoSize = true;
            this.no_com2.Location = new System.Drawing.Point(4, -3);
            this.no_com2.Name = "no_com2";
            this.no_com2.Size = new System.Drawing.Size(650, 337);
            this.no_com2.TabIndex = 4;
            // 
            // label_info_with
            // 
            this.label_info_with.AutoSize = true;
            this.label_info_with.Depth = 0;
            this.label_info_with.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_info_with.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_info_with.Location = new System.Drawing.Point(8, 2);
            this.label_info_with.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_info_with.Name = "label_info_with";
            this.label_info_with.Size = new System.Drawing.Size(178, 19);
            this.label_info_with.TabIndex = 3;
            this.label_info_with.Text = "Список моих диалогов:";
            // 
            // layout_messagelist
            // 
            this.layout_messagelist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout_messagelist.AutoScroll = true;
            this.layout_messagelist.Location = new System.Drawing.Point(6, 21);
            this.layout_messagelist.Margin = new System.Windows.Forms.Padding(2);
            this.layout_messagelist.Name = "layout_messagelist";
            this.layout_messagelist.Size = new System.Drawing.Size(596, 223);
            this.layout_messagelist.TabIndex = 2;
            this.layout_messagelist.Paint += new System.Windows.Forms.PaintEventHandler(this.layout_messagelist_Paint);
            // 
            // view_user
            // 
            this.view_user.BackColor = System.Drawing.Color.White;
            this.view_user.Controls.Add(this.no_com3);
            this.view_user.Controls.Add(this.layout_user);
            this.view_user.Controls.Add(this.materialLabel2);
            this.view_user.Location = new System.Drawing.Point(4, 22);
            this.view_user.Margin = new System.Windows.Forms.Padding(2);
            this.view_user.Name = "view_user";
            this.view_user.Padding = new System.Windows.Forms.Padding(2);
            this.view_user.Size = new System.Drawing.Size(583, 254);
            this.view_user.TabIndex = 3;
            this.view_user.Text = "Пользователи";
            // 
            // no_com3
            // 
            this.no_com3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.no_com3.AutoSize = true;
            this.no_com3.Location = new System.Drawing.Point(4, -3);
            this.no_com3.Name = "no_com3";
            this.no_com3.Size = new System.Drawing.Size(717, 337);
            this.no_com3.TabIndex = 3;
            // 
            // layout_user
            // 
            this.layout_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout_user.AutoScroll = true;
            this.layout_user.Location = new System.Drawing.Point(4, 28);
            this.layout_user.Margin = new System.Windows.Forms.Padding(2);
            this.layout_user.Name = "layout_user";
            this.layout_user.Size = new System.Drawing.Size(719, 223);
            this.layout_user.TabIndex = 1;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(4, 2);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(264, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Последние зарегистрировавшиеся:";
            // 
            // main_panel
            // 
            this.main_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.main_panel.BaseTabControl = this.view_contact;
            this.main_panel.Depth = 0;
            this.main_panel.Location = new System.Drawing.Point(0, 54);
            this.main_panel.Margin = new System.Windows.Forms.Padding(2);
            this.main_panel.MouseState = MaterialSkin.MouseState.HOVER;
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(602, 60);
            this.main_panel.TabIndex = 1;
            this.main_panel.Text = "Панель";
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 409);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.view_contact);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<accName, accSurname>";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Profile_FormClosed);
            this.Load += new System.EventHandler(this.Profile_Load);
            this.view_contact.ResumeLayout(false);
            this.view_information.ResumeLayout(false);
            this.view_information.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.view_messagelist.ResumeLayout(false);
            this.view_messagelist.PerformLayout();
            this.view_user.ResumeLayout(false);
            this.view_user.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl view_contact;
        private System.Windows.Forms.TabPage view_information;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector main_panel;
        private System.Windows.Forms.TabPage view_messagelist;
        private System.Windows.Forms.Timer mainTimer;
        private MaterialSkin.Controls.MaterialLabel label_seconds;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.FlowLayoutPanel layout_contacts;
        private System.Windows.Forms.FlowLayoutPanel layout_messagelist;
        private System.Windows.Forms.TabPage view_user;
        private System.Windows.Forms.FlowLayoutPanel layout_user;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel label_info_hash;
        private MaterialSkin.Controls.MaterialLabel label_info_surname;
        private MaterialSkin.Controls.MaterialLabel label_infoname;
        private MaterialSkin.Controls.MaterialRaisedButton button_updateinfo;
        private MaterialSkin.Controls.MaterialLabel label_contacts_info;
        private MaterialSkin.Controls.MaterialLabel label_info_with;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_surname;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_name;
        private MaterialSkin.Controls.MaterialLabel label_hash;
        private PanelNoComponent nocom_1;
        private PanelNoComponent no_com2;
        private PanelNoComponent no_com3;
    }
}