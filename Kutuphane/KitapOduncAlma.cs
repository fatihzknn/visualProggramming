using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class KitapOduncAlma : Form
    {
        public List<Ogrenci> ogrenci = new List<Ogrenci>();
        public KitapOduncAlma()
        {
            InitializeComponent();
        }
    }
}
