using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024._11._18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public static string sifre_yarat(int seviye)
        {
            string sifre="";
            char[] dizi = "QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇ".ToArray() ;
            //dizide tochararray ve toarray aynı sonucu verir
            Random rasgele = new Random();
            

            for (int i = 1; i <= seviye; i++)
            { 
            sifre +=dizi[rasgele.Next(dizi.Count())] ;

            }



                return sifre;
        }
        int seviye;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("LÜTFEN SEÇİM YAPINIZ!!!");
                return;
            }
            if (comboBox1.SelectedIndex == 0) {seviye=4 ;}
            if (comboBox1.SelectedIndex == 1) {seviye=8 ;}
            if (comboBox1.SelectedIndex == 2) {seviye=12 ;}



            label1.Text = sifre_yarat(seviye);
            foreach (string benzer in listBox1.Items)
            {
                if (benzer == sifre_yarat(seviye))
                {
                    MessageBox.Show("Oluşturulan şifre zaten var");
                    return;
                }
            }
            listBox1.Items.Add(sifre_yarat(seviye));
        }
    }
}
