using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class MainForm : Form
    {
        Point lastPoint;
        public static MainForm Instantiate;

        public MainForm()
        {
            InitializeComponent();
            CheckForEnter();
            SetShopAssortiment();
            SetRoundedShape(panel2, 64);
            Instantiate = this;
        }

        private void ReadLogin(out string login)
        {
            using (StreamReader sr = new StreamReader(@"..\userData.txt"))
            {
                login = sr.ReadLine();
            }
        }

        private void CheckForEnter()
        {
            string login;
            ReadLogin(out login);
            if (!login.Equals(" ")) {
                GlobalFields.isConnected = true;
                using (SqlConnection connection = new SqlConnection(GlobalFields.CONNECTION))
                {
                    connection.Open();
                    SqlCommand com = new SqlCommand($"Select Никнейм from Пользователи where Email = '{login}'", connection);
                    EnterTextBox.Text = com.ExecuteScalar().ToString();
                }
            }
        }

        public void SetShopAssortiment()
        {
            Clear();
            IssiuesTextBox.Visible = false;
            panel2.Visible = false;
            using (SqlConnection connection = new SqlConnection(GlobalFields.CONNECTION))
            {
                connection.Open();
                string login;
                ReadLogin(out login);
                if (GlobalFields.isConnected)
                {
                    SqlCommand com1 = new SqlCommand($"Select Роль from [Пользователи] where Email = '{login}'", connection);
                    if (com1.ExecuteScalar().ToString() == "admin")
                    {
                        panel2.Visible = true;
                    }
                }
                SqlCommand com2 = new SqlCommand($"Select * from dbo.[GetGames]('{login}')", connection);
                SqlDataReader Reader1;
                Reader1 = com2.ExecuteReader();
                for (int i = 0; Reader1.Read(); i++)
                {
                    string gameId = Reader1[0].ToString();
                    ShopAssortiment shop = new ShopAssortiment(Reader1[0].ToString(), Reader1[1].ToString() + " руб.", Convert.ToInt32(Reader1[2]) == 1, Convert.ToInt32(Reader1[3]) == 1);
                    shop.Location = new Point(50, 30 + i * 330);
                    CenterPanel.Controls.Add(shop);
                }
                Reader1.Close();
                SqlCommand com3 = new SqlCommand("Select Название from Genres", connection);
                Reader1 = com3.ExecuteReader();

                for (int i = 0; Reader1.Read(); i++)
                {
                    string Name = Reader1[0].ToString();

                    Label label = new Label();
                    label.Size = new Size(Name.Length*10, 16);
                        
                    label.Click += (sender, e) => {
                        using (SqlConnection connection2 = new SqlConnection(GlobalFields.CONNECTION))
                        {
                            connection2.Open();
                            ReadLogin(out login);
                            if (GlobalFields.isConnected)
                            {
                                SqlCommand com1 = new SqlCommand($"Select Роль from [Пользователи] where Email = '{login}'", connection2);
                                if (com1.ExecuteScalar().ToString() == "admin")
                                {
                                    panel2.Visible = true;
                                }
                            }
                            Clear();
                            SqlCommand com4 = new SqlCommand($"Select * from dbo.[GetGames]('{login}') where Genre = (select id from Genres where Название = '{Name}')", connection2);
                            if(Name == "ALL") { com4.CommandText = $"Select * from dbo.[GetGames]('{login}')"; }
                            SqlDataReader Reader2;
                            Reader2 = com4.ExecuteReader();
                            for (int j = 0; Reader2.Read(); j++)
                            {
                                string gameId = Reader2[0].ToString();
                                ShopAssortiment shop = new ShopAssortiment(Reader2[0].ToString(), Reader2[1].ToString() + " руб.", Convert.ToInt32(Reader2[2]) == 1, Convert.ToInt32(Reader2[3]) == 1);
                                shop.Location = new Point(50, 30 + j * 330);
                                CenterPanel.Controls.Add(shop);
                            }
                        }
                    };

                    label.Text = Name;

                    Genres.Controls.Add(label);
                    if(i == 0)
                    {
                        label.Location = new Point(50, 5);
                        continue;
                    }
                    label.Location = new Point(Genres.Controls[i-1].Location.X + Genres.Controls[i-1].Width + 10, 5);
                }
            }
        }

        private void SetLibrary()
        {
            Clear();
            if (!GlobalFields.isConnected)
            {
                IssiuesTextBox.Visible = true;
                IssiuesTextBox.Text = "Для просмотра вашей библиотеки зайдите в аккаунт";
                return;
            }
            using (SqlConnection connection = new SqlConnection(GlobalFields.CONNECTION))
            {
                connection.Open();
                string login;
                ReadLogin(out login);
                SqlCommand com2 = new SqlCommand($"Select [Магазин/Игры].Название, Библиотека.[Наиграно часов] from [Магазин/Игры] Inner Join Библиотека ON [Магазин/Игры].ID = Библиотека.ID_Игры where ID_Пользователя = (select ID from Пользователи where Email = '{login}')", connection);
                SqlDataReader Reader1;
                Reader1 = com2.ExecuteReader();
                int j = -1;
                for (int i = 0; Reader1.Read(); i++)
                {
                    if(i % 3 == 0) { j++; }
                    LibraryComponent component = new LibraryComponent(Reader1[0].ToString(), Reader1[1].ToString() + " часов в игре");
                    component.Location = new Point(20+230*(i%3), 30+330*j);
                    CenterPanel.Controls.Add(component);
                }
            }
        }

        private void SetFavourite()
        {
            Clear();
            if (!GlobalFields.isConnected)
            {
                IssiuesTextBox.Visible = true;
                IssiuesTextBox.Text = "Для просмотра ваших избранных игр зайдите в аккаунт";
                return;
            }
            using (SqlConnection connection = new SqlConnection(GlobalFields.CONNECTION))
            {
                connection.Open();
                string login;
                ReadLogin(out login);
                SqlCommand com2 = new SqlCommand($"Select * from dbo.[GetGames]('{login}')", connection);
                SqlDataReader Reader1;
                Reader1 = com2.ExecuteReader();
                int j = -1;
                for (int i = 0; Reader1.Read(); i++)
                {
                    if (Convert.ToInt32(Reader1[3]) == 1) {
                        if (i % 2 == 0) { j++; }
                        string gameId = Reader1[0].ToString();
                        FavouriteGames shop = new FavouriteGames(Reader1[0].ToString(), Reader1[1].ToString() + " руб.", Convert.ToInt32(Reader1[2]) == 1, true);
                        shop.Location = new Point(20 + 375 * (i % 2), 30 + j * 280);
                        CenterPanel.Controls.Add(shop);
                        continue;
                    }
                    i--;
                }
            }
        }

        private void Clear()
        {
            CenterPanel.Controls.Clear();
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

        #region TRIGGERS
        private void upsidePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void upsidePanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FullScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }


        private void Panel7_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void ShopPanel_MouseEnter(object sender, EventArgs e)
        {
            ShopTextBox.ForeColor = Color.FromArgb(235, 235, 235);
            panel4.BackgroundImage = Image.FromFile(@"..\..\Resources\PriceBright.png");
        }

        private void ShopPanel_MouseLeave(object sender, EventArgs e)
        {
            ShopTextBox.ForeColor = Color.FromArgb(195, 195, 195);
            panel4.BackgroundImage = Image.FromFile(@"..\..\Resources\Price.png");
        }

        private void LibraryPanel_MouseEnter(object sender, EventArgs e)
        {
            LibraryTextBox.ForeColor = Color.FromArgb(235, 235, 235);
            panel5.BackgroundImage = Image.FromFile(@"..\..\Resources\BookBright.png");
        }

        private void LibraryPanel_MouseLeave(object sender, EventArgs e)
        {
            LibraryTextBox.ForeColor = Color.FromArgb(195, 195, 195);
            panel5.BackgroundImage = Image.FromFile(@"..\..\Resources\Book.png");
        }

        private void FavouritePanel_MouseEnter(object sender, EventArgs e)
        {
            FavouriteTextBox.ForeColor = Color.FromArgb(235, 235, 235);
            panel6.BackgroundImage = Image.FromFile(@"..\..\Resources\FavouritBright.png");
        }

        private void FavouritePanel_MouseLeave(object sender, EventArgs e)
        {
            FavouriteTextBox.ForeColor = Color.FromArgb(195, 195, 195);
            panel6.BackgroundImage = Image.FromFile(@"..\..\Resources\Favourit.png");
        }

        private void LibraryPanel_Click(object sender, EventArgs e)
        {
            SetLibrary();
        }

        private void ShopPanel_Click(object sender, EventArgs e)
        {
            SetShopAssortiment();
        }

        private void ShopTextBox_Click(object sender, EventArgs e)
        {
            SetShopAssortiment();
        }

        private void Panel4_Click(object sender, EventArgs e)
        {
            SetShopAssortiment();
        }

        private void FavouritePanel_Click(object sender, EventArgs e)
        {
            SetFavourite();
        }
        private void Panel7_MouseEnter(object sender, EventArgs e)
        {
            EnterTextBox.ForeColor = Color.FromArgb(235,235,235);
            panel8.BackgroundImage = Image.FromFile(@"..\..\Resources\LoginBright.png");
        }

        private void Panel7_MouseLeave(object sender, EventArgs e)
        {
            EnterTextBox.ForeColor = Color.FromArgb(195, 195, 195);
            panel8.BackgroundImage = Image.FromFile(@"..\..\Resources\Login.png");
        }
        #endregion

        private void Panel2_MouseEnter(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Image.FromFile(@"..\..\Resources\AddGamesBright.png");
        }

        private void Panel2_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackgroundImage = Image.FromFile(@"..\..\Resources\AddGames.png");
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            AddGame addGame = new AddGame();
            addGame.ShowDialog();
        }
    }
}
