namespace messengerApplication
{
    partial class MyMessage
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
            this.label_sender = new MaterialSkin.Controls.MaterialLabel();
            this.label_message = new MaterialSkin.Controls.MaterialLabel();
            this.label_time = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // label_sender
            // 
            this.label_sender.AutoSize = true;
            this.label_sender.Depth = 0;
            this.label_sender.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_sender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_sender.Location = new System.Drawing.Point(4, 4);
            this.label_sender.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_sender.Name = "label_sender";
            this.label_sender.Size = new System.Drawing.Size(116, 19);
            this.label_sender.TabIndex = 0;
            this.label_sender.Text = "SENDER_NAME";
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.Depth = 0;
            this.label_message.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_message.Location = new System.Drawing.Point(4, 32);
            this.label_message.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(78, 19);
            this.label_message.TabIndex = 1;
            this.label_message.Text = "MESSAGE";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Depth = 0;
            this.label_time.Font = new System.Drawing.Font("Roboto", 11F);
            this.label_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_time.Location = new System.Drawing.Point(137, 4);
            this.label_time.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(108, 19);
            this.label_time.TabIndex = 2;
            this.label_time.Text = "SENDER_TIME";
            // 
            // MyMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_message);
            this.Controls.Add(this.label_sender);
            this.Name = "MyMessage";
            this.Size = new System.Drawing.Size(734, 59);
            this.Load += new System.EventHandler(this.MyMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label_sender;
        private MaterialSkin.Controls.MaterialLabel label_message;
        private MaterialSkin.Controls.MaterialLabel label_time;
    }
}
