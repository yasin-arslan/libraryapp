using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Library
{
    public partial class Form3 : Form
    {
        private MySqlConnection conn = new MySqlConnection();
        private MySqlCommand cmd = new MySqlCommand();
        private const string connString = "Persist Security Info=False;database=userdb;server=localhost;user id=root;Password=;convert zero datetime=True";
        public Form3()
        {
            InitializeComponent();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connString;
            conn.Open();
            string titletext = titleText.Text;
            string authortext = authorText.Text;
            string pricetext = priceText.Text;
            cmd = conn.CreateCommand();
            cmd.CommandText = "insert into userdb.books(title,author,price) Values('"+titletext+"'," +
                "'"+authortext+"','"+pricetext+ "')";
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Kitap veritabanına eklendi. ");
                this.Hide();
                Form2.accessForm.Show();
            }
            catch (MySqlException ex)
            {
                if (ex.Message.ToLower().Contains("duplicate entry"))
                {
                    MessageBox.Show(" Bu kitap veritabanında yer almaktadır, girilen bilgileri kontrol ediniz. ", "Veri Çakışması", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    MessageBox.Show(ex.Message);
            }
            Form2.accessForm.refresh();
        }
    }
}
