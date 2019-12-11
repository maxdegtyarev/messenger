namespace messengerApplication
{
    partial class NotficationControl
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
            this.label_info = new MaterialSkin.Controls.MaterialLabel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.label_text = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Depth = 0;
            this.label_info.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_info.Location = new System.Drawing.Point(3, 0);
            this.label_info.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(107, 19);
            this.label_info.TabIndex = 0;
            this.label_info.Text = "Уведомление";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(172, 54);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(96, 36);
            this.materialFlatButton1.TabIndex = 2;
            this.materialFlatButton1.Text = "Прочитано";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // label_text
            // 
            this.label_text.AutoSize = true;
            this.label_text.Depth = 0;
            this.label_text.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_text.Location = new System.Drawing.Point(3, 19);
            this.label_text.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_text.Name = "label_text";
            this.label_text.Size = new System.Drawing.Size(61, 19);
            this.label_text.TabIndex = 3;
            this.label_text.Text = "<TEXT>";
            // 
            // NotficationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_text);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.label_info);
            this.Name = "NotficationControl";
            this.Size = new System.Drawing.Size(268, 90);
            this.Load += new System.EventHandler(this.NotficationControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label_info;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel label_text;
    }
}
