namespace messengerApplication
{
    partial class ContactItem
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
            this.label_Name = new MaterialSkin.Controls.MaterialLabel();
            this.label_Status = new MaterialSkin.Controls.MaterialLabel();
            this.button_info = new MaterialSkin.Controls.MaterialRaisedButton();
            this.userPicture = new System.Windows.Forms.PictureBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Depth = 0;
            this.label_Name.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Name.Location = new System.Drawing.Point(149, 20);
            this.label_Name.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(52, 19);
            this.label_Name.TabIndex = 3;
            this.label_Name.Text = "NAME";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Depth = 0;
            this.label_Status.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_Status.Location = new System.Drawing.Point(149, 54);
            this.label_Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(65, 19);
            this.label_Status.TabIndex = 4;
            this.label_Status.Text = "STATUS";
            // 
            // button_info
            // 
            this.button_info.Depth = 0;
            this.button_info.Location = new System.Drawing.Point(221, 91);
            this.button_info.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_info.Name = "button_info";
            this.button_info.Primary = true;
            this.button_info.Size = new System.Drawing.Size(46, 23);
            this.button_info.TabIndex = 6;
            this.button_info.Text = "INFO";
            this.button_info.UseVisualStyleBackColor = true;
            this.button_info.Click += new System.EventHandler(this.button_info_Click);
            // 
            // userPicture
            // 
            this.userPicture.BackColor = System.Drawing.SystemColors.ControlDark;
            this.userPicture.Image = global::messengerApplication.Properties.Resources._15930112391572907865_128;
            this.userPicture.Location = new System.Drawing.Point(3, 3);
            this.userPicture.Name = "userPicture";
            this.userPicture.Size = new System.Drawing.Size(122, 120);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.userPicture.TabIndex = 2;
            this.userPicture.TabStop = false;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialFlatButton1.Location = new System.Drawing.Point(153, 84);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(42, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "MSG";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ContactItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.button_info);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.userPicture);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContactItem";
            this.Size = new System.Drawing.Size(315, 126);
            this.Load += new System.EventHandler(this.ContactItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox userPicture;
        private MaterialSkin.Controls.MaterialLabel label_Name;
        private MaterialSkin.Controls.MaterialLabel label_Status;
        private MaterialSkin.Controls.MaterialRaisedButton button_info;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
    }
}
