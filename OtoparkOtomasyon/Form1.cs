using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtoparkOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Arac arc = new Arac();
            arc.Plaka = txtPlaka.Text;
            arc.Tip = (AracTip)listAracTipi.SelectedItem;
            arc.Kontak = CheckKontak.Checked;
            arc.Abone = checkAbone.Checked;
            listOtoparkArac.Items.Add(arc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listAracTipi.Items.Add(new AracTip { Adi = "Otomobil(1)", Fiyat = 1 });
            listAracTipi.Items.Add(new AracTip { Adi = "Minibüs(2)", Fiyat = 2 });
            listAracTipi.Items.Add(new AracTip { Adi = "Otobüs(4)", Fiyat = 4 });
            listAracTipi.Items.Add(new AracTip { Adi = "Kamyon(4)", Fiyat = 4 });
            listAracTipi.Items.Add(new AracTip { Adi = "Tır(8)", Fiyat = 8 });
        }
        List<Arac> CikisYapanAraclar = new List<Arac>();
        private void listOtoparkArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOtoparkArac.SelectedItem == null) return;
            Arac secili = (Arac)listOtoparkArac.SelectedItem;
            secili.Cikis = DateTime.Now;
            lblPlaka.Text = secili.Plaka;
            lblUcret.Text = secili.Ucret.ToString("C2");
            lblSure.Text = secili.Sure.ToString();
        }

        private void çıkışYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listOtoparkArac.SelectedItem == null) return;

            Arac secili = (Arac)(listOtoparkArac.SelectedItem);
            CikisYapanAraclar.Add(secili);
            listOtoparkArac.Items.Remove(secili);
        }

        private void btnSatisRapor_Click(object sender, EventArgs e)
        {
            Rapor form = new Rapor();
            decimal total = 0;
            foreach (Arac item in CikisYapanAraclar)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.Plaka;
                li.SubItems.Add(item.Tip.Adi);
                li.SubItems.Add(item.Abone ? "Abone" : "Değil");
                li.SubItems.Add(item.Sure.ToString());
                li.SubItems.Add(item.Ucret.ToString("C2"));
                form.listView1.Items.Add(li);
                total += item.Ucret;
            }
            form.lblToplamUcret.Text = total.ToString("C2");
            form.lblToplamArac.Text = CikisYapanAraclar.Count().ToString();
            form.Show();
        }
    }
}
