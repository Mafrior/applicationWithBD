using System;
using System.Drawing;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Kursach
{
    public partial class LibraryComponent : UserControl
    {
        private string _gameName
        {
            get
            {
                return GameName.Text;
            }
            set
            {
                GameName.Text = value;
            }
        }
        private int timeInGame;
        private string _timeInGame
        {
            get
            {
                return TimeInGame.Text;
            }
            set
            {
                timeInGame = Convert.ToInt32(value.Substring(0, 1));
                TimeInGame.Text = value;
            }
        }
        private string backgroundPicture
        {
            set
            {
                try { 
                    MainPanel.BackgroundImage = Image.FromFile(@"..\..\Resources\" + value + ".jpg");
                }
                catch
                {
                    MainPanel.BackColor = Color.FromArgb(195, 195, 195);
                }
            }
        }

        public LibraryComponent(string gn, string tin)
        {
            InitializeComponent();
            SetRoundedShape(MainPanel, 10, true);
            _gameName = gn;
            _timeInGame = tin;
            backgroundPicture = gn;
        }

        private void ReadLogin(out string login)
        {
            using (StreamReader sr = new StreamReader(@"..\userData.txt"))
            {
                login = sr.ReadLine();
            }
        }

        static void SetRoundedShape(Control control, int radius, bool isMainForm)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            if (isMainForm)
            {
                path.AddLine(radius, 0, control.Width - radius, 0);
                path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            }
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            if (isMainForm)
            {
                path.AddArc(0, 0, radius, radius, 180, 90); ;
            }
            control.Region = new Region(path);
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(GlobalFields.CONNECTION))
            {
                connection.Open();
                string login;
                ReadLogin(out login);
                SqlCommand com1 = new SqlCommand($"Update Библиотека set [Наиграно часов] = (select [Наиграно часов] from Библиотека where ID_Игры = (select ID from [Магазин/Игры] where Название = '{_gameName}') And ID_Пользователя = (select ID from Пользователи where Email = '{login}'))+1 where ID_Игры = (select ID from [Магазин/Игры] where Название = '{_gameName}') And ID_Пользователя = (select ID from Пользователи where Email = '{login}')", connection);
                com1.ExecuteNonQuery();
            }
            _timeInGame = ++timeInGame + " часов в игре";
        }
    }
}
