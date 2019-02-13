using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ConnectedMimari_Insert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Server=Serverİsmi; Database=VeriTabanıİsmi; Integrated Security=true");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into Tabloİsmi (Kolon1,Kolon2) values ('"+textBox1.Text+"','"+textBox2.Text+"')";
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            //Serverİsmi: VeriTabanımıza bağlandığımız ServerName kısmı yazılacak.
            //Database:Veritabanı İsmi(Hangi veritabanı ile çalışacaksak o veritabanı yazılacak.)
            //Integrated Security=SQL'e WindowsAuthentication ile bağlandıysak bağlantı güvenilir diye belirtmek için yazılacak.
            //Tabloİsmi: Veritabanında hangi tablo ile işlem yapmak istiyorsak o tabloyu Tabloİsmi diye belirttiğim yere yazılacak.
            //Kolon1-Kolon2:Hangi kolonlara ekleme yapacakak o kolonları yazıyoruz.Textbox1 Kolon1'e - TextBox2 Kolon2'ye yazılacak.
            //ExecuteNonQuery: Ekleme işleminin gerçekleşmesi için yazılacak.
        }
    }
}
