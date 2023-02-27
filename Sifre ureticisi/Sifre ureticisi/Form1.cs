using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifre_ureticisi
{
    

    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
        }

        string harf(int harfNumara, string sifre, int karakter, int i,Random random)
        {
           

            int x;
            char c;



            // harf
            if (harfNumara == 0)
            {
                x = random.Next(97, 123);
                c = (char)x;

                sifre += c.ToString();
                //txtSifre.Text = c.ToString();


            }
            else if (harfNumara == 1)
            {
                x = random.Next(65, 91);
                c = (char)x;

                sifre += c.ToString();
            }
            else if (harfNumara == 2)
            {
                if(i==0)
                {
                    x = random.Next(65, 91);
                    c = (char)x;

                }
                else
                {
                    x = random.Next(97, 123);
                    c = (char)x;
                }

                sifre += c.ToString();

               
            }
            else if (harfNumara == 3)
            {


                if (i == karakter - 1)
                {
                    x = random.Next(65, 91);
                    c = (char)x;

                    sifre += c.ToString();
                }
                else
                {
                    x = random.Next(97, 123);
                    c = (char)x;

                    sifre += c.ToString();
                }

            }
            else //if (harfNumara == 4)
            {
                int zek = random.Next(0, 2);

                if (zek == 0)  //büyük
                {
                    x = random.Next(65, 91);
                    c = (char)x;

                    sifre += c.ToString();

                }
                else   //küçük
                {
                    x = random.Next(97, 123);
                    c = (char)x;

                    sifre += c.ToString();
                }
            }

            return sifre;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTip.Text == "Harf ve Sayı"|| cmbTip.Text == "Harf, Sayı ve Özel Karakter"|| cmbTip.Text== "Sadece Harf"|| cmbTip.Text== "Harf ve Özel Karakter")
            {
                txtHarfTercih.Enabled = true;
                cmbBuyukHarf.Enabled = true;
            }
            else
            {
                txtHarfTercih.Enabled = false;
                cmbBuyukHarf.Enabled = false;
            }

           
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            /*
            Harf ve Sayı
            Harf ve Özel Karakter
            Sayı ve Özel Karakter
            Harf, Sayı ve Özel Karakter
            Sadece Sayı
            Sadece Harf
            Sadece Özel Karakter
            */

            /*
             *  Harflerin Hepsi Küçük
                Harflerin Hepsi Büyük
                Sadece Baştaki Harf Büyük
                Sadece Sondaki Harf Büyük
                Büyük/Küçük Harf Karışık
             */

            
            int karakter = Convert.ToInt32(numSifreKarakter.Text);

            if(karakter==0)
            {
                MessageBox.Show("Lütfen Şifre Karakter Sayısını Giriniz", "Şifre Üreticisi");
            }
            
            int harfNumara;

            if(cmbBuyukHarf.Text== "Harflerin Hepsi Küçük")
            {
                harfNumara = 0;
            }
            else if(cmbBuyukHarf.Text == "Harflerin Hepsi Büyük")
            {
                harfNumara = 1;
            }
            else if (cmbBuyukHarf.Text == "Sadece Baştaki Harf Büyük")
            {
                harfNumara = 2;
            }
            else if (cmbBuyukHarf.Text == "Sadece Sondaki Harf Büyük")
            {
                harfNumara = 3;
            }
            else //(cmbBuyukHarf.Text == "Büyük/Küçük Harf Karışık")
            {
                harfNumara = 4;
            }


            
            Random random = new Random();
            Random random1=new Random();
            Random random3 = new Random();
            Random rastgele=new Random();

            string sifre="";

            int[] dizi = { 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 58, 59, 60, 61, 62, 63, 64, 91, 92, 93, 94, 95, 123, 124, 125, 126 };


            if (cmbBuyukHarf.Enabled == true && cmbBuyukHarf.Text.Length == 0)
            {
                MessageBox.Show("Lütfen Büyük/Küçük Harf Tercihi Yapınız", "Şifre Üreticisi");
            }
            else
            {
                if (cmbTip.Text == "Harf ve Sayı")
                {


                    for (int i = 0; i < karakter; i++)
                    {
                        int z = rastgele.Next(0, 2);

                        if (i == 0 && harfNumara == 2)
                        {
                            z = 0;
                        }

                        if (i == karakter - 1 && harfNumara == 3)
                        {

                            z = 0;
                        }

                        if (z == 0)
                        {


                            sifre = harf(harfNumara, sifre, karakter, i, random);


                        }
                        else
                        {
                            // sayi
                            int y = random1.Next(0, 10);

                            sifre += y.ToString();
                        }



                    }


                    txtSifre.Text = sifre;

                }
                else if (cmbTip.Text == "Harf ve Özel Karakter")
                {

                    char ch;
                    for (int i = 0; i < karakter; i++)
                    {
                        int z = rastgele.Next(0, 2);

                        if (i == 0 && harfNumara == 2)
                        {
                            z = 0;
                        }

                        if (i == karakter - 1 && harfNumara == 3)
                        {

                            z = 0;
                        }

                        if (z == 0)
                        {
                            sifre = harf(harfNumara, sifre, karakter, i, random);

                        }
                        else  // özel karakter
                        {
                            int rast1 = random3.Next(0, 31);

                            ch = (char)dizi[rast1];

                            sifre += ch.ToString();
                        }

                    }


                    txtSifre.Text = sifre;

                }
                else if (cmbTip.Text == "Sayı ve Özel Karakter")
                {
                    char c;

                    for (int i = 0; i < karakter; i++)
                    {
                        int z = rastgele.Next(0, 2);

                        if (z == 0)  // sayı
                        {
                            int y = random1.Next(0, 10);

                            sifre += y.ToString();
                        }
                        else  // özel karakter
                        {
                            int rast1 = random3.Next(0, 31);

                            c = (char)dizi[rast1];

                            sifre += c.ToString();
                        }



                    }

                    txtSifre.Text = sifre;
                }
                else if (cmbTip.Text == "Harf, Sayı ve Özel Karakter")
                {
                    char c;

                    for (int i = 0; i < karakter; i++)
                    {
                        int z = rastgele.Next(0, 3);

                        if (i == 0 && harfNumara == 2)
                        {
                            z = 0;
                        }

                        if (i == karakter - 1 && harfNumara == 3)
                        {

                            z = 0;
                        }


                        if (z == 0)  // harf
                        {

                            sifre = harf(harfNumara, sifre, karakter, i, random);


                        }
                        else if (z == 1) // özel karakter
                        {
                            int rast1 = random3.Next(0, 31);

                            c = (char)dizi[rast1];

                            sifre += c.ToString();
                        }
                        else  // sayı
                        {
                            int y = random1.Next(0, 10);

                            sifre += y.ToString();
                        }



                    }

                    txtSifre.Text = sifre;
                }
                else if (cmbTip.Text == "Sadece Sayı")
                {
                    for (int i = 0; i < karakter; i++)
                    {
                        int y = random1.Next(0, 10);

                        sifre += y.ToString();
                    }

                    txtSifre.Text = sifre;
                }
                else if (cmbTip.Text == "Sadece Harf")
                {
                    for (int i = 0; i < karakter; i++)
                    {
                        sifre = harf(harfNumara, sifre, karakter, i, random);
                    }

                    txtSifre.Text = sifre;
                }
                else if (cmbTip.Text == "Sadece Özel Karakter")
                {


                    char c;




                    for (int i = 0; i < karakter; i++)
                    {
                        int rast1 = random3.Next(0, 31);

                        c = (char)dizi[rast1];

                        sifre += c.ToString();


                    }

                    txtSifre.Text = sifre;
                }

            }





        }

        private void cmbTip_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if(txtSifre.Text.Length > 0)
            {
                Clipboard.SetText(txtSifre.Text);
            }


            
        }

        private void cmbBuyukHarf_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if(cmbBuyukHarf.Text.Length==0)
            {
                
            }

            */
        }

        private void btnBanaBirak_Click(object sender, EventArgs e)
        {
           

        }

        private void lstSifreler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lstSifreler
        }
    }
}
