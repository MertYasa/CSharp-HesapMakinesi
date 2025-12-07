using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselProglama_Ödev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Burada daha sonra çağırmak için romen rakamlarını hesaplayan bir class tanımladık.
        static string SayiToRoma(int sayi)
        {
            //romen rakamlarına değerlerini tanımlıyoruz
            string[] romansembolleri = {"_V", "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] tamsayı = { 5000,1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string romarakami = "";
            int i = 0;
            //tam sayıların romen rakamlarına karşılık gelen indisleri buluyor
            while (sayi > 0)
            {
                if (sayi - tamsayı[i] >= 0)
                {
                    romarakami += romansembolleri[i];
                    sayi -= tamsayı[i];
                }
                else
                {
                    i++;
                }
            }

            return romarakami;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //buttona bastğımızda ekrana 1 sayısını yazdırmak için
            if (string.IsNullOrEmpty(label2.Text))
            {
                label1.Text = label1.Text + "1";
            }
            //karekök ikinci kısmı doldurmaması için
            else if (label2.Text == "√")
            {
                DialogResult sonuc = MessageBox.Show("Karekök işlemlerinde ikinci sayıyı giremezseniz", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            else
            {
                label3.Text = label3.Text + "1";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //buttona bastğımızda ekrana 2 sayısını yazdırmak için
            if (string.IsNullOrEmpty(label2.Text))
            {
                label1.Text = label1.Text + "2";
            }
            //karekök ikinci kısmı doldurmaması için
            else if (label2.Text == "√")
            {
                DialogResult sonuc = MessageBox.Show("Karekök işlemlerinde ikinci sayıyı giremezseniz", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            else
            {
                label3.Text = label3.Text + "2";
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            //buttona bastğımızda ekrana 3 sayısını yazdırmak için
            if (string.IsNullOrEmpty(label2.Text))
            {
                label1.Text = label1.Text + "3";
            }
            //karekök ikinci kısmı doldurmaması için
            else if (label2.Text == "√")
            {
                DialogResult sonuc = MessageBox.Show("Karekök işlemlerinde ikinci sayıyı giremezseniz", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            else
            {
                label3.Text = label3.Text + "3";
            }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            //buttona bastğımızda ekrana 0 sayısını yazdırmak için
            if (string.IsNullOrEmpty(label2.Text))
            {
                label1.Text = label1.Text + "0";
            }
            //karekök ikinci kısmı doldurmaması için
            else if (label2.Text== "√")
            {
                DialogResult sonuc = MessageBox.Show("Karekök işlemlerinde ikinci sayıyı giremezseniz", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            else
            {
                label3.Text = label3.Text + "0";
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //buttona bastğımızda ekrana 6 sayısını yazdırmak için
            if (string.IsNullOrEmpty(label2.Text))
            {
                label1.Text = label1.Text + "6";
            }
            //karekök ikinci kısmı doldurmaması için
            else if (label2.Text == "√")
            {
                DialogResult sonuc = MessageBox.Show("Karekök işlemlerinde ikinci sayıyı giremezseniz", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            else
            {
                label3.Text = label3.Text + "6";
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //buttona bastğımızda ekrana 5 sayısını yazdırmak için
            if (string.IsNullOrEmpty(label2.Text))
            {
                label1.Text = label1.Text + "5";
            }
            //karekök ikinci kısmı doldurmaması için
            else if (label2.Text == "√")
            {
                DialogResult sonuc = MessageBox.Show("Karekök işlemlerinde ikinci sayıyı giremezseniz", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            else
            {
                label3.Text = label3.Text + "5";
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //buttona bastğımızda ekrana 4 sayısını yazdırmak için
            if (string.IsNullOrEmpty(label2.Text))
            {
                label1.Text = label1.Text + "4";
            }
            //karekök ikinci kısmı doldurmaması için
            else if (label2.Text == "√")
            {
                DialogResult sonuc = MessageBox.Show("Karekök işlemlerinde ikinci sayıyı giremezseniz", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            else
            {
                label3.Text = label3.Text + "4";
            }


        }

        private void button7_Click(object sender, EventArgs e)
        {
            //buttona bastğımızda ekrana 7 sayısını yazdırmak için
            if (string.IsNullOrEmpty(label2.Text))
            {
                label1.Text = label1.Text + "7";
            }
            //karekök ikinci kısmı doldurmaması için
            else if (label2.Text == "√")
            {
                DialogResult sonuc = MessageBox.Show("Karekök işlemlerinde ikinci sayıyı giremezseniz", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            else
            {
                label3.Text = label3.Text + "7";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            //buttona bastğımızda ekrana 8 sayısını yazdırmak için
            if (string.IsNullOrEmpty(label2.Text))
            {
                label1.Text = label1.Text + "8";
            }
            //karekök ikinci kısmı doldurmaması için
            else if (label2.Text == "√")
            {
                DialogResult sonuc = MessageBox.Show("Karekök işlemlerinde ikinci sayıyı giremezseniz", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            else
            {
                label3.Text = label3.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //buttona bastğımızda ekrana 9 sayısını yazdırmak için
            if (string.IsNullOrEmpty(label2.Text))
            {
                label1.Text = label1.Text + "9";
            }
            //karekök ikinci kısmı doldurmaması için
            else if (label2.Text == "√")
            {
                DialogResult sonuc = MessageBox.Show("Karekök işlemlerinde ikinci sayıyı giremezseniz", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            else
            {
                label3.Text = label3.Text + "9";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // bu kısım aşağıda da tekrar anlatacağım gibi "," işaretin0e enabled true haline getyirmek için 
            button23.Enabled = true;
            // burada hem ilk kısım doldurulmdan işlem yapılmamasını sağlıyor hem de 
            // butona bastğımızda çarpma(yani istenilen işlemi) ekrana yazdırıyor.
            if (string.IsNullOrEmpty(label1.Text))
            {
                DialogResult sonuc = MessageBox.Show("İlk işlemi girmeden işlem yapılamaz ", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            else
            {
                label2.Text = "*";
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //"," işaretini tekrar aktif etmek için
            button23.Enabled = true;
            // burada hem ilk kısım doldurulmdan işlem yapılmamasını sağlıyor hem de 
            // butona bastğımızda toplama(yani istenilen işlemi) ekrana yazdırıyor.
            if (string.IsNullOrEmpty(label1.Text))
            {
                DialogResult sonuc = MessageBox.Show("İlk işlemi girmeden işlem yapılamaz ", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            else
            {
                label2.Text =  "+";
            }
           
        }

        private void button21_Click(object sender, EventArgs e)
        {
            //"," işaretini tekrar aktif etmek için
            button23.Enabled = true;
            // burada hem ilk kısım doldurulmdan işlem yapılmamasını sağlıyor hem de 
            // butona bastğımızda çıkarma(yani istenilen işlemi) ekrana yazdırıyor.
            if (string.IsNullOrEmpty(label1.Text))
            {
                DialogResult sonuc = MessageBox.Show("İlk işlemi girmeden işlem yapılamaz ", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            else
            {
                label2.Text = "-";
            }
           
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //"," işaretini tekrar aktif etmek için
            button23.Enabled = true;
            // burada hem ilk kısım doldurulmdan işlem yapılmamasını sağlıyor hem de 
            // butona bastğımızda bölme(yani istenilen işlemi) ekrana yazdırıyor.
            if (string.IsNullOrEmpty(label1.Text))
            {
                DialogResult sonuc = MessageBox.Show("İlk işlemi girmeden işlem yapılamaz ", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            else
            {
                label2.Text = "/";
            }
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //"," işaretini tekrar aktif etmek için
            button23.Enabled = true;
            // burada hem ilk kısım doldurulmdan işlem yapılmamasını sağlıyor hem de 
            // butona bastğımızda üs alma(yani istenilen işlemi) ekrana yazdırıyor.
            if (string.IsNullOrEmpty(label1.Text))
            {
                DialogResult sonuc = MessageBox.Show("İlk işlemi girmeden işlem yapılamaz ", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            else {
                label2.Text = "Pow";
            }
      
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            //"," işaretini tekrar aktif etmek için
            button23.Enabled = true;
            // burada hem ilk kısım doldurulmdan işlem yapılmamasını sağlıyor hem de 
            // butona bastğımızda ebob(yani istenilen işlemi) ekrana yazdırıyor.
            if (string.IsNullOrEmpty(label1.Text))
            {
                DialogResult sonuc = MessageBox.Show("İlk işlemi girmeden işlem yapılamaz ", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            //girilen sayının tam sayı olıp olmadığını kontrol ediyor.
            else if (!(Convert.ToDouble(label1.Text) % 1 == 0))
            {
                DialogResult sonuc = MessageBox.Show("Ebob işlemi için girdiğiniz değer tam sayı olmalı", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            else
            {
                label2.Text = "Ebob";
            }
   
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //"," işaretini tekrar aktif etmek için
            button23.Enabled = true;
            // burada hem ilk kısım doldurulmdan işlem yapılmamasını sağlıyor hem de 
            // butona bastğımızda kalan bulma(yani istenilen işlemi) ekrana yazdırıyor.
            if (string.IsNullOrEmpty(label1.Text))
            {
                DialogResult sonuc = MessageBox.Show("İlk işlemi girmeden işlem yapılamaz ", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            else
            {
                label2.Text = label2.Text + "Mod";
            }
      
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //"," işaretini tekrar aktif etmek için
            button23.Enabled = true;
            // burada hem ilk kısım doldurulmdan işlem yapılmamasını sağlıyor hem de 
            // butona bastğımızda ekok(yani istenilen işlemi) ekrana yazdırıyor.
            if (string.IsNullOrEmpty(label1.Text))
            {
                DialogResult sonuc = MessageBox.Show("İlk işlemi girmeden işlem yapılamaz ", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            // girilen sayının tam sayı olup olmadığını kontrol ediyor
            else if (!(Convert.ToDouble(label1.Text) % 1 == 0))
            {
                DialogResult sonuc = MessageBox.Show("Ekok işlemi için girdiğiniz değer tam sayı olmalı ", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            else
            {
                label2.Text = "Ekok";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //"," işaretini tekrar aktif etmek için
            button23.Enabled = true;
            // burada hem ilk kısım doldurulmdan işlem yapılmamasını sağlıyor hem de 
            // butona bastğımızda karekök(yani istenilen işlemi) ekrana yazdırıyor.
            if (string.IsNullOrEmpty(label1.Text))
            {
                DialogResult sonuc = MessageBox.Show("İlk işlemi girmeden işlem yapılamaz ", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            else {
                label2.Text ="√";
                label3.Text = " ";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
           // eşittire basıldğında "," tuşu tekrar aktif hale geliyor
            button23.Enabled = true;
            //burada ilk önce sayıalar ve yapılacak işlem girilmeden sonuca gitmiyor ve ekrana hata yazdırıyor
            if (string.IsNullOrEmpty(label1.Text))
            {
                DialogResult sonuc = MessageBox.Show("İlk işlemi girmeden işlem yapılamaz ", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            else if (string.IsNullOrEmpty(label2.Text))
            {
                DialogResult sonuc = MessageBox.Show("Lütfen yağacağınız işlemi seçin!", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            else if (string.IsNullOrEmpty(label3.Text))
            {
                DialogResult sonuc = MessageBox.Show("İkinci sayı girilmedi!", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
            }
            else if (label2.Text == "+")
            {
                // burada hem istenilen(toplam) işlemini yapıyor ve romen rakamları için en başta tanımladığımız fonksiyonu çağırıyor
                //hem de bu sonuçalrı hem ekrana hem de geçmiş ksımına yazdırıyor.
                double sonuc = Convert.ToDouble(label1.Text) + Convert.ToDouble(label3.Text);
                if (sonuc > 0 && sonuc < 10000)
                {
                    label4.Text = "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "+" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                }
                else
                {
                    label4.Text = "=" + Convert.ToString(sonuc);
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "+" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc);
                }

            }
            else if (label2.Text == "-")
            {
                // burada hem istenilen(çıkarma) işlemini yapıyor ve romen rakamları için en başta tanımladığımız fonksiyonu çağırıyor
                //hem de bu sonuçalrı hem ekrana hem de geçmiş ksımına yazdırıyor.
                double sonuc = Convert.ToDouble(label1.Text) - Convert.ToDouble(label3.Text);
                //burada romen rakamları için 4 basamaklı sınırı kontrol ediyor
                if (sonuc > 0 && sonuc < 10000)
                {
                    label4.Text = "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "-" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                }
                else
                {
                    label4.Text = "=" + Convert.ToString(sonuc);
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "-" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc);
                }

            }
            else if (label2.Text == "*")
            {
                // burada hem istenilen(çarpma) işlemini yapıyor ve romen rakamları için en başta tanımladığımız fonksiyonu çağırıyor
                //hem de bu sonuçalrı hem ekrana hem de geçmiş ksımına yazdırıyor.
                double sonuc = Convert.ToDouble(label1.Text) * Convert.ToDouble(label3.Text);
                //burada romen rakamları için 4 basamaklı sınırı kontrol ediyor
                if (sonuc > 0 && sonuc < 10000)
                {
                    label4.Text = "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "*" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                }
                else
                {
                    label4.Text = "=" + Convert.ToString(sonuc);
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "*" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc);
                }
            }
            else if (label2.Text == "/")
            {
                // burada hem istenilen(bölme) işlemini yapıyor ve romen rakamları için en başta tanımladığımız fonksiyonu çağırıyor
                //hem de bu sonuçalrı hem ekrana hem de geçmiş ksımına yazdırıyor.
                if (Convert.ToInt32(label1.Text) == 0)
                {
                    //burada bçlüm kısmı sıfır ise ne olacağını gösteriyor
                    label4.Text = "=" + "∞";
                }
                double sonuc = Convert.ToDouble(label1.Text) / Convert.ToDouble(label3.Text);
                //burada romen rakamları için 4 basamaklı sınırı kontrol ediyor
                if (sonuc > 0 && sonuc < 10000)
                {
                    label4.Text = "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "/" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                }
                else
                {
                    label4.Text = "=" + Convert.ToString(sonuc);
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "/" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc);
                }
                }
            else if (label2.Text == "Pow")
            {
                // burada hem istenilen(üs) işlemini yapıyor ve romen rakamları için en başta tanımladığımız fonksiyonu çağırıyor
                //hem de bu sonuçalrı hem ekrana hem de geçmiş ksımına yazdırıyor.
                double sonuc = Math.Pow(Convert.ToDouble(label1.Text), Convert.ToDouble(label3.Text));
                //burada romen rakamları için 4 basamaklı sınırı kontrol ediyor
                if (sonuc > 0 && sonuc < 10000)
                {
                    label4.Text = "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "^" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                }
                else
                {
                    label4.Text = "=" + Convert.ToString(sonuc);
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "^" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc);
                }
            }
            else if (label2.Text == "Mod")
            {
                // burada hem istenilen(kalanı bulma) işlemini yapıyor ve romen rakamları için en başta tanımladığımız fonksiyonu çağırıyor
                //hem de bu sonuçalrı hem ekrana hem de geçmiş ksımına yazdırıyor.
                double sonuc = Convert.ToDouble(label1.Text) % Convert.ToDouble(label3.Text);
                //burada romen rakamları için 4 basamaklı sınırı kontrol ediyor
                if (sonuc > 0 && sonuc < 100000)
                {
                    label4.Text = "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "%" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                }
                else
                {
                    label4.Text = "=" + Convert.ToString(sonuc);
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "%" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc);
                }
            }
            else if (label2.Text == "Ekok")
            {
                // burada hem istenilen(ekok) işlemini yapıyor ve romen rakamları için en başta tanımladığımız fonksiyonu çağırıyor
                //hem de bu sonuçalrı hem ekrana hem de geçmiş ksımına yazdırıyor.
                int max = Convert.ToInt32(label1.Text) * Convert.ToInt32(label3.Text);
                int ekok = 0;
                //burda ekok işlemini yapıyor
                for (int i = max; i > 0; i--)
                {
                    if (i % Convert.ToInt32(label1.Text) == 0 && i % Convert.ToInt32(label3.Text) == 0)
                    {
                        ekok = i;
                    }
                }
                int sonuc = ekok;
                //burda ise 4 basamaklı sınırını kontrol ediyor
                if (sonuc > 0 && sonuc < 10000)
                {
                    label4.Text = "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "Ekok" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                }
                else
                {
                    label4.Text = "=" + Convert.ToString(sonuc);
                    label5.Text += "\n" + Convert.ToDouble(label1.Text) + "Ekok" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(sonuc);
                }
            }
            else if (label2.Text == "Ebob")
            {
              
                // burada hem istenilen(ebob) işlemini yapıyor ve romen rakamları için en başta tanımladığımız fonksiyonu çağırıyor
                //hem de bu sonuçalrı hem ekrana hem de geçmiş ksımına yazdırıyor.
                int a = Convert.ToInt32(label1.Text);
                int b = Convert.ToInt32(label3.Text);
                //burda ekok işlemini yapıyor

                    while (b != 0)
                    {
                        int temp = b;
                        b = a % b;
                        a = temp;
                    }
                    //burda ise 4 basamaklı sınırını kontrol ediyor
                    if (a > 0 && a < 10000)
                    {
                        label4.Text = "=" + Convert.ToString(a) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(a))) + ")";
                        label5.Text += "\n" + Convert.ToDouble(label1.Text) + "-" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(a) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(a))) + ")";
                    }
                    else
                    {
                        label4.Text = "=" + Convert.ToString(a);
                        label5.Text += "\n" + Convert.ToDouble(label1.Text) + "Ekok" + Convert.ToDouble(label3.Text) + "=" + Convert.ToString(a);
                    }
                

            }
            else if (label2.Text == "√")
            {
                // burada hem istenilen(ebob) işlemini yapıyor ve romen rakamları için en başta tanımladığımız fonksiyonu çağırıyor
                //hem de bu sonuçalrı hem ekrana hem de geçmiş ksımına yazdırıyor.
                double sonuc = Math.Sqrt(Convert.ToDouble(label1.Text));
                //burda ise 4 basamaklı sınırını kontrol ediyor
                if (sonuc > 0 && sonuc < 10000)
                {
                    label4.Text = "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                    label5.Text += "\n" + "√" + Convert.ToDouble(label1.Text) + "=" + Convert.ToString(sonuc) + "(" + Convert.ToString(SayiToRoma(Convert.ToInt32(sonuc))) + ")";
                }
                else
                {
                    label4.Text = "=" + Convert.ToString(sonuc);
                    label5.Text += "\n" + "√" + Convert.ToDouble(label1.Text) + " = " + Convert.ToString(sonuc);
                }
            }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            //birinci sayı yeri boşsa ve "," koymaya çalışılırsa hata verir
            if (string.IsNullOrEmpty(label1.Text))
            {
                DialogResult sonuc = MessageBox.Show("Önce sayıyı giriniz.", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
               );
              
            }
            //burada ise ebob ile ekokta ondalık sayı yazmaya çalışılırsa uyarı veriyor.
            else if(label2.Text=="Ebob" || label2.Text == "Ekok")
            {
                DialogResult sonuc = MessageBox.Show("Ebob veya Ekok işlemlerinde ondalıklı sayı kullanılamaz", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
            
           else 
            {
                // ilk sayı yerinde tam sayı varsa "," koyabilmek için
                if (string.IsNullOrEmpty(label2.Text))
                {
                    label1.Text += ",";
                    //burada ise ilk işleme birden fazla "," koymayı engellemek içindir
                    button23.Enabled = false;
                }
                //ikinci sayı yeri noşsa ve "," koymaya çalışılırsa hata verir
                else if (string.IsNullOrEmpty(label3.Text))
                {
                        DialogResult sonuc = MessageBox.Show("Önce sayıyı giriniz.", "Bilgilendirme",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                      );
                    
                }
                // ilk sayı yerinde tam sayı varsa "," koyabilmek için
                else
                {
                    label3.Text += ",";
                    //burada ise ilk sayı yerinde birden fazla "," koymayı engellemek içindir
                    button23.Enabled = false;
                }
            }
            // burada koyulan tum enabled lar işleme devam edebilmek için işlemi ekrana yazdıran ve eşittir tuşu kısmında
            // true şeklinde tanımlanmıştır
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //burada girilen sayıların işaretleri değiştiriliyor
           
            if (string.IsNullOrEmpty(label1.Text) )
            {
                DialogResult sonuc = MessageBox.Show("Önce birinci sayıyı giriniz.", "Bilgilendirme",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                      );
            }
           
            else if (string.IsNullOrEmpty(label2.Text))
            {
                int s = Convert.ToInt32(label1.Text) * -1;
                label1.Text = Convert.ToString(s);
            }
            else if (string.IsNullOrEmpty(label3.Text))
            {
                DialogResult sonuc = MessageBox.Show("Önce ikinci sayıyı giriniz.", "Bilgilendirme",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                      );
            }
            else
            {
                int s = Convert.ToInt32(label3.Text) * -1;
                label3.Text = Convert.ToString(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //burada tek karakter silme yapılıyor
            if (label1.Text.Length > 0)
            {
                //ilk sayı kısmında hiç karakter kalmayana kadar siliyor
                if (string.IsNullOrEmpty(label2.Text))
                {
                    label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);
                }
                //işlem kısmını karakter kalmayana kadar siliyor
                else if (string.IsNullOrEmpty(label3.Text))
                {
                    label2.Text = label2.Text.Remove(label2.Text.Length - 1, 1);
                }
                //ikinci sayı kısmında hiç karakter kalmayana kadar siliyor
                else
                {
                    label3.Text = label3.Text.Remove(label3.Text.Length - 1, 1);
                }
            }
            //eğer ekranda hiç karakter kalmadıysa bilgi geçiyor.
            else
            {
                DialogResult sonuc = MessageBox.Show("Silinecek sayı yok", "Bilgilendirme",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
               );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // burada bulunduğu kısımdaki tüm karakterleri siliyor
            //bu kısım ilk sayı kısmı için
            if (string.IsNullOrEmpty(label2.Text))
            {
                label1.Text = string.Empty;
            }
            //burası işlem kısmı için
            else if(string.IsNullOrEmpty(label3.Text))
            {
                label2.Text = string.Empty;
            }
            //burası ikinci sayı yeri için
            else
            {
                label3.Text = string.Empty;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buradaki tuşa bastığımızda hesap makinesinde ekrana yazdırılan her yer siliniyor
            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label3.Text = string.Empty;
            label4.Text = string.Empty;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            // burada tuşa bastığımızda geçmiş listesi görünür hale geliyor
            label5.Visible=true;
        }
    }
}
