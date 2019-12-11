using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using MaterialSkin.Controls;

namespace messengerApplication
{
    public partial class MessageList : MaterialForm
    {
        int accId;
        string accName;
        string accSurname;

        int globalSecond = 0;

        private LinkedList<Message> messages;
        private LinkedList<Message> newmessages;

        public MessageList()
        {
            InitializeComponent();
        }

        public MessageList(int accId, string accName, string accSurname)
        {
            InitializeComponent();
            this.accId = accId;
            this.accName = accName;
            this.accSurname = accSurname;
        }

        private async void messageList_Load(object sender, EventArgs e)
        {
            waiter.Start();

            Text = accName + " " + accSurname;
            layout_message.Controls.Clear();

            messages = await Task.Run(() =>Program.clientSystem.getPrivateMessageList(accId, Program.clientSystem.AuthorizedAccount.accHash));

            if (messages != null)
            {
                foreach (Message message in messages)
                {
                    if (message.mSender == accId.ToString())
                    {
                        placeMessage(accName, message.mText, message.mDate);
                        
                    } else
                    {
                        placeMessage(Program.clientSystem.AuthorizedAccount.accName, message.mText, message.mDate);
                    }

                }
            }

            layout_message.VerticalScroll.Value = layout_message.VerticalScroll.Minimum;
           
        }

        private void placeMessage(string accname, string text, string date)
        {
            MyMessage result = new MyMessage(accname, text, date);
            result.Parent = layout_message;
            result.Show();
        }

        private void button_send_Click(object sender, EventArgs e)
        {
            sendMessage();
        }
       
        private async void sendMessage()
        {
            if (input_message.Text.Length > 80)
            {
                label_status.Text = "Длина сообщения превышает 80 символов";
            }
            else if (input_message.Text.Length == 0)
            {
                label_status.Text = "Нельзя отправить пустое сообщение";
            }
            else
            {
                try
                {
                    bool result = await Task.Run(() => Program.clientSystem.sendPrivateMessage(accId, input_message.Text, Program.clientSystem.AuthorizedAccount.accHash));
                    if (result)
                    {
                        label_status.Text = "Сообщение доставлено";
                        placeMessage(Program.clientSystem.AuthorizedAccount.accName, input_message.Text, DateTime.Today.ToString());
                        input_message.Clear();
                        //?
                        //System.Windows.Forms.MessageBox.Show(layout_message.AutoScrollPosition.X.ToString() + " " + layout_message.AutoScrollPosition.Y.ToString()) ;

                        layout_message.AutoScrollPosition = new Point(0, layout_message.AutoScrollPosition.Y - 100);
                    }
                    else
                        label_status.Text = "Сообщение не отправлено";
                }
                catch (System.Net.WebException)
                {
                    label_status.Text = "Ошибка подключения";
                }
                catch (Exception)
                {
                    label_status.Text = "Ошибка подключения. Код 2";
                }
            }
        }

        private async void getUnreadMessages()
        {
            try
            {
                newmessages = await Task.Run(() => Program.clientSystem.getUnreadPrivateMessageList(accId, Program.clientSystem.AuthorizedAccount.accHash));
                //Если появились новые сообщения:
                if (newmessages != null)
                {
                    foreach (Message message in newmessages)
                    {
                        if (message.mSender == accId.ToString())
                        {
                            placeMessage(accName, message.mText, message.mDate);
                        }
                        else
                        {
                            placeMessage(Program.clientSystem.AuthorizedAccount.accName, message.mText, message.mDate);
                        }
                    }
                }
            } catch (Exception)
            {
                label_status.Text = "Потеряно соединение с сервером";
            }
 
        }

        private void input_message_Click(object sender, EventArgs e)
        {
            int len = 80 - input_message.Text.Length;
            label_symbols.Text = (len < 0 ? 0 : len).ToString();


        }

        private void waiter_Tick(object sender, EventArgs e)
        {
            globalSecond++;
            if (globalSecond % 3 == 0)
            {
                getUnreadMessages();
            }
        }

        private void input_message_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                sendMessage();
            }
        }
    }
}
