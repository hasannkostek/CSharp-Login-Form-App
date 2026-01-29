using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanıcı_Adı_ve_Şifre_Giriş_Uygulaması
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBoxKullaniciAdi.Text; // kullanıcı adı kısmını texboxtaki yazan metinle eşledik
            string sifre = textBoxSifre.Text;  // aynı şekilde şifreyi de öyle yaptık

            if(kullaniciAdi== " " )
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz");
            }
            if (sifre == " ")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz");
            }

           
            if (kullaniciAdi == "h" && sifre == "k")
            {
                MessageBox.Show("Hoşgeldiniz");
            }
            else 
            {
                MessageBox.Show("Kullanıcı Adı veya Şifreniz Hatalı");
                textBoxKullaniciAdi.Text = " "; // hatalı girişten sonra kutuyu boşalttık.
                textBoxSifre.Text = " ";
                textBoxKullaniciAdi.Focus(); //hatalı girişten sonra klavye tekrar texboxta olacak.
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            textBoxKullaniciAdi.Text = " "; // hatalı girişten sonra kutuyu boşalttık.
            textBoxSifre.Text = " ";
            textBoxKullaniciAdi.Focus();
        }
    }
}
