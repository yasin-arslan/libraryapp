using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
namespace Library
{
    public partial class Form1 : Form
    {
        private int userType;
        // Dinamik bağlantı hatası mesajı.
        private string connectionFailedMessage = " Veritabanı bağlantısı başarısız! ";
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //default olarak password kısmını gizliyoruz.
            passwordHider.Checked = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void studentCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            managerCheckBox.Enabled = !studentCheckBox.Checked;
            // userType 0 öğrenci tipi olarak database'de yer alıyor.
            userType = 0;
        }

        private void managerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            studentCheckBox.Enabled = !managerCheckBox.Checked;
            //userType 1 öğretmen/yönetici olarak database'de yer alıyor.
            userType = 1;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //login butonuna basmadan database'e bağlanmıyoruz.
            MySqlConnection conn = new MySqlConnection();
            const string connString = "Persist Security Info=False;database=userdb;server=localhost;user id=root;Password=;convert zero datetime=True";
            conn.ConnectionString = connString;
            try
            {
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                //  Başlangıç: database'e komut yolluyoruz, girilen textboxtaki userid ve userpw var mı diye kontrol ediyor.
                cmd.CommandText = "select * from userdata where userid='" + userText.Text + "' and userpw='" + passwordText.Text + "' and usertype='" + userType + "' ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                // Datatable'a database'den dönen verileri dolduruyoruz.Eğer Row Count 0 ise veri bulunamamış oluyor.
                int i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    MessageBox.Show("Not OK!", userText.Text);
                }
                else
                {
                    // Bunu yapma sebebimiz  login formunun başlığına attıktan sonra, kullanıcı adı ve şifreyi sıfırlıyoruz, böylece üyelik yazılı kalmıyor.
                    string bUser = userText.Text;
                    userText.Text = "";
                    passwordText.Text = "";
                    // Login formunu mainbody(form2) açılınca kapatma işlemi.
                    this.Hide();
                    Form2 mainBody = new Form2(userType);
                    mainBody.Text = bUser + " olarak giriş yapıldı! ";
                    mainBody.ShowDialog();
                    mainBody = null;
                    this.Show();
                }
            }
            catch (MySqlException ex)
            {
                if(ex.Code == 0)
                {
                    MessageBox.Show(connectionFailedMessage);
                }
                else
                {
                    MessageBox.Show(ex.Message + ex.Code);
                }

            }
        }
        private void passwordHider_CheckedChanged(object sender, EventArgs e)
        {
            passwordText.UseSystemPasswordChar = passwordHider.Checked;
        }
    }
}
