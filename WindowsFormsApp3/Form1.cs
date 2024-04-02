using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp3
{
    public partial class Form1 : MaterialForm
    {
        //login değerlri
        string cname = "yusuf",cpass = "yusuf",iname,ipass;
        int dhak = 4;
        // login değerleri son
        //
        //toplama ve çıkarma değerleri
        char islem;
        int sayı1, sayı2,sonuc;
        //toplama ve çıkarma değerleri son
        //
        //oyun1 değerleri
        int puan;
        string katlayici = "1";
        //oyun1 değerleri son
        //
        //birim dönüştürücü değerleri
        string birim1, birim2;
        double girdi,euro,dolar,yuvdolartr,yuveurotr;
        int factorial;
        //
        string from, to;
        //bunlar son
        //
        //Ürün fiyat hesaplayıcı değerleri
        double urunmiktar, urunfiyat, kasafiyat,indirimyuzde,indirimsizfiyat,indirimmiktar;
        char biralanabirbedava = 'f';
        
       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (puan >= 5000)
            {
                MessageBox.Show("Oyunu Kazandın!");
                panel3.BackColor = Color.Green;
                panel3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Yetersiz Puanın var.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
        Random rastgele = new Random();
        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zar:" + rastgele.Next(1, 7));
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            panel5.BackColor = Color.Green;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100) 
            { 
                progressBar1.Value = progressBar1.Value + 10;
            }
            else
            {
                MessageBox.Show("hackleme tamamlandı :)");
                
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
        }

        public void button15_Click(object sender, EventArgs e)
        {
            
            
            
            
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            iname = richTextBox1.Text;
            ipass = richTextBox2.Text;

            if (dhak == 0)
            {
                MessageBox.Show("Deneme hakkınız bitmiştir.");
                panel1.Enabled = false;
            }
            else if (iname == cname && ipass == cpass && dhak > 0)
            {
                MessageBox.Show("Başarılı giriş");
                panel1.Enabled = false;
            }
            else
            {

                MessageBox.Show("Başarısız giriş." + dhak + " tane deneme hakkınız kalmıştır.");
                dhak--;
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            try
            {
                sayı1 = Convert.ToInt32(richTextBox3.Text);
                sayı2 = Convert.ToInt32(richTextBox4.Text);
                switch (islem)
                {
                    case '+':
                        sonuc = sayı1 + sayı2;
                        break;
                    case '-':
                        sonuc = sayı1 - sayı2;
                        break;
                    case 'x':
                        sonuc = sayı1 * sayı2;
                        break;
                    case '/':
                        sonuc = sayı1 / sayı2;
                        break;
                    case 'u':
                        sonuc = Convert.ToInt32(Math.Pow(sayı1, sayı2));
                        break;
                    case 'f':
                        factorial = sayı1;
                        for (int i = sayı1 - 1; i >= 1; i--)
                        {
                            factorial = factorial * i;
                        }
                        sonuc = factorial;
                        break;
                    
                }
                label4.Text = sonuc.ToString();
                
            }
            catch (Exception hata)
            {
                MessageBox.Show($"Bir hata oluştu. (Hata mesajı: {hata.Message})");
            }
        }

        private void materialRaisedButton3_Click(object sender, EventArgs e)
        {
            puan = Convert.ToInt32(label6.Text);
            puan = puan + Convert.ToInt32(katlayici);
            label6.Text = puan.ToString();
        }

        private void materialRaisedButton4_Click(object sender, EventArgs e)
        {
            if (puan >= 100)
            {
                puan = puan - 100;
                MessageBox.Show("Artık her tıklaman sana 2 puan kazandıracak.");
                materialRaisedButton3.Text = "+2 Puan";
                katlayici = "2";
                materialRaisedButton4.Enabled = false;
                materialRaisedButton5.Enabled = true;
            }
            else
            {
                MessageBox.Show("Yetersiz Puan.");
            }
        }

        private void materialRaisedButton5_Click(object sender, EventArgs e)
        {
            if (puan >= 500)
            {
                puan = puan - 500;
                MessageBox.Show("Artık her tıklaman sana 10 puan kazandıracak.");
                materialRaisedButton3.Text = "+10 Puan";
                katlayici = "10";
                materialRaisedButton5.Enabled = false;
                materialRaisedButton6.Enabled = true;
            }
            else
            {
                MessageBox.Show("Yetersiz Puan.");
            }
        }

        private void materialRaisedButton6_Click(object sender, EventArgs e)
        {
            if (puan >= 1500)
            {
                puan = puan - 1500;
                MessageBox.Show("Artık her tıklaman sana 50 puan kazandıracak.");
                materialRaisedButton3.Text = "+50 Puan";
                katlayici = "50";
                materialRaisedButton6.Enabled = false;

            }
            else
            {
                MessageBox.Show("Yetersiz Puan.");
            }
        }

        private void materialRaisedButton7_Click(object sender, EventArgs e)
        {
            if (puan >= 5000)
            {
                MessageBox.Show("Oyunu Kazandın!");
                
                panel3.Enabled = false;
            }
            else
            {
                MessageBox.Show("Yetersiz Puanın var.");
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seni gidi hileci al 5000 puan");
            puan = 5000;
            label6.Text = puan.ToString();
        }

        private void materialRaisedButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void materialRaisedButton9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void materialRaisedButton10_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void materialRaisedButton11_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
            }
            else
            {
                MessageBox.Show("hackleme tamamlandı :)");

            }
        }

        private void materialRaisedButton12_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value = progressBar1.Value - 10;
            }
            else
            {
                MessageBox.Show("0'ın altına inemezsin.");
            }
        }

        private void materialRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            birim2 = "dolar";
        }

        private void materialRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            birim2 = "euro";
        }

        public void materialRaisedButton13_Click(object sender, EventArgs e)
        {
            girdi = Convert.ToDouble(materialSingleLineTextField1.Text);
            euro = Convert.ToDouble(materialLabel6.Text);
            dolar = Convert.ToDouble(materialLabel7.Text);
            if (birim1 == "lira" && birim2 == "euro")
            {
                materialLabel5.Text = (girdi / euro).ToString();
            }
            else if (birim1 == "lira" && birim2 == "dolar")
            {
                materialLabel5.Text = (girdi / dolar).ToString();
            }
        }

        private void materialRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "+";
            islem = '+';
        }

        private void materialCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (biralanabirbedava == 'f')
            {
                biralanabirbedava = 't';
            }
            else
            {
                biralanabirbedava = 'f';
            }
        }

        private void materialRaisedButton16_Click(object sender, EventArgs e)
        {
            urunmiktar = Convert.ToDouble(materialSingleLineTextField2.Text);
            urunfiyat = Convert.ToDouble(materialSingleLineTextField3.Text);
            indirimyuzde = Convert.ToDouble(materialSingleLineTextField4.Text);
            if (biralanabirbedava == 't')
            {
                if (urunmiktar % 2 == 0)
                {
                    urunmiktar = Convert.ToInt32(urunmiktar / 2);
                }
                else
                {
                    urunmiktar = Convert.ToInt32(urunmiktar / 2);
                    urunmiktar++;
                }             
            }
            indirimsizfiyat = urunmiktar * urunfiyat;
            indirimmiktar = indirimsizfiyat * (indirimyuzde / 100);
            kasafiyat = indirimsizfiyat - indirimmiktar;
            materialLabel11.Text = kasafiyat.ToString();
            
        }

        private void materialRadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "-";
            islem = '-';
        }

        private void materialRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "x";
            islem = 'x';
        }

        private void materialRadioButton7_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "/";
            islem = '/';
        }

        private void materialRadioButton8_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "us";
            islem = 'u';
        }

        private void materialRadioButton9_CheckedChanged(object sender, EventArgs e)
        {
            label2.Text = "faktoriyel";
            islem = 'f';
        }

        public void materialRaisedButton15_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string getString = client.DownloadString("https://api.freecurrencyapi.com/v1/latest?apikey=(apianahtariniz)&currencies=TRY&base_currency=EUR");
            JObject GetData = JObject.Parse(getString);
            string eurotr = (string)GetData["data"]["TRY"];
            yuveurotr = Math.Round(Convert.ToDouble(eurotr), 2);
            materialLabel7.Text = eurotr.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Güncel dolar ve euro fiyatıyla hesaplamak için bir sonraki sayfadaki fiyat kutusundaki fiyatları güncelleye bas. Fiyatları güncellemeden hesaplamak hata verecektir.");
        }

        public async void materialRaisedButton14_Click(object sender, EventArgs e)
        {
            
            
            WebClient client = new WebClient();
            string getString = client.DownloadString("https://api.freecurrencyapi.com/v1/latest?apikey=(apianahtariniz)&currencies=TRY");
            JObject GetData = JObject.Parse(getString);          
            string dolartr = (string)GetData["data"]["TRY"];
            yuvdolartr = Math.Round(Convert.ToDouble(dolartr), 2);
            materialLabel6.Text = dolartr.ToString();
        }

        private void materialRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            birim1 = "lira";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        public Form1()
        {           
            InitializeComponent();
            progressBar1.Maximum = 100;
            progressBar1.Step = 10;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Orange700, TextShade.WHITE);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.Orange700, TextShade.WHITE);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
