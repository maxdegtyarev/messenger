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

namespace messengerApplication
{
    public partial class RegisterForm : MaterialForm
    {

        private bool seenTheAgreement = false;

        public RegisterForm()
        {
            InitializeComponent();
            
        }

        private void registerForm_Load(object sender, EventArgs e)
        {
           
        }

        private void regCheck_MouseEnter(object sender, EventArgs e)
        {
            if (!seenTheAgreement)
            {
                seenTheAgreement = true;
            }
        }

        private async void materialFlatButton1_Click(object sender, EventArgs e)
        {
            ClientSystem clientSystem = new ClientSystem();

            string accName = regName.Text.ToString();
            string accSurname = regSurname.Text.ToString();
            string accPassword = regPassword.Text.ToString();

            string accBirth = regBirth.SelectionRange.Start.ToShortDateString().ToString();
            string accLogin = regLogin.Text.ToString();

            if (!regCheck.Checked || string.IsNullOrEmpty(accName) || string.IsNullOrEmpty(accSurname)
                || string.IsNullOrEmpty(accPassword) || string.IsNullOrEmpty(accBirth) || string.IsNullOrEmpty(accLogin))
            {
                label_status.Text = "Не все поля заполнены или не принято условие соглашения";
            } else {
                try {
                    label_status.Text = "Отправляем запрос к API";
                    string res = await Task.Run(() => clientSystem.registerAccountAsync(accLogin, accName, accSurname, accBirth, accPassword));
                    ResponceMessage responce = JsonConvert.DeserializeObject<ResponceMessage>(res);
                    if (responce.id != -2)
                    {
                        label_status.Text = "Успешная регистрация";
                        this.Close();
                    } else
                    {
                        label_status.Text = "Логин уже используется";
                    }
                }
                catch (System.Net.WebException)
                {
                    label_status.Text = "Ошибка сервера - невозможно подключиться к API";
                }
            }

        }

        private void regCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            step_first.SelectTab(2);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            step_first.SelectTab(1);
        }
    }
}
