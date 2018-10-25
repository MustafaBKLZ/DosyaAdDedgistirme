using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//https://mustafabukulmez.com/
namespace DosyaAdDedgistirme
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1() { InitializeComponent(); }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.SelectedIndex = 0;
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FolderBrowserDialog fBrowser = new FolderBrowserDialog();
            fBrowser.ShowDialog();
            string secilenDizin = fBrowser.SelectedPath;
            bte_klasor_yol.Text = secilenDizin;
            list_eski_dosya_listesi.Items.Clear();
            DizinIceriginiListeyeEkle(secilenDizin, list_eski_dosya_listesi);
        }

        private void DizinIceriginiListeyeEkle(string dizin, ListBoxControl list)
        {
            string[] dizindekiKlasorler = Directory.GetDirectories(dizin);
            string[] dizindekiDosyalar = Directory.GetFiles(dizin);

            foreach (string dosya in dizindekiDosyalar)
            {
                FileInfo fileInfo = new FileInfo(dosya);
                string dosyaAdi = fileInfo.Name;
                list.Items.Add(dosyaAdi);
            }
        }

        string path = "";
        string YeniDosyaAdi = "";
        string[] DosyaAdi = new string[2];
        char ayrac = new char();
        char nokta = '.';
        FileInfo fi;
        //https://mustafabukulmez.com/
        private void btn_yeniden_sırala_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(bte_klasor_yol.Text + "\\" + txt_yeni_klasor_adi.Text))
            {
                Directory.CreateDirectory(bte_klasor_yol.Text + "\\" + txt_yeni_klasor_adi.Text);
            }

            if (txt_ayrac.Text.Trim() == string.Empty)
            {
                if (MessageBox.Show("Yeniden numaralandırma işlemi için dosya adlarında bir ayraç / seperator olmalıdır. "
                    + "Yoksa tüm dosyadı değiştirilir. " + Environment.NewLine + Environment.NewLine
                    + "EVET derseniz tüm dosya adları sadece " + txt_basamak.Text + " basamaklı sayılar olur." + Environment.NewLine
                    + "HAYIR derseniz hiçbir işlem yapılmaz."
                    , "Onay Verin", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    list_yeni_dosya_listesi.Items.Clear();
                    for (int i = 0; i < list_eski_dosya_listesi.Items.Count; i++)
                    {
                        path = bte_klasor_yol.Text + "\\" + list_eski_dosya_listesi.Items[i];
                        DosyaAdi[1] = (i + 1).ToString("d" + txt_basamak.Text + "");
                        fi = new FileInfo(path);
                        txt_uzanti.Text = fi.Extension;
                        YeniDosyaAdi = bte_klasor_yol.Text + "\\" + txt_yeni_klasor_adi.Text + "\\" + DosyaAdi[1] + fi.Extension;

                        switch (comboBoxEdit1.SelectedIndex)
                        {
                            case 0:
                                File.Copy(path, YeniDosyaAdi);
                                break;
                            case 1:
                                File.Move(path, YeniDosyaAdi);
                                break;
                        }
                    }
                    DizinIceriginiListeyeEkle(bte_klasor_yol.Text + "\\" + txt_yeni_klasor_adi.Text, list_yeni_dosya_listesi);
                }
                else { }
            }
            else
            {
                list_yeni_dosya_listesi.Items.Clear();
                for (int i = 0; i < list_eski_dosya_listesi.Items.Count; i++)
                {
                    path = bte_klasor_yol.Text + "\\" + list_eski_dosya_listesi.Items[i];
                    ayrac = Convert.ToChar(txt_ayrac.Text);
                    DosyaAdi = list_eski_dosya_listesi.Items[i].ToString().Replace(nokta, ayrac).Split(ayrac);
                    fi = new FileInfo(path);
                    txt_uzanti.Text = fi.Extension;
                    YeniDosyaAdi = bte_klasor_yol.Text + "\\" + txt_yeni_klasor_adi.Text + "\\" + (i + 1).ToString("d" + txt_basamak.Text + "") + " - " + DosyaAdi[1] + fi.Extension;

                    switch (comboBoxEdit1.SelectedIndex)
                    {
                        case 0:
                            File.Copy(path, YeniDosyaAdi);
                            break;
                        case 1:
                            File.Move(path, YeniDosyaAdi);
                            break;
                    }
                }
                //https://mustafabukulmez.com/
                DizinIceriginiListeyeEkle(bte_klasor_yol.Text + "\\" + txt_yeni_klasor_adi.Text, list_yeni_dosya_listesi);
            }
        }




    }
}
//https://mustafabukulmez.com/