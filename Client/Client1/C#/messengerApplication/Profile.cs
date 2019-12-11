using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace messengerApplication
{
    public partial class Profile : MaterialForm
    {
        private LinkedList<Account> accounts; //Список глобальных аккаунтов
        private LinkedList<Account> contacts; //Список контактов пользователя
        private LinkedList<KeyValuePair<Account,Account>> messages; //Список аккаунтов, с короторыми пользователь осуществляет диалоги
        private LinkedList<Notification> notifications;
        int perSeconds = 0;

        public Profile()
        {
            InitializeComponent();
            Text = Program.clientSystem.AuthorizedAccount.accName + " " + Program.clientSystem.AuthorizedAccount.accSurname;
        }

        private void setText(string text = "none")
        {
            if (text.Equals("none"))
            {
                Text = Program.clientSystem.AuthorizedAccount.accName + " " + Program.clientSystem.AuthorizedAccount.accSurname;

            }
            else {
                Text = text;
                UpdateStyles();
            }
            
        }
            
        

        private async void Profile_Load(object sender, EventArgs e)
        {
            mainTimer.Start();

            loadLists();
            loadContacts();
            loadMessageList();
            loadProfileInfo();
        }

        //Загружает список глобальных пользователей
        private async void loadLists()
        {
            layout_user.Controls.Clear();

            try
            {
                accounts = await Task.Run(() => Program.clientSystem.GetAccounts(Program.clientSystem.AuthorizedAccount.accHash));
                
                if (accounts != null)
                {
                    no_com3.Visible = false;
                    foreach (Account account in accounts)
                    {
                        ContactItem contactItem = new ContactItem(account);
                        contactItem.Parent = layout_user;

                        contactItem.Show();
                    }
                } else
                {
                    no_com3.Visible = true;
                }
            } catch (Exception)
            {
                mainTimer.Stop();
                new Dialog("Проблемы с соединением с удалённым сервером").ShowDialog();
                Close();
            }

        }

        private async void loadNotifications()
        {

            try
            {
                LinkedList<Notification> t_notifications = await Task.Run(() => Program.clientSystem.getAvailableNotificationList(Program.clientSystem.AuthorizedAccount.accHash));
                
                if (t_notifications != null)
                {
                    if (notifications == null)
                        notifications = new LinkedList<Notification>();

                    foreach (Notification notification in t_notifications)
                    {
                        notifications.AddLast(notification);
                    }
                }
         
            } catch (System.Net.WebException)
            {
                mainTimer.Stop();
                new Dialog("Проблемы с соединением с удалённым сервером").ShowDialog();
                Close();
            }
        }

        private void printNotification()
        {
            if (notifications != null)
            {
                if (notifications.Count != 0)
                {
                    string nottext = notifications.First.Value.notText;
                    notifications.RemoveFirst();

                    setText(nottext);
                }
                else
                    setText();
            }
        }

        private async void loadContacts()
        {
            layout_contacts.Controls.Clear();

            try
            {
                contacts = await Task.Run(() => Program.clientSystem.GetContacts(Program.clientSystem.AuthorizedAccount.accHash));


                if (contacts.Count == 0)
                {
                    nocom_1.Visible = true;
                }
                else
                {
                    nocom_1.Visible = false;
                    layout_contacts.Visible = true;

                    foreach (Account account in contacts)
                    {
                        ContactItem contactItem = new ContactItem(account);
                        contactItem.Parent = layout_contacts;

                        contactItem.Show();
                    }
                }
            } catch (Exception)
            {
                new Dialog("Ошибка загрузки контактов").ShowDialog() ;
            }

        }

        private async void loadMessageList()
        {
            layout_messagelist.Controls.Clear();
            messages = await Task.Run(() => Program.clientSystem.GetMessageList(Program.clientSystem.AuthorizedAccount.accHash));

            HashSet<KeyValuePair<int, int>> valuePairs = new HashSet<KeyValuePair<int, int>>();

            if (messages != null)
            {
                no_com2.Visible = false;
                foreach (KeyValuePair<Account,Account> accPair in messages)
                {
                    if (!valuePairs.Contains(new KeyValuePair<int, int>(accPair.Key.accId, accPair.Value.accId)) &&
                        !valuePairs.Contains(new KeyValuePair<int, int>(accPair.Value.accId, accPair.Key.accId)))
                    {
                        UserMessage message;
                        //Если в Sender написано наше имя, то тогда пишем инфу ресивера

                        if (accPair.Key.accId == Program.clientSystem.AuthorizedAccount.accId)
                        {
                            message = new UserMessage(accPair.Value.accId, accPair.Value.accName, accPair.Value.accSurname);
                            //Если в key не наш id, значит добавляем key
                        }
                        else
                        {
                            message = new UserMessage(accPair.Key.accId, accPair.Key.accName, accPair.Key.accSurname);
                        }

                        message.Parent = layout_messagelist;
                        message.Show();

                        //Зафиксируем пару во избежание дубликатов
                        valuePairs.Add(new KeyValuePair<int, int>(accPair.Key.accId, accPair.Value.accId));
                    }
                }
            } else
            {
                no_com2.Visible = true;
            }
        }

        private void loadProfileInfo()
        {
            label_hash.Text = Program.clientSystem.AuthorizedAccount.accHash;
            input_name.Text = Program.clientSystem.AuthorizedAccount.accName;
            input_surname.Text = Program.clientSystem.AuthorizedAccount.accSurname;
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void mainTimer_Tick(object sender, EventArgs e)
        {
            perSeconds++;
            label_seconds.Text = perSeconds.ToString();
            if (perSeconds % 5 == 0)
            {
                
                //Сделаем проверку данных
                try
                {
                    bool result = await Task.Run(() => Program.clientSystem.checkHash(Program.clientSystem.AuthorizedAccount.accHash));
                    if (!result)
                    {
                        mainTimer.Stop();
                        new Dialog("Был осуществён вход в аккаунт с другого ресурса").ShowDialog();
                        Close();
                    }
                } catch (System.Net.WebException)
                {

                    mainTimer.Stop();
                    new Dialog("Проблемы с соединением с удалённым сервером").ShowDialog();
                    Close();
                }

            }

            if (perSeconds % 10 == 0)
            {
                loadNotifications();
            }
            if (perSeconds % 10 == 0)
            {
                printNotification();
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            
        }

        public void update()
        {
            loadContacts();
            loadLists();
            loadMessageList();
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            new CreateChat(Program.clientSystem.AuthorizedAccount).Show();
        }

        private void layout_messagelist_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button_updateinfo_Click(object sender, EventArgs e)
        {
            try
            {
                bool respoce = await Task.Run(() => Program.clientSystem.updateAccount(input_name.Text, input_surname.Text, Program.clientSystem.AuthorizedAccount.accHash));

                if (respoce)
                {
                    Application.Restart();
                }
            } catch (System.Net.WebException)
            {
                Application.Restart();
            }
        }

        private void view_contact_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (view_contact.SelectedIndex)
            {
                case 1:
                    loadContacts();
                    break;
                case 2:
                    loadMessageList();
                    break;
                case 3:
                    loadLists();
                    break;
                default:
                    break;
            }
        }

    }
}
