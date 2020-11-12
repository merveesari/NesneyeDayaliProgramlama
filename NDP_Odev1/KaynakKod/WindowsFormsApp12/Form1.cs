/****************************************************************************
**					       SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				      BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				     NESNEYE DAYALI PROGRAMLAMA DERSİ
**					      2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:1
**				ÖĞRENCİ ADI............:Merve Sarı
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

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] satirlar;
        public string hepsi;
        public string[] kelimeler;
        public double gelirVergisi;
        public double bürütMaas;
        public double damgaVergisi;
        public double emekliKesintisi;
        public double netMaas;
        public double esYardimi;


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            //Dosya açma kodu
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.ShowDialog();
            richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //Yeni girilecek tc için listBox temizlenir
            //Çalışanlar ile ilgili bilgilerin diziye atılması
            string[] bilgiler = { "TC: ", "Adı: ", "Soyadı: ", "Yaş: ", "Çalışma Süresi: ", "Evlilik Durumu: ", "Eşi Çalışıyor Mu?: ", "Çocuk Sayısı: ", "Taban Maaş: ", "Makam Tazminatı: ", "İdari Görev Tazminatı: ", "Fazla Mesai Saati: ", "Fazla Mesai Saati Ücreti: ", "Vergi Matrahı: ", "Personel Resmi Yolu: ", "Net Maaş: " };  

            hepsi = richTextBox1.Text;
            satirlar = hepsi.Split('\n'); //Dosya satırlara ayrılır.
            foreach (string s in satirlar) 
            {
                kelimeler = s.Split(' '); //Boşluğa göre değerler diziye atanır.
                for (int i = 0; i < kelimeler.Length; i++)
                {
                    if (kelimeler[i] == textBox1.Text) //Girilen tc çalışanlardan herhangi birine ait mi?
                    {
                        for (int j = 0; j < 15; j++) //Çalışan bilgilerinin yazdırılması için döngü
                        {
                            listBox1.Items.Add(bilgiler[j] + kelimeler[j]); 
                            MaasHesapla();  //Maaş hesaplama fonksiyonu çağrılır.
                            pictureBox1.LoadAsync(kelimeler[14]); //Textteki resim yoluna göre picturBox'a fotoğraf eklenir.
                        }    
                    }
                }
            }
        }
        public void MaasHesapla()
        {
            //Verilen koşullara göre bürüt maaş, damga vergisi, vergi matrahı, emekli kesintisi ve net maaş hesaplamaları
            if (kelimeler[5] == "B") //Çalışan bekar ise 
            {
                bürütMaas = Convert.ToDouble(kelimeler[8]) + Convert.ToDouble(kelimeler[9]) + Convert.ToDouble(kelimeler[10]) + Convert.ToInt32(kelimeler[7]) * 30 + Convert.ToDouble(kelimeler[11]) * Convert.ToDouble(kelimeler[12]);
                textBox3.Text = bürütMaas.ToString(); 
                damgaVergisi = (bürütMaas * 10) / 100;
                textBox4.Text = damgaVergisi.ToString();
                vergiMatrahiHesapla();
                textBox5.Text = gelirVergisi.ToString();
                emekliKesintisi = (bürütMaas * 15) / 100;
                textBox6.Text = emekliKesintisi.ToString();
                netMaas = bürütMaas - (emekliKesintisi + gelirVergisi + damgaVergisi);
                textBox2.Text = netMaas.ToString();
            }
            else if (kelimeler[5] == "E" && kelimeler[6] == "E") //Çalışan evli ve eşi çalışıyor ise
            {
                bürütMaas = Convert.ToDouble(kelimeler[8]) + Convert.ToDouble(kelimeler[9]) + Convert.ToDouble(kelimeler[10]) + Convert.ToInt32(kelimeler[7]) * 30 + Convert.ToDouble(kelimeler[11]) * Convert.ToDouble(kelimeler[12]);
                textBox3.Text = bürütMaas.ToString();
                damgaVergisi = (bürütMaas * 10) / 100;
                textBox4.Text = damgaVergisi.ToString();
                vergiMatrahiHesapla();
                textBox5.Text = gelirVergisi.ToString();
                emekliKesintisi = (bürütMaas * 15) / 100;
                textBox6.Text = emekliKesintisi.ToString();
                netMaas = bürütMaas - (emekliKesintisi + gelirVergisi + damgaVergisi);
                textBox2.Text = netMaas.ToString();
            }
            else //Çalışan evli ve eşi çalışmıyor ise
            {
                bürütMaas = Convert.ToDouble(kelimeler[8]) + Convert.ToDouble(kelimeler[9]) + Convert.ToDouble(kelimeler[10]) + esYardimi + Convert.ToInt32(kelimeler[7]) * 30 + Convert.ToDouble(kelimeler[11]) * Convert.ToDouble(kelimeler[12]);
                textBox3.Text = bürütMaas.ToString();
                damgaVergisi = (bürütMaas * 10) / 100;
                textBox4.Text = damgaVergisi.ToString();
                vergiMatrahiHesapla();
                textBox5.Text = gelirVergisi.ToString();
                emekliKesintisi = (bürütMaas * 15) / 100;
                textBox6.Text = emekliKesintisi.ToString();
                netMaas = bürütMaas - (emekliKesintisi + gelirVergisi + damgaVergisi);
                textBox2.Text = netMaas.ToString();
            }

        }
        private void vergiMatrahiHesapla() //Verilen koşullar ile vergi matrahının hesaplanması
        {
            if (Convert.ToDouble(kelimeler[8]) < 10000) //Gelir matrahı  10000 TL den küçük ise  
            {
                gelirVergisi = (bürütMaas * 15) / 100;
            }
            else if (Convert.ToDouble(kelimeler[8]) >= 10000 && Convert.ToDouble(kelimeler[8]) < 20000) //Gelir matrahı  10000 TL den büyük eşit ve 20000 TL küçük ise
            {
                gelirVergisi = (bürütMaas * 20) / 100;
            }
            else if (Convert.ToDouble(kelimeler[8]) >= 20000 && Convert.ToDouble(kelimeler[8]) < 30000) //Gelir matrahı  20000 TL den büyük eşit ve 30000 TL küçük ise  
            {
                gelirVergisi = (bürütMaas * 25) / 100;
            }
            else //gelir matrahı  30000 TL den büyük eşit ise
            {
                gelirVergisi = (bürütMaas * 30) / 100;
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}