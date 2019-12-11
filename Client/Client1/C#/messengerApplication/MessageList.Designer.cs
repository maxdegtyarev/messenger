namespace messengerApplication
{
    partial class MessageList
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
            this.button_send = new MaterialSkin.Controls.MaterialFlatButton();
            this.input_message = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.layout_messages = new System.Windows.Forms.FlowLayoutPanel();
            this.layout_message = new System.Windows.Forms.FlowLayoutPanel();
            this.label_status = new MaterialSkin.Controls.MaterialLabel();
            this.label_symbols = new MaterialSkin.Controls.MaterialLabel();
            this.waiter = new System.Windows.Forms.Timer(this.components);
            this.myMessage2 = new messengerApplication.MyMessage();
            this.myMessage1 = new messengerApplication.MyMessage();
            this.SuspendLayout();
            // 
            // button_send
            // 
            this.button_send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_send.AutoSize = true;
            this.button_send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_send.Depth = 0;
            this.button_send.Location = new System.Drawing.Point(694, 429);
            this.button_send.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button_send.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_send.Name = "button_send";
            this.button_send.Primary = false;
            this.button_send.Size = new System.Drawing.Size(93, 36);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "Отправить";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // input_message
            // 
            this.input_message.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input_message.Depth = 0;
            this.input_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_message.Hint = "";
            this.input_message.Location = new System.Drawing.Point(12, 434);
            this.input_message.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_message.Name = "input_message";
            this.input_message.PasswordChar = '\0';
            this.input_message.SelectedText = "";
            this.input_message.SelectionLength = 0;
            this.input_message.SelectionStart = 0;
            this.input_message.Size = new System.Drawing.Size(656, 23);
            this.input_message.TabIndex = 2;
            this.input_message.UseSystemPasswordChar = false;
            this.input_message.Click += new System.EventHandler(this.input_message_Click);
            this.input_message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_message_KeyDown);
            this.input_message.TextChanged += new System.EventHandler(this.input_message_Click);
            // 
            // layout_messages
            // 
            this.layout_messages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout_messages.AutoScroll = true;
            this.layout_messages.AutoSize = true;
            this.layout_messages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layout_messages.Location = new System.Drawing.Point(12, 76);
            this.layout_messages.Name = "layout_messages";
            this.layout_messages.Size = new System.Drawing.Size(0, 0);
            this.layout_messages.TabIndex = 3;
            // 
            // layout_message
            // 
            this.layout_message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout_message.AutoScroll = true;
            this.layout_message.Location = new System.Drawing.Point(12, 81);
            this.layout_message.Margin = new System.Windows.Forms.Padding(2);
            this.layout_message.Name = "layout_message";
            this.layout_message.Size = new System.Drawing.Size(775, 326);
            this.layout_message.TabIndex = 4;
            // 
            // label_status
            // 
            this.label_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_status.AutoSize = true;
            this.label_status.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_status.Depth = 0;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_status.Location = new System.Drawing.Point(12, 464);
            this.label_status.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(0, 18);
            this.label_status.TabIndex = 5;
            // 
            // label_symbols
            // 
            this.label_symbols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_symbols.AutoSize = true;
            this.label_symbols.Depth = 0;
            this.label_symbols.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label_symbols.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label_symbols.Location = new System.Drawing.Point(643, 460);
            this.label_symbols.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_symbols.Name = "label_symbols";
            this.label_symbols.Size = new System.Drawing.Size(24, 18);
            this.label_symbols.TabIndex = 6;
            this.label_symbols.Text = "80";
            // 
            // waiter
            // 
            this.waiter.Interval = 1000;
            this.waiter.Tick += new System.EventHandler(this.waiter_Tick);
            // 
            // myMessage2
            // 
            this.myMessage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.myMessage2.Location = new System.Drawing.Point(3, 3);
            this.myMessage2.Margin = new System.Windows.Forms.Padding(4);
            this.myMessage2.Name = "myMessage2";
            this.myMessage2.Size = new System.Drawing.Size(734, 70);
            this.myMessage2.TabIndex = 1;
            // 
            // myMessage1
            // 
            this.myMessage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.myMessage1.Location = new System.Drawing.Point(3, 79);
            this.myMessage1.Margin = new System.Windows.Forms.Padding(4);
            this.myMessage1.Name = "myMessage1";
            this.myMessage1.Size = new System.Drawing.Size(734, 70);
            this.myMessage1.TabIndex = 0;
            // 
            // MessageList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.label_symbols);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.layout_message);
            this.Controls.Add(this.layout_messages);
            this.Controls.Add(this.input_message);
            this.Controls.Add(this.button_send);
            this.Name = "MessageList";
            this.Text = "UserName";
            this.Load += new System.EventHandler(this.messageList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialFlatButton button_send;
        private MaterialSkin.Controls.MaterialSingleLineTextField input_message;
        private System.Windows.Forms.FlowLayoutPanel layout_messages;
        private MyMessage myMessage2;
        private MyMessage myMessage1;
        private System.Windows.Forms.FlowLayoutPanel layout_message;
        private MaterialSkin.Controls.MaterialLabel label_status;
        private MaterialSkin.Controls.MaterialLabel label_symbols;
        private System.Windows.Forms.Timer waiter;
    }
}