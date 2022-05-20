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
    public partial class Form2 : Form
    {
        // Dictionary'e çevrilecek!
        private List<string> students = new List<string>();
        private string currency = " TL ";
        // Öğretmen/Yönetici Formu.
        private MySqlConnection conn = new MySqlConnection();
        private MySqlCommand cmd = new MySqlCommand();
        private MySqlDataAdapter da;
        private DataTable dt = new DataTable();
        internal static Form2 accessForm;
        private const string connString = "Persist Security Info=False;database=userdb;server=localhost;userid=root;Password=;convert zero datetime=True";
        public Form2(int usertype)
        {
            if (usertype == 0)
            {
                InitializeComponent();
                borrowBookBtn.Enabled = false;
                addBookBtn.Enabled = false;
                removeBtn.Enabled = false;
                openConn();
                refresh();
            }
            else if (usertype == 1)
            {
                InitializeComponent();
                openConn();
                refresh();
                accessForm = this;
            }
        }
        // Database bağlantısını açıyoruz.
        public void openConn()
        {
            conn.ConnectionString = connString;
            conn.Open();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            studentInfos();
            bookData.ClearSelection();
            buttonToggle(showInfos, bookData.RowCount > 0);
        }
        private void studentInfos()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from userdb.students order by student_number";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                // Öğrencinin ödünç aldığı kitap olup olmadığı kontrol ediliyor!
                if (reader.IsDBNull(2))
                {
                    students.Add(reader.GetString(0));
                }
            }
            reader.Close();
        }
        //Bu method ayrıca loginden sonra database'in ekrana basılmasında kullanılıyor. bkz. Form2 classının altında çağrılan => refresh();
        //Bu method sayesinde database'de yaşanan her değişime göre datagridview refresh ediliyor.
        public void refresh()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from books order by ID";
            cmd.ExecuteNonQuery();
            da = new MySqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            bookData.DataSource = dt;
            bookData.ClearSelection();
        }
        private void showInfos_Click(object sender, EventArgs e)
        {
            try
            {
                //Seçili olan satırdaki infoları alıyoruz.
                bookIdText.Text = bookData.SelectedRows[0].Cells[0].Value.ToString();
                bookTitleText.Text = bookData.SelectedRows[0].Cells[1].Value.ToString();
                authorText.Text = bookData.SelectedRows[0].Cells[2].Value.ToString();
                priceText.Text = bookData.SelectedRows[0].Cells[3].Value.ToString();
                borrowerText.Text = bookData.SelectedRows[0].Cells[4].Value.ToString();
                borrowDateText.Text = bookData.SelectedRows[0].Cells[5].Value.ToString();
                dateDueText.Text = bookData.SelectedRows[0].Cells[6].Value.ToString();
                if (string.IsNullOrEmpty(bookData.SelectedRows[0].Cells[7].Value.ToString()))
                {
                    dateReturnedText.Text = "Kitap iade edilmedi! ";
                }
                else
                {
                    dateReturnedText.Text = bookData.SelectedRows[0].Cells[7].Value.ToString();
                };
                if(string.IsNullOrEmpty(bookData.SelectedRows[0].Cells[4].Value.ToString()))
                {
                    borrowerText.Text = "Kitap ödünç alınmamış! ";
                    borrowDateText.Text = borrowerText.Text;
                    dateDueText.Text = borrowerText.Text;
                    dateReturnedText.Text = borrowerText.Text;
                    overDueText.Text = borrowerText.Text;
                    returnFineText.Text = "0 " + currency;
                }
                else
                {
                    string sqlFormattedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                    if (sqlFormattedDate == bookData.SelectedRows[0].Cells[6].Value.ToString())
                    {
                        returnFineText.Text = "0 " + currency;
                        overDueText.Text = "0 Saat";
                    }
                    else
                    {
                        DateTime time = DateTime.Parse(bookData.SelectedRows[0].Cells[6].Value.ToString());
                        var diff = Math.Floor((time - DateTime.Now).TotalHours);
                        returnFineText.Text = diff > 0 ? "0" + currency : Convert.ToString(diff * Convert.ToInt32(bookData.SelectedRows[0].Cells[8].Value));
                        overDueText.Text = diff > 0 ? "0 Saat" : Convert.ToString(diff * -1) + " Saat";
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("index"))
                {
                    MessageBox.Show(" Lütfen bir kitap seçmeden bilgileri göster butonuna basmayınız! ");
                }
            }
        }


        private void addBookBtn_Click(object sender, EventArgs e)
        {
            bookData.ClearSelection();
            this.Hide();
            Form3 addBook = new Form3();
            addBook.ShowDialog();
            addBook = null;
            this.Show();
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string id = bookData.SelectedRows[0].Cells[0].Value.ToString();
                cmd = conn.CreateCommand();
                cmd.CommandText = "DELETE FROM books WHERE ID='" + id + "'";
                cmd.ExecuteNonQuery();
                buttonToggle(showInfos, bookData.RowCount > 0);
                refresh();
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("index"))
                {
                    MessageBox.Show(" Silinecek kitap bulunmamaktadır! ");
                }
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            refresh();
        }

        //Bu custom olarak yazılmış, istenilen butonun kapatılıp açılmasını sağlayan bir method.
        private void buttonToggle(Button button, bool state)
        {
            button.Enabled = state;
        }

        private void borrowBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(bookData.SelectedRows[0].Cells[4].Value.ToString()))
                {
                    MessageBox.Show(" Bu kitap zaten ödünç verilmiş! ");
                }
                else
                {
                    Form4 borrow = new Form4(conn,bookData.SelectedRows[0].Cells[0].Value.ToString()
                        , bookData.SelectedRows[0].Cells[1].Value.ToString(),
                        bookData.SelectedRows[0].Cells[2].Value.ToString(),
                        Convert.ToInt32(bookData.SelectedRows[0].Cells[3].Value)
                        , students
                        );

                    borrow.Show();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.ToLower().Contains("index"))
                {
                    MessageBox.Show(" Lütfen ödünç verilecek bir kitap seçiniz! ");
                }
                else
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

