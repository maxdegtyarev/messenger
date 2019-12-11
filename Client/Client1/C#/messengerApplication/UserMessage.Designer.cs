namespace messengerApplication
{
    partial class UserMessage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_name = new MaterialSkin.Controls.MaterialLabel();
            this.label_surname = new MaterialSkin.Controls.MaterialLabel();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Depth = 0;
            this.label_name.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_name.Location = new System.Drawing.Point(112, 20);
            this.label_name.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(52, 19);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "NAME";
            this.label_name.Click += new System.EventHandler(this.UserMessage_Click);
            this.label_name.MouseEnter += new System.EventHandler(this.UserMessage_MouseEnter);
            this.label_name.MouseLeave += new System.EventHandler(this.UserMessage_MouseLeave);
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Depth = 0;
            this.label_surname.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_surname.Location = new System.Drawing.Point(112, 52);
            this.label_surname.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(80, 19);
            this.label_surname.TabIndex = 1;
            this.label_surname.Text = "SURNAME";
            this.label_surname.Click += new System.EventHandler(this.UserMessage_Click);
            this.label_surname.MouseEnter += new System.EventHandler(this.UserMessage_MouseEnter);
            this.label_surname.MouseLeave += new System.EventHandler(this.UserMessage_MouseLeave);
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.image.Image = global::messengerApplication.Properties.Resources._25;
            this.image.InitialImage = global::messengerApplication.Properties.Resources._11444610701574338604_128;
            this.image.Location = new System.Drawing.Point(4, 4);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(80, 80);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.UserMessage_Click);
            this.image.MouseEnter += new System.EventHandler(this.UserMessage_MouseEnter);
            this.image.MouseLeave += new System.EventHandler(this.UserMessage_MouseLeave);
            // 
            // UserMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.image);
            this.Controls.Add(this.label_surname);
            this.Controls.Add(this.label_name);
            this.Name = "UserMessage";
            this.Size = new System.Drawing.Size(228, 94);
            this.Load += new System.EventHandler(this.UserMessage_Load);
            this.Click += new System.EventHandler(this.UserMessage_Click);
            this.MouseEnter += new System.EventHandler(this.UserMessage_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserMessage_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label_name;
        private MaterialSkin.Controls.MaterialLabel label_surname;
        private System.Windows.Forms.PictureBox image;
    }
}
