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
    public partial class AddGame : Form
    {
        public AddGame()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(GameNameTextBox.Text) || string.IsNullOrWhiteSpace(PriceTextBox.Text))
            {
                label1.Text = "Необходимо ввести данные об игре";
                return;
            }
            using (SqlConnection connection = new SqlConnection(GlobalFields.CONNECTION))
            {
                connection.Open();
                SqlCommand com1 = new SqlCommand($"Select Count(*) from Genres where Название = '{GenreTextBox.Text}'", connection);
                if (Convert.ToInt32(com1.ExecuteScalar()) == 0)
                {
                    SqlCommand com2 = new SqlCommand($"Insert into Genres values ('{GenreTextBox.Text}', 0)", connection);
                    com2.ExecuteNonQuery();
                }
                SqlCommand com3 = new SqlCommand($"Insert into [Магазин/Игры] values ('{GameNameTextBox.Text}', {PriceTextBox.Text}, (Select Id from Genres where Название = '{GenreTextBox.Text}')) ", connection);
                com3.ExecuteNonQuery();
            }
            MainForm.Instantiate.SetShopAssortiment();
            Close();
        }
    }
}
