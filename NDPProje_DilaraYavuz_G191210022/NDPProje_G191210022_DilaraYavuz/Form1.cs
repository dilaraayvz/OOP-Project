using NDPProje_G191210022_DilaraYavuz.Meyveler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPProje_G191210022_DilaraYavuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Labellerda göstereceğim toplam değerleri için değişkenleri tanımladım.
        double ToplamAvit = 0;
        double ToplamCvit = 0;
        double toplamMiktar = 0;

        // meyvelerin random ağırlık ve verim değerlerini tutabilmek için değişkenleri tanımladım.
        double aVit = 0;
        double cVit = 0;
        int miktar = 0;

        int sure = 60;
        Random rnd = new Random();
        int random;

        //6 meyveyi barındıran bir List oluşturdum.
        List<IMeyve> meyveler = new List<IMeyve>()
        {
            new Portakal(),
            new Greyfurt(),
            new Mandalina(),
            new Elma(),
            new Armut(),
            new Cilek()
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Stop(); //Program açıldığında timer çalışmıyor durumda olacak.
            btnSikacak1.Enabled = false;// butonlar  disable olacak.
            btnSikacak2.Enabled = false;
            
            //Meyve bilgilerini göstermek için bir listview kullandım.
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Meyve Adı ", 150);
            listView1.Columns.Add("Sıvı / Püre Miktarı ", 150);
            listView1.Columns.Add("A Vit ", 150);
            listView1.Columns.Add("C Vit ", 150);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sure >= 0)// Süre 0 dan büyük olduğu sürece azalmaya devam eder.
            {
                timer1.Interval = 1000;//timer her saniye çalışacak.
                int sayac = sure--;
                lblSayac.Text = sayac.ToString();
                btnBaslat.Enabled = false;//süre 0 dan büyükse başlat butonu disable olacak.
            }
            else //Süre 0 olduğu sürece sadece başlat butonuna erişilebilir.
            {
                btnBaslat.Enabled = true;
                btnSikacak1.Enabled = false;
                btnSikacak2.Enabled = false;
                timer1.Stop();
            }
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            // Program her başladığında değerler sıfırlanıcak.
            ToplamAvit = 0;
            ToplamCvit = 0;
            toplamMiktar = 0;

            lblAvit.Text = 0.ToString();
            lblCvit.Text = 0.ToString();
            lblMiktar.Text = 0.ToString();

            listView1.Items.Clear();

            btnSikacak1.Enabled = true;// Sıkacak butonları kullanılabilir hale getirdim.
            btnSikacak2.Enabled = true;

            sure = 60;
            timer1.Start();
            random = rnd.Next(0, 6);

            pictureBox1.Image = Image.FromFile(meyveler[random].DosyaYolu);// aldığım random değere sahip meyveyi picturebox ile gösterdim.
            
            miktar = (int)meyveler[random].Miktar;
            aVit = meyveler[random].AvitMiktari;
            cVit = meyveler[random].CvitMiktari;
            
            string[] veriler = new string[]
              {
                    meyveler[random].Ad , miktar.ToString() , aVit.ToString(), cVit.ToString()
              };
            var satir = new ListViewItem(veriler);
            listView1.Items.Add(satir);

        }

        private void btnSikacak1_Click(object sender, EventArgs e)
        {
            if (meyveler[random].KatiMeyveMi() == true)
            {
                // picturebox da olan meyvenin verilerini gerekli labellere yazdırdım.
                toplamMiktar += miktar;
                ToplamAvit += aVit;
                ToplamCvit += cVit;

                lblAvit.Text = ToplamAvit.ToString();
                lblCvit.Text = ToplamCvit.ToString();
                lblMiktar.Text = toplamMiktar.ToString();

                // Yeni meyve için tekrar yeni bir random değer aldım.
                random = rnd.Next(0,6);
                pictureBox1.Image = Image.FromFile(meyveler[random].DosyaYolu);

                miktar = (int)meyveler[random].Miktar;
                aVit = meyveler[random].AvitMiktari;
                cVit = meyveler[random].CvitMiktari;

                string[] veriler = new string[]
              {
                    meyveler[random].Ad , miktar.ToString() , aVit.ToString(), cVit.ToString()
              };
                var satir = new ListViewItem(veriler);
                listView1.Items.Add(satir);
            }

        }
        private void btnSikacak2_Click(object sender, EventArgs e)
        {

            if (meyveler[random].KatiMeyveMi() == false)
            {
                // picturebox da olan meyvenin verilerini gerekli labellere yazdırdım.
                toplamMiktar += miktar;
                ToplamAvit += aVit;
                ToplamCvit += cVit;

                lblAvit.Text = ToplamAvit.ToString();
                lblCvit.Text = ToplamCvit.ToString();
                lblMiktar.Text = toplamMiktar.ToString();

                // Yeni meyve için tekrar yeni bir random değer aldım.
                random = rnd.Next(0, 6);
                pictureBox1.Image = Image.FromFile(meyveler[random].DosyaYolu);

                miktar = (int)meyveler[random].Miktar;
                aVit = meyveler[random].AvitMiktari;
                cVit = meyveler[random].CvitMiktari;

                string[] veriler = new string[]
              {
                    meyveler[random].Ad , miktar.ToString() , aVit.ToString(), cVit.ToString()
              };
                var satir = new ListViewItem(veriler);
                listView1.Items.Add(satir);
            }
        }

    }
}
