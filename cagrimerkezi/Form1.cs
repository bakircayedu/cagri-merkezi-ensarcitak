using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cagrimerkezi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public object NotlardaAra(string notlar,string aranankelime,int metinUzunluk,int arananKelimeUzunluk)
        {
            int j = 0;
            for (j = 0; j <= metinUzunluk - arananKelimeUzunluk; ++j)
            {
                int i;
                //eğer aranan kelimenin ilk harfi bulunursa içteki for döngüsü çalışmaya başlar.
                for(i=0;i<arananKelimeUzunluk && aranankelime[i] == notlar[i + j]; i++)
                {
                    int baslangicindisi = notlar[i + j];
                    //bu döngü aradığımız kelime ile notlar arasında tutan harf sayısı kadar dönmeye devam eder
                    if (i >= arananKelimeUzunluk)
                    {
                        //eğer tutuşan harf sayısı aradığımız kelimenin uzunluğunu geçtiyse program sona erer.
                        //aranan kelimenin baslangic indisini ve son indisini döndürür.
                        return baslangicindisi,notlar[i+j];
                    }
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CagrilarQueue cagrilar = new CagrilarQueue(10);
            Cagri yenicagri = new Cagri();
            Cagri yenicagri1 = new Cagri();
            cagrilar.Insert(yenicagri);
            cagrilar.Insert(yenicagri1);
        }
    }
}
