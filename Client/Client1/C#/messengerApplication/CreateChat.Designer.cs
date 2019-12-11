namespace messengerApplication
{
    partial class CreateChat
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.input_chatname = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.button_create = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 103);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(382, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Для создания чата заполните поля ниже:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 165);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(146, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Название чата:";
            // 
            // input_chatname
            // 
            this.input_chatname.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.input_chatname.Depth = 0;
            this.input_chatname.Hint = "";
            this.input_chatname.Location = new System.Drawing.Point(193, 165);
            this.input_chatname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.input_chatname.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_chatname.Name = "input_chatname";
            this.input_chatname.PasswordChar = '\0';
            this.input_chatname.SelectedText = "";
            this.input_chatname.SelectionLength = 0;
            this.input_chatname.SelectionStart = 0;
            this.input_chatname.Size = new System.Drawing.Size(246, 28);
            this.input_chatname.TabIndex = 3;
            this.input_chatname.UseSystemPasswordChar = false;
            // 
            // button_create
            // 
            this.button_create.AutoSize = true;
            this.button_create.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_create.Depth = 0;
            this.button_create.Location = new System.Drawing.Point(309, 230);
            this.button_create.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_create.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_create.Name = "button_create";
            this.button_create.Primary = false;
            this.button_create.Size = new System.Drawing.Size(130, 36);
            this.button_create.TabIndex = 4;
            this.button_create.Text = "Создать чат";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // CreateChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 293);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.input_chatname);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CreateChat";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание чата";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.CreateChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_chatname;
        private MaterialSkin.Controls.MaterialFlatButton button_create;
    }
}