using System.Data.SqlClient;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F39HN58\\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
        int s = 1;
        int puan = 0;
        public void sorular()
        {
            if (s == 1)
            {
                baglanti.Open();
                int x = 1;
                Random rnd = new Random();
                int r = rnd.Next(1, 4);
                button1.Text = "Sýradaki";
                SqlCommand s1 = new SqlCommand("Select id, soru, a, b, c, d, dc From Soru1 Where id=@r", baglanti);
                s1.Parameters.AddWithValue("@r", r);

                SqlDataReader sqlDR = s1.ExecuteReader();
                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string soru = sqlDR[1].ToString();
                    string a = sqlDR[2].ToString();
                    string b = sqlDR[3].ToString();
                    string c = sqlDR[4].ToString();
                    string d = sqlDR[5].ToString();
                    string dc = sqlDR[6].ToString();
                    label1.Text = "Soru " + s + ")";
                    textBox1.Text = soru;
                    radioButton1.Text = a;
                    radioButton2.Text = b;
                    radioButton3.Text = c;
                    radioButton4.Text = d;
                    label2.Text = dc;
                }

                s++;
                baglanti.Close();
            }
            else if (s == 2)
            {
                baglanti.Open();
                int x = 1;
                Random rnd = new Random();
                int r = rnd.Next(1, 4);
                button1.Text = "Sýradaki";
                SqlCommand s1 = new SqlCommand("Select id, soru, a, b, c, d, dc From Soru2 Where id=@r", baglanti);
                s1.Parameters.AddWithValue("@r", r);

                SqlDataReader sqlDR = s1.ExecuteReader();
                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string soru = sqlDR[1].ToString();
                    string a = sqlDR[2].ToString();
                    string b = sqlDR[3].ToString();
                    string c = sqlDR[4].ToString();
                    string d = sqlDR[5].ToString();
                    string dc = sqlDR[6].ToString();
                    label1.Text = "Soru " + s + ")";
                    textBox1.Text = soru;
                    radioButton1.Text = a;
                    radioButton2.Text = b;
                    radioButton3.Text = c;
                    radioButton4.Text = d;
                    label2.Text = dc;
                }
                s++;
                baglanti.Close();
            }
            else if (s == 3)
            {
                baglanti.Open();
                int x = 1;
                Random rnd = new Random();
                int r = rnd.Next(1, 4);
                button1.Text = "Sýradaki";
                SqlCommand s1 = new SqlCommand("Select id, soru, a, b, c, d, dc From Soru3 Where id=@r", baglanti);
                s1.Parameters.AddWithValue("@r", r);

                SqlDataReader sqlDR = s1.ExecuteReader();
                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string soru = sqlDR[1].ToString();
                    string a = sqlDR[2].ToString();
                    string b = sqlDR[3].ToString();
                    string c = sqlDR[4].ToString();
                    string d = sqlDR[5].ToString();
                    string dc = sqlDR[6].ToString();
                    label1.Text = "Soru " + s + ")";
                    textBox1.Text = soru;
                    radioButton1.Text = a;
                    radioButton2.Text = b;
                    radioButton3.Text = c;
                    radioButton4.Text = d;
                    label2.Text = dc;
                }
                s++;
                baglanti.Close();
            }
            else if (s == 4)
            {
                baglanti.Open();
                int x = 1;
                Random rnd = new Random();
                int r = rnd.Next(1, 4);
                button1.Text = "Sýradaki";
                SqlCommand s1 = new SqlCommand("Select id, soru, a, b, c, d, dc From Soru4 Where id=@r", baglanti);
                s1.Parameters.AddWithValue("@r", r);

                SqlDataReader sqlDR = s1.ExecuteReader();
                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string soru = sqlDR[1].ToString();
                    string a = sqlDR[2].ToString();
                    string b = sqlDR[3].ToString();
                    string c = sqlDR[4].ToString();
                    string d = sqlDR[5].ToString();
                    string dc = sqlDR[6].ToString();
                    label1.Text = "Soru " + s + ")";
                    textBox1.Text = soru;
                    radioButton1.Text = a;
                    radioButton2.Text = b;
                    radioButton3.Text = c;
                    radioButton4.Text = d;
                    label2.Text = dc;
                }
                s++;
                baglanti.Close();
            }
            else if (s == 5)
            {
                baglanti.Open();
                int x = 1;
                Random rnd = new Random();
                int r = rnd.Next(1, 4);
                button1.Text = "Sýradaki";
                SqlCommand s1 = new SqlCommand("Select id, soru, a, b, c, d, dc From Soru5 Where id=@r", baglanti);
                s1.Parameters.AddWithValue("@r", r);

                SqlDataReader sqlDR = s1.ExecuteReader();
                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string soru = sqlDR[1].ToString();
                    string a = sqlDR[2].ToString();
                    string b = sqlDR[3].ToString();
                    string c = sqlDR[4].ToString();
                    string d = sqlDR[5].ToString();
                    string dc = sqlDR[6].ToString();
                    label1.Text = "Soru " + s + ")";
                    textBox1.Text = soru;
                    radioButton1.Text = a;
                    radioButton2.Text = b;
                    radioButton3.Text = c;
                    radioButton4.Text = d;
                    label2.Text = dc;
                }
                s++;
                baglanti.Close();
            }
            else if (s == 6)
            {
                baglanti.Open();
                int x = 1;
                Random rnd = new Random();
                int r = rnd.Next(1, 4);
                button1.Text = "Sýradaki";
                SqlCommand s1 = new SqlCommand("Select id, soru, a, b, c, d, dc From Soru6 Where id=@r", baglanti);
                s1.Parameters.AddWithValue("@r", r);

                SqlDataReader sqlDR = s1.ExecuteReader();
                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string soru = sqlDR[1].ToString();
                    string a = sqlDR[2].ToString();
                    string b = sqlDR[3].ToString();
                    string c = sqlDR[4].ToString();
                    string d = sqlDR[5].ToString();
                    string dc = sqlDR[6].ToString();
                    label1.Text = "Soru " + s + ")";
                    textBox1.Text = soru;
                    radioButton1.Text = a;
                    radioButton2.Text = b;
                    radioButton3.Text = c;
                    radioButton4.Text = d;
                    label2.Text = dc;
                }
                s++;
                baglanti.Close();
            }
            else if (s == 7)
            {
                baglanti.Open();
                int x = 1;
                Random rnd = new Random();
                int r = rnd.Next(1, 4);
                button1.Text = "Sýradaki";
                SqlCommand s1 = new SqlCommand("Select id, soru, a, b, c, d, dc From Soru7 Where id=@r", baglanti);
                s1.Parameters.AddWithValue("@r", r);

                SqlDataReader sqlDR = s1.ExecuteReader();
                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string soru = sqlDR[1].ToString();
                    string a = sqlDR[2].ToString();
                    string b = sqlDR[3].ToString();
                    string c = sqlDR[4].ToString();
                    string d = sqlDR[5].ToString();
                    string dc = sqlDR[6].ToString();
                    label1.Text = "Soru " + s + ")";
                    textBox1.Text = soru;
                    radioButton1.Text = a;
                    radioButton2.Text = b;
                    radioButton3.Text = c;
                    radioButton4.Text = d;
                    label2.Text = dc;
                }
                s++;
                baglanti.Close();
            }
            else if (s == 8)
            {
                baglanti.Open();
                int x = 1;
                Random rnd = new Random();
                int r = rnd.Next(1, 4);
                button1.Text = "Sýradaki";
                SqlCommand s1 = new SqlCommand("Select id, soru, a, b, c, d, dc From Soru8 Where id=@r", baglanti);
                s1.Parameters.AddWithValue("@r", r);

                SqlDataReader sqlDR = s1.ExecuteReader();
                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string soru = sqlDR[1].ToString();
                    string a = sqlDR[2].ToString();
                    string b = sqlDR[3].ToString();
                    string c = sqlDR[4].ToString();
                    string d = sqlDR[5].ToString();
                    string dc = sqlDR[6].ToString();
                    label1.Text = "Soru " + s + ")";
                    textBox1.Text = soru;
                    radioButton1.Text = a;
                    radioButton2.Text = b;
                    radioButton3.Text = c;
                    radioButton4.Text = d;
                    label2.Text = dc;
                }
                s++;
                baglanti.Close();
            }
            else if (s == 9)
            {
                baglanti.Open();
                int x = 1;
                Random rnd = new Random();
                int r = rnd.Next(1, 4);
                button1.Text = "Sýradaki";
                SqlCommand s1 = new SqlCommand("Select id, soru, a, b, c, d, dc From Soru9 Where id=@r", baglanti);
                s1.Parameters.AddWithValue("@r", r);

                SqlDataReader sqlDR = s1.ExecuteReader();
                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string soru = sqlDR[1].ToString();
                    string a = sqlDR[2].ToString();
                    string b = sqlDR[3].ToString();
                    string c = sqlDR[4].ToString();
                    string d = sqlDR[5].ToString();
                    string dc = sqlDR[6].ToString();
                    label1.Text = "Soru " + s + ")";
                    textBox1.Text = soru;
                    radioButton1.Text = a;
                    radioButton2.Text = b;
                    radioButton3.Text = c;
                    radioButton4.Text = d;
                    label2.Text = dc;
                }
                s++;
                baglanti.Close();
            }
            else if (s == 10)
            {
                baglanti.Open();
                int x = 1;
                Random rnd = new Random();
                int r = rnd.Next(1, 4);
                button1.Text = "Sýradaki";
                SqlCommand s1 = new SqlCommand("Select id, soru, a, b, c, d, dc From Soru10 Where id=@r", baglanti);
                s1.Parameters.AddWithValue("@r", r);

                SqlDataReader sqlDR = s1.ExecuteReader();
                while (sqlDR.Read())
                {
                    string id = sqlDR[0].ToString();
                    string soru = sqlDR[1].ToString();
                    string a = sqlDR[2].ToString();
                    string b = sqlDR[3].ToString();
                    string c = sqlDR[4].ToString();
                    string d = sqlDR[5].ToString();
                    string dc = sqlDR[6].ToString();
                    label1.Text = "Soru " + s + ")";
                    textBox1.Text = soru;
                    radioButton1.Text = a;
                    radioButton2.Text = b;
                    radioButton3.Text = c;
                    radioButton4.Text = d;
                    label2.Text = dc;
                }
                s++;
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Test Bitti!\n" + "Toplam puan: " + puan);
                button1.Enabled = false;
                button1.Hide();
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (label2.Text == radioButton1.Text)
                {
                    puan = puan + 10;
                }
            }
            if (radioButton2.Checked == true)
            {
                if (label2.Text == radioButton2.Text)
                {
                    puan = puan + 10;
                }
            }
            if (radioButton3.Checked == true)
            {
                if (label2.Text == radioButton3.Text)
                {
                    puan = puan + 10;
                }
            }
            if (radioButton4.Checked == true)
            {
                if (label2.Text == radioButton4.Text)
                {
                    puan = puan + 10;
                }
            }
            label4.Text = Convert.ToString(puan);
            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false && radioButton4.Checked == false)
            {
                MessageBox.Show("Bir seçeneði iþaretleyiniz!");
            }
            else
            {
                sorular();
            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }
    }
}