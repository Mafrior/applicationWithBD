using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Registration : Form
    {
        Settings settings;
        bool isPasswordChecked;
        bool isLoginChecked;
        bool isNickNameChecked;
        public Registration(Settings set)
        {
            InitializeComponent();
            settings = set;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!PasswordTextBox.Text.Equals(CheckPasswortTextBox.Text))
            {
                label1.Text = "Пароли не совпадают";
                return;
            }
            if(string.IsNullOrWhiteSpace(PasswordTextBox.Text) || string.IsNullOrWhiteSpace(LoginTextBox.Text) || string.IsNullOrWhiteSpace(NicknameTextBox.Text))
            {
                label1.Text = "Поля должны быть заполнены";
                return;
            }
            using (SqlConnection connection = new SqlConnection(GlobalFields.CONNECTION))
            {
                connection.Open();
                SqlCommand com2 = new SqlCommand($"Select Count(*) from Пользователи where Email = '{LoginTextBox.Text}'", connection);
                if (Convert.ToInt32(com2.ExecuteScalar().ToString()) > 0){
                    label1.Text = "Пользователь с таким Email уже зарегистрирован";
                    return;
                }
                SqlCommand com1 = new SqlCommand($"Insert into Пользователи values ('{LoginTextBox.Text}', '{PasswordTextBox.Text}', 'user', '{NicknameTextBox.Text}') ", connection);
                com1.ExecuteNonQuery();
            }
            Close();
            settings.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTextBox.Text))
            {
                isLoginChecked = false;
                button1.Enabled = false;
                return;
            }
            isLoginChecked = true;
            if (isLoginChecked && isPasswordChecked && isNickNameChecked)
            {
                button1.Enabled = true;
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                isPasswordChecked = false;
                button1.Enabled = false;
                return;
            }
            isPasswordChecked = true;
            if (isPasswordChecked && isLoginChecked && isNickNameChecked)
            {
                button1.Enabled = true;
            }
        }

        private void NicknameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                isNickNameChecked = false;
                button1.Enabled = false;
                return;
            }
            isNickNameChecked = true;
            if (isPasswordChecked && isLoginChecked && isNickNameChecked)
            {
                button1.Enabled = true;
            }
        }
    }
}
