/****************************************************************************
**                           SAKARYA ÜNİVERSİTESİ
**                  BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**                    BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
**                       NESNEYE DAYALI PROGRAMLAMA DERSİ
**                           2019-2020 BAHAR DÖNEMİ
**
**                    ÖDEV NUMARASI..........: 1
**                    ÖĞRENCİ ADI............: Liva Nur PULAT
**                    ÖĞRENCİ NUMARASI.......: B191200371
**                    DERSİN ALINDIĞI GRUP...: A
****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinemabiletsatış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int seans1kişi = 0;
        int seans1ücret = 0;
        int seans2kişi = 0;
        int seans2ücret = 0;
        int seans3kişi = 0;
        int seans3ücret = 0;
        int seans4kişi = 0;
        int seans4ücret = 0;
        int seans5kişi = 0;
        int seans5ücret = 0;
        int seans6kişi = 0;
        int seans6ücret = 0;
        int mısır = 0;
        int mısırücret = 0;
        int kola = 0;
        int kolaücret = 0;
        int msuyu = 0;
        int msuyuücret = 0;
        int su = 0;
        int suücret = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            seans1kişi++;
            seans1ücret = seans1ücret + 8;
            textBox1.Text = seans1kişi.ToString();
            textBox2.Text = seans1ücret.ToString();

            //her bir seans 20 kişilik salonlardadır. 20 kişiye ulaştığında daha fazla artırılmasını engellemek için bu koşulu kullandım.//
            if (seans1kişi == 20)
            {
                button1.Enabled = false;
            }
            //kişi sayısı 0'a eşit veya büyükse buton2'yi('-' butonu) etkinleştirmesi için bu koşulu kullandım.//
            if (seans1kişi >= 0)
            {
                button2.Enabled = true;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            seans1kişi--;
            seans1ücret = seans1ücret - 8;
            textBox1.Text = seans1kişi.ToString();
            textBox2.Text = seans1ücret.ToString();

            //kişi sayısı 0 ise buton2'nin etkinliğini durdursun, yani sayı eksilere(-1,-2...) düşmesin diye bu koşulu kullandım.//
            if (seans1kişi == 0)
            {
                button2.Enabled = false;
            }
            //buton2 koşulunda buton 1'i aktifleştirmek için bu koşulu kullandım.//
            if (seans1kişi <= 20)
            {
                button1.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            seans2kişi++;
            seans2ücret = seans2ücret + 8;
            textBox3.Text = seans2kişi.ToString();
            textBox4.Text = seans2ücret.ToString();

            if (seans2kişi == 20)
            {
                button3.Enabled = false;
            }
            if (seans2kişi >= 0)
            {
                button4.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seans2kişi--;
            seans2ücret = seans2ücret - 8;
            textBox3.Text = seans2kişi.ToString();
            textBox4.Text = seans2ücret.ToString();

            if (seans2kişi == 0)
            {
                button4.Enabled = false;
            }
            if (seans2kişi <= 20)
            {
                button3.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seans3kişi++;
            seans3ücret = seans3ücret + 8;
            textBox5.Text = seans3kişi.ToString();
            textBox6.Text = seans3ücret.ToString();

            if (seans3kişi == 20)
            {
                button5.Enabled = false;
            }
            if (seans3kişi >= 0)
            {
                button6.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seans3kişi--;
            seans3ücret = seans3ücret - 8;
            textBox5.Text = seans3kişi.ToString();
            textBox6.Text = seans3ücret.ToString();

            if (seans3kişi == 0)
            {
                button6.Enabled = false;
            }
            if (seans3kişi <= 20)
            {
                button5.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            seans4kişi++;
            seans4ücret = seans4ücret + 8;
            textBox7.Text = seans4kişi.ToString();
            textBox8.Text = seans4ücret.ToString();

            if (seans4kişi == 20)
            {
                button7.Enabled = false;
            }
            if (seans4kişi >= 0)
            {
                button8.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            seans4kişi--;
            seans4ücret = seans4ücret - 8;
            textBox7.Text = seans4kişi.ToString();
            textBox8.Text = seans4ücret.ToString();

            if (seans4kişi == 0)
            {
                button8.Enabled = false;
            }
            if (seans4kişi <= 20)
            {
                button7.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            seans5kişi++;
            seans5ücret = seans5ücret + 8;
            textBox9.Text = seans5kişi.ToString();
            textBox10.Text = seans5ücret.ToString();

            if (seans5kişi == 20)
            {
                button9.Enabled = false;
            }
            if (seans5kişi >= 0)
            {
                button10.Enabled = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            seans5kişi--;
            seans5ücret = seans5ücret - 8;
            textBox9.Text = seans5kişi.ToString();
            textBox10.Text = seans5ücret.ToString();

            if (seans5kişi == 0)
            {
                button10.Enabled = false;
            }
            if (seans5kişi <= 20)
            {
                button9.Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            seans6kişi++;
            seans6ücret = seans6ücret + 8;
            textBox11.Text = seans6kişi.ToString();
            textBox12.Text = seans6ücret.ToString();

            if (seans6kişi == 20)
            {
                button11.Enabled = false;
            }
            if (seans6kişi >= 0)
            {
                button12.Enabled = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            seans6kişi--;
            seans6ücret = seans6ücret - 8;
            textBox11.Text = seans6kişi.ToString();
            textBox12.Text = seans6ücret.ToString();

            if (seans6kişi == 0)
            {
                button12.Enabled = false;
            }
            if (seans6kişi <= 20)
            {
                button11.Enabled = true;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            mısır++;
            mısırücret = mısırücret + 7;
            textBox13.Text = mısır.ToString();
            textBox14.Text = mısırücret.ToString();

            //eksi butonunda(buton14) yazdığım koşul uygulandığında sayı arttığında tekrar aktifleşmesi için artı butonunda eksi butonunu etkinleştirdim.//
            if (mısır > 0)
            {
                button14.Enabled = true;
            }

        }


        private void button14_Click(object sender, EventArgs e)
        {
            mısır--;
            mısırücret = mısırücret - 7;
            textBox13.Text = mısır.ToString();
            textBox14.Text = mısırücret.ToString();

            //sayının eksilere düşmesini engellemek için bu koşulu yazdım.//
            if(mısır == 0)
            {
                button14.Enabled = false;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            kola++;
            kolaücret = kolaücret + 3;
            textBox15.Text = kola.ToString();
            textBox16.Text = kolaücret.ToString();

            if (kola > 0)
            {
                button16.Enabled = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            kola--;
            kolaücret = kolaücret - 3;
            textBox15.Text = kola.ToString();
            textBox16.Text = kolaücret.ToString();

            if (kola == 0)
            {
                button16.Enabled = false;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            msuyu++;
            msuyuücret = msuyuücret + 3;
            textBox17.Text = msuyu.ToString();
            textBox18.Text = msuyuücret.ToString();

            if (msuyu > 0)
            {
                button18.Enabled = true;
            }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            msuyu--;
            msuyuücret = msuyuücret - 3;
            textBox17.Text = msuyu.ToString();
            textBox18.Text = msuyuücret.ToString();

            if (msuyu == 0)
            {
                button18.Enabled = false;
            }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            su++;
            suücret = suücret + 1;
            textBox19.Text = su.ToString();
            textBox20.Text = suücret.ToString();

            if (su > 0)
            {
                button20.Enabled = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            su--;
            suücret = suücret - 1;
            textBox19.Text = su.ToString();
            textBox20.Text = suücret.ToString();

            if (su == 0)
            {
                button20.Enabled = false;
            }


        }

        private void button21_Click(object sender, EventArgs e)
        {
            int toplamizleyici, toplamücret;
            int toplamürün, toplamfiyat;
            int geneltoplam;

            toplamizleyici = seans1kişi + seans2kişi + seans3kişi + seans4kişi + seans5kişi + seans6kişi ;
            label20.Text = toplamizleyici.ToString() ;
            
            toplamücret = seans1ücret + seans2ücret + seans3ücret + seans4ücret + seans5ücret + seans6ücret;
            label21.Text = toplamücret.ToString() + "TL" ;

            toplamürün = mısır + kola + msuyu + su;
            label22.Text = toplamürün.ToString() ;

            toplamfiyat = mısırücret + kolaücret + msuyuücret + suücret;
            label23.Text = toplamfiyat.ToString() + "TL" ;

            geneltoplam = toplamücret + toplamfiyat;
            label26.Text = geneltoplam.ToString() + "TL" ;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
