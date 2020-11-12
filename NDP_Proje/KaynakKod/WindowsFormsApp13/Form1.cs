/****************************************************************************
**					       SAKARYA ÜNİVERSİTESİ
**				 BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					      2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:PROJE ÖDEVİ
**				ÖĞRENCİ ADI............:MERVE SARI
**				ÖĞRENCİ NUMARASI.......:B181210074  
**              DERSİN ALINDIĞI GRUP...:1C
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
using System.Media;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public int gecenSure = 0;
        public int kasa = 0;

        SoundPlayer player = new SoundPlayer();

        interface IFiyat
        {
            int fiyat(int x); //Her hayvanın ürününün fiyatının hespalanması için fonksiyon      
        }

        public abstract class Canli
        {
            public int yemAzalt(int x, int azalmaMiktari) //Her hayvanın canını azaltmak için fonksiyon
            {
                x -= azalmaMiktari;
                return x;
            }
        }
        public class Tavuk : Canli,IFiyat
        {
            public int yumurtaMiktari = 0;
            public int satilanYumurta = 0;
            public int tavukSes = 0;

            public int fiyat(int x) //Tavuk yumurtası satmak için fonksiyon
            {
                return x * 1;
            }
        }
        public class Ordek : Canli,IFiyat
        {
            public int yumurtaMiktari = 0;
            public int satilanYumurta = 0;
            public int ordekSes = 0;

            public int fiyat(int x) //Ördek yumurtası satmak için fonksiyon
            {
                return x * 3;
            }
        }
        public class Inek : Canli,IFiyat
        {
            public int sutMiktari = 0;
            public int satilanSut = 0;
            public int inekSes = 0;

            public int fiyat(int x) //İnek sütü satmak için fonksiyon
            {
                return x * 5;
            }
        }
        public class Keci : Canli,IFiyat
        {
            public int sutMiktari = 0;
            public int satilanSut = 0;
            public int keciSes = 0;

            public int fiyat(int x) //Keçi sütü satmak için fonksiyon
            {
                return x * 8;
            }
        }

        Tavuk t1 = new Tavuk();
        Ordek o1 = new Ordek();
        Inek i1 = new Inek();
        Keci k1 = new Keci();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void label21_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gecenSure = gecenSure + 1;
            label19.Text = gecenSure + " SN";

            //TAVUK KODLARI BAŞLANGIÇ
            if (progressBar1.Value > 2) //Tavuk canı ikiden büyükse her saniye 2 birim can azalt
            {
                progressBar1.Value = t1.yemAzalt(progressBar1.Value, 2);
            }
            else
            {
                t1.tavukSes++;
                if (t1.tavukSes == 1)  //Tavuk ölürken bir kere ses çalması için koşul 
                {
                    player.SoundLocation = @"C:\Users\Merve\Desktop\OOP\ÖDEVLER\Proje\tavuk.wav";
                    player.Play();
                }
                
                progressBar1.Value = 0;
                label11.Text = "ÖLDÜ";
                button5.Enabled = false;
            }

            if (gecenSure % 3 == 0)  //3 saniyede bir tavuk yumurtası üretmek için koşul
            {
                if (button5.Enabled == true) //Tavuk ölmediyse buton aktiftir. Buton aktifse yumurta miktarını arttır.
                {
                    t1.yumurtaMiktari++;
                }
            }
            label15.Text = Convert.ToString(t1.yumurtaMiktari) + " ADET";
            //TAVUK KODLARI BİTİŞ

            //ÖRDEK KODLARI BAŞLANGIÇ
            if (progressBar2.Value > 1)  //Ördek canı birden büyükse her saniye 3 birim can azalt
            {
                progressBar2.Value = o1.yemAzalt(progressBar2.Value, 3);
            }
            else
            {
                o1.ordekSes++;
                if (o1.ordekSes == 1) //Ördek ölürken bir kere ses çalması için koşul 
                {
                    player.SoundLocation = @"C:\Users\Merve\Desktop\OOP\ÖDEVLER\Proje\ordek.wav";
                    player.Play();
                }

                progressBar2.Value = 0;
                label12.Text = "ÖLDÜ";
                button6.Enabled = false;
            }

            if (gecenSure % 5 == 0) //5 saniyede bir ördek yumurtası üretmek için koşul
            {
                if (button6.Enabled == true) //Ördek ölmediyse buton aktiftir. Buton aktifse yumurta miktarını arttır.
                {
                    o1.yumurtaMiktari++;
                }
            }
            label17.Text = Convert.ToString(o1.yumurtaMiktari) + " ADET";
            //ÖRDEK KODLARI BİTİŞ

            //İNEK KODLARI BAŞLANGIÇ
            if (progressBar3.Value > 4)  //İnek canı dörtten büyükse her saniye 8 birim can azalt
            {
                progressBar3.Value = i1.yemAzalt(progressBar3.Value, 8);
            }
            else
            {
                i1.inekSes++;
                if (i1.inekSes == 1)  //İnek ölürken bir kere ses çalması için koşul 
                {
                    player.SoundLocation = @"C:\Users\Merve\Desktop\OOP\ÖDEVLER\Proje\inek.wav";
                    player.Play();
                }
                progressBar3.Value = 0;
                label13.Text = "ÖLDÜ";
                button7.Enabled = false;
            }

            if (gecenSure % 8 == 0)  //8 saniyede bir süt üretmesi için koşul
            {
                if (button7.Enabled == true) //İnek ölmediyse buton aktiftir. Buton aktifse süt miktarını arttır.
                {
                    i1.sutMiktari++;
                }
            }
            label16.Text = Convert.ToString(i1.sutMiktari) + " KG";
            //İNEK KODLARI BİTİŞ

            //KEÇİ KODLARI BAŞLANGIÇ
            if (progressBar4.Value > 4)  //Keçi canı dörtten büyükse her saniye 6 birim can azalt
            {
                progressBar4.Value = k1.yemAzalt(progressBar4.Value, 6);
            }
            else
            {
                k1.keciSes++;
                if (k1.keciSes == 1)  //Keçi ölürken bir kere ses çalması için koşul 
                {
                    player.SoundLocation = @"C:\Users\Merve\Desktop\OOP\ÖDEVLER\Proje\keci.wav";
                    player.Play();
                }
                progressBar4.Value = 0;
                label14.Text = "ÖLDÜ";
                button8.Enabled = false;
            }

            if (gecenSure % 7 == 0) //7 saniyede bir süt üretmek için koşul
            {
                if (button8.Enabled == true) //Keçi ölmediyse buton aktiftir. Buton aktifse süt miktarını arttır.
                {
                    k1.sutMiktari++;
                }
            }
            label18.Text = Convert.ToString(k1.sutMiktari) + " KG";
            //KEÇİ KODLARI BİTİŞ

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        public void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0 || progressBar1.Value < 100) //ProgressBarın değeri sıfırdan büyükse butona basılınca değerini 100 yap
            {
                progressBar1.Value = 100;
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1.satilanYumurta = t1.yumurtaMiktari;
            t1.yumurtaMiktari = 0;
            kasa = kasa + t1.fiyat(t1.satilanYumurta);     
            label20.Text = Convert.ToString(kasa) + " TL";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            o1.satilanYumurta = o1.yumurtaMiktari;
            o1.yumurtaMiktari = 0;
            kasa = kasa + o1.fiyat(o1.satilanYumurta);
            label20.Text = Convert.ToString(kasa) + " TL";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (progressBar2.Value > 0 || progressBar2.Value < 100) //ProgressBarın değeri sıfırdan büyükse butona basılınca değerini 100 yap
            {
                progressBar2.Value = 100;
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (progressBar3.Value > 0 || progressBar3.Value < 100) //ProgressBarın değeri sıfırdan büyükse butona basılınca değerini 100 yap
            {
                progressBar3.Value = 100;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            i1.satilanSut = i1.sutMiktari;
            i1.sutMiktari = 0;
            kasa = kasa + i1.fiyat(i1.satilanSut);
            label20.Text = Convert.ToString(kasa) + " TL";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (progressBar4.Value > 0 || progressBar4.Value < 100) //ProgressBarın değeri sıfırdan büyükse butona basılınca değerini 100 yap
            {
                progressBar4.Value = 100;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            k1.satilanSut = k1.sutMiktari;
            k1.sutMiktari = 0;
            kasa = kasa + k1.fiyat(k1.satilanSut);
            label20.Text = Convert.ToString(kasa) + " TL";
        }
    }
}
