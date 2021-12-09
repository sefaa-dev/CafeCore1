using CafeCore.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeCore
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private KatEkle _katEkle;
        private Masalar _masaEkle;
        private KategoriUrunEkle _kategoriUrunEkle;

        private void btnfrmKatEkle_Click(object sender, EventArgs e)
        {

          if(_katEkle == null)
            {
                _katEkle = new KatEkle();
            }
            _katEkle.Show();

          


        }

        private void btnfrmMenuEkle_Click(object sender, EventArgs e)  
        {
            if(_kategoriUrunEkle == null)
            {
                _kategoriUrunEkle = new KategoriUrunEkle();
            }
            _kategoriUrunEkle.Show();
        }

        private void btnfrmMasaEkle_Click(object sender, EventArgs e)
        {
            if(_masaEkle == null)
            {
                _masaEkle = new Masalar();
            }
            _masaEkle.Show();
        }
    }
}
