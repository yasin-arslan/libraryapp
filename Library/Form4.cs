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
    public partial class Form4 : Form
    {
        private string student;
        private MySqlConnection connection;
        public Form4(MySqlConnection conn,string id,string bookname,string author,int price,List<string> studentInfo)
        {
            InitializeComponent();
            this.form4BookID.Text = id;
            this.form4BookName.Text = bookname;
            this.form4Author.Text = author;
            this.form4Price.Text = Convert.ToString(price);
            connection = conn;
            foreach(string student in studentInfo)
            {
                this.form4Borrower.Items.Add(student);
            }  
        }

        private void borrowBookBtn_Click(object sender, EventArgs e)
        {
            MySqlCommand exist = new MySqlCommand();
            exist = connection.CreateCommand();
            exist.CommandText = "SELECT count(*) FROM books WHERE books.borrower = '" + form4Borrower.Text + "'";
            Int64 rowCount = (Int64) exist.ExecuteScalar();
            if (rowCount != 0)
            {
                MessageBox.Show(" Bu öğrenci zaten kitap ödünç almış! ");
            }
            else
            {
                try
                {
                    string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    string sqlFormattedDateDue = DateTime.Now.AddDays(15).ToString("yyyy-MM-dd HH:mm:ss.fff");
                    string studentId = form4Borrower.Text;
                    string bookName = form4BookName.Text;
                    MySqlCommand comm = new MySqlCommand();
                    comm = connection.CreateCommand();
                    comm.CommandText = "update userdb.books set borrower='"+studentId+"',borrowdate='"+sqlFormattedDate+"',datedue='"+sqlFormattedDateDue+"'where title='"+bookName+"'";
                    comm.ExecuteNonQuery();
                    MessageBox.Show(bookName + " isimli kitap " + studentId + " numaralı öğrenciye ödünç verildi! ");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
