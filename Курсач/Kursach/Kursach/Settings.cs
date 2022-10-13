using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Kursach
{
    public partial class Settings : Form
    {
        Point lastPoint;
        MainForm mainForm;
        bool isPasswordChecked;
        bool isLoginChecked;

        public Settings()
        {
            InitializeComponent();
            panel2.Visible = GlobalFields.isConnected;
            mainForm = MainForm.Instantiate;
            SetRoundedShape(IconPanel, 64);
            if (GlobalFields.isConnected)
            {
                NickName.Text = MainForm.Instantiate.EnterTextBox.Text;
                using (StreamReader sr = new StreamReader(@"..\userData.txt"))
                {
                    for (int i = 1;  !sr.EndOfStream ; i++)
                    {
                        if (i == 2)
                        {
                            IconPanel.BackgroundImage = Image.FromFile(sr.ReadLine());
                            continue;
                        }
                        sr.ReadLine();
                    }
                }
            }
        }

        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }

        private void UpsidePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void UpsidePanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EnterBD();
        }

        private void EnterBD()
        {
            using (SqlConnection connection = new SqlConnection(GlobalFields.CONNECTION))
            {
                connection.Open();
                SqlCommand com1 = new SqlCommand($"Select Count(*) from Пользователи where (Email = '{LoginTextBox.Text}' And Пароль = '{PasswordTextBox.Text}') OR (Никнейм = '{LoginTextBox.Text}' And Пароль = '{PasswordTextBox.Text}') ", connection);
                if (Convert.ToInt32(com1.ExecuteScalar().ToString()) == 0)
                {
                    issues.Text = "Неверный логин или пароль";
                    return;
                }
                SqlCommand com2 = new SqlCommand($"Select * from Пользователи where (Email = '{LoginTextBox.Text}' And Пароль = '{PasswordTextBox.Text}') OR (Никнейм = '{LoginTextBox.Text}' And Пароль = '{PasswordTextBox.Text}') ", connection);
                SqlDataReader Reader;
                Reader = com2.ExecuteReader();
                Reader.Read();
                mainForm.EnterTextBox.Text = Reader[4].ToString();
                using (StreamWriter sw = new StreamWriter(@"..\userData.txt"))
                {
                    sw.WriteLine($"{Reader[1]}");
                }
            }
            GlobalFields.isConnected = true;
            mainForm.SetShopAssortiment();
            Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(this);
            registration.ShowDialog();
            Close();
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                EnterBD();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"..\userData.txt"))
            {
                sw.WriteLine(" ");
            }
            GlobalFields.isConnected = false;
            mainForm.EnterTextBox.Text = "Вход";
            mainForm.SetShopAssortiment();
            Close();
        }

        private void IconPanel_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Multiselect = true;
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                IconPanel.BackgroundImage = Image.FromFile(OPF.FileName);
            }
            using (StreamWriter sw = new StreamWriter(@"..\userData.txt", true))
            {
                sw.WriteLine(OPF.FileName);
            }
        }

        private void LoginTextBox_Enter(object sender, EventArgs e)
        {
            LoginTextBox.Text = "";
            LoginTextBox.ForeColor = Color.FromArgb(0,0,0);
        }

        private void LoginTextBox_Leave(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "") { 
                LoginTextBox.Text = "Email или Nickname";
                LoginTextBox.ForeColor = Color.FromArgb(88, 88, 88);
            }
        }

        private void LoginTextBox_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(LoginTextBox, "Введите свой логин или Email от аккаунта");
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
            if (isLoginChecked && isPasswordChecked)
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
            if (isPasswordChecked && isLoginChecked)
            {
                button1.Enabled = true;
            }
        }
    }
}
