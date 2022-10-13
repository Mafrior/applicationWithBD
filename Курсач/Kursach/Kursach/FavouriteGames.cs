using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class FavouriteGames : UserControl
    {
        private bool isBuied;

        private bool _isBuied
        {
            get
            {
                return isBuied;
            }
            set
            {
                if (value)
                {
                    Price.Text = "Приобретено";
                }
                isBuied = value;
            }
        }

        private bool isFavourite;

        private bool _isFavourite
        {
            get
            {
                return isFavourite;
            }
            set
            {
                if (value)
                {
                    FavouritePanel.BackgroundImage = Image.FromFile(@"..\..\Resources\FavouriteMiniChecked.png");
                }
                isFavourite = value;
            }
        }

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

        private string price;
        private string _price
        {
            get
            {
                return price;
            }
            set
            {
                if (!isBuied)
                {
                    Price.Text = value;
                }
            }
        }
        private string backgroundPicture
        {
            set
            {
                try
                {
                    MainPanel.BackgroundImage = Image.FromFile(@"..\..\Resources\" + value + ".jpg");
                }
                catch
                {
                    MainPanel.BackColor = Color.FromArgb(195, 195, 195);
                }
            }
        }

        public FavouriteGames(string gn, string pr, bool isbyed, bool isfavourite)
        {
            InitializeComponent();
            FavouritePanel.BackColor = Color.Transparent;
            SetRoundedShape(MainPanel, 10, true);
            SetRoundedShape(DownSidePanel, 10, false);
            _isBuied = isbyed;
            _isFavourite = isfavourite;
            _gameName = gn;
            _price = pr;
            price = pr;
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

        private void Price_Click(object sender, EventArgs e)
        {
            if (!GlobalFields.isConnected)
            {
                return;
            }
            using (SqlConnection connection = new SqlConnection(GlobalFields.CONNECTION))
            {
                connection.Open();
                string login;
                ReadLogin(out login);
                SqlCommand com1 = new SqlCommand($"Insert into Библиотека values ((select ID from [Магазин/Игры] where Название = '{_gameName}'), (select ID from Пользователи where Email = '{login}'), 0)", connection);
                com1.ExecuteNonQuery();
            }
            _isBuied = true;
        }

        private void Price_MouseEnter(object sender, EventArgs e)
        {
            _price = "Приобрести";
        }

        private void Price_MouseLeave(object sender, EventArgs e)
        {
            _price = price;
        }

        private void Panel2_MouseEnter(object sender, EventArgs e)
        {
            if (isFavourite) { return; }
            FavouritePanel.BackgroundImage = Image.FromFile(@"..\..\Resources\FavouriteMiniHov.png");
        }

        private void Panel2_MouseLeave(object sender, EventArgs e)
        {
            if (isFavourite) { return; }
            FavouritePanel.BackgroundImage = Image.FromFile(@"..\..\Resources\FavouriteMini.png");
        }

        private void Panel2_Click(object sender, EventArgs e)
        {
            if (!GlobalFields.isConnected)
            {
                return;
            }
            using (SqlConnection connection = new SqlConnection(GlobalFields.CONNECTION))
            {
                connection.Open();
                string login;
                ReadLogin(out login);
                string sql = isFavourite ? $"Delete from Избранное where ID_Игры = (select ID from [Магазин/Игры] where Название = '{_gameName}') AND ID_Пользователя = (select ID from Пользователи where Email = '{login}')" : $"Insert into Избранное values ((select ID from [Магазин/Игры] where Название = '{_gameName}'), (select ID from Пользователи where Email = '{login}'))";
                SqlCommand com1 = new SqlCommand(sql, connection);
                com1.ExecuteNonQuery();
            }
            _isFavourite = !_isFavourite;
        }
    }
}

