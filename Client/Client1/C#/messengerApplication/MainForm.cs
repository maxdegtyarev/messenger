using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace messengerApplication
{
    public partial class authWindow : MaterialForm
    {

        private bool isAutoAuth;

        public authWindow()
        {
            InitializeComponent();
        }

        public authWindow(bool fromProgram = false)
        {
            InitializeComponent();
            isAutoAuth = fromProgram;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void authWindow_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SavedAccount.Equals(true) && isAutoAuth)
            {
                input_knowme.Checked = true;
                input_name.Text = Properties.Settings.Default.AccLogin;
                input_password.Text = Properties.Settings.Default.AccPassword;

                authStart_Click(this, null);
            }
        }


        private void authReg_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
        }

        private async void authStart_Click(object sender, EventArgs e)
        {
            ClientSystem clientSystem = new ClientSystem();
            

            string accName = input_name.Text;
            string accPassword = input_password.Text;
            
            if (string.IsNullOrEmpty(accName) || string.IsNullOrEmpty(accPassword))
            {
                label_status.Text = "Заполнены не все поля";
            }
            else
            {
                
                    label_status.Text = "Происходит авторизация...";
                    try {
                    string responce = await Task.Run(() => clientSystem.authAccount(input_name.Text, input_password.Text));
                    JObject res = JObject.Parse(responce);

                    ResponceMessage responceMessage = new ResponceMessage((int)res["id"], "");

                    if (responceMessage.id == 0)
                    {
                        string MessageResponce = res["message"].ToString();

                        Account parsedAccount = JsonConvert.DeserializeObject<Account>(MessageResponce);


                        if (parsedAccount.accBlocked)
                            label_status.Text = "Аккаунт заблокирован";
                        else
                        {
                            Program.clientSystem.AuthorizedAccount = parsedAccount;

                            Profile profile = new Profile();
                            profile.Show();

                            if (input_knowme.Checked)
                            {
                                Properties.Settings.Default.AccLogin = accName;
                                Properties.Settings.Default.AccPassword = accPassword;

                                Properties.Settings.Default.Save();
                            }
                            Visible = false;
                        }

                    }
                    else
                    {
                        label_status.Text = "Введён неверный логин или пароль";
                    }
                }
                catch (System.Net.WebException)
                {
                    label_status.Text = "Ошибка подключения к серверу";
                }
                catch (Newtonsoft.Json.JsonReaderException)
                {
                    label_status.Text = "Произошла ошибка. Попробуйте ещё раз";
                }

            }
            
            //Decoding input params
        }

        private void input_knowme_CheckedChanged(object sender, EventArgs e)
        {
            if (input_knowme.Checked)
            {
                Properties.Settings.Default.SavedAccount = true;
                Properties.Settings.Default.Save();
            }
            if (!input_knowme.Checked)
            {
                Properties.Settings.Default.SavedAccount = false;
                Properties.Settings.Default.AccLogin = Properties.Settings.Default.AccPassword = string.Empty;
                Properties.Settings.Default.Save();
            }
        }
    }
}
