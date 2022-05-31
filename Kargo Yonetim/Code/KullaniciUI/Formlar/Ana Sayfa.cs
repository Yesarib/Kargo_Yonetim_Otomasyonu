using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciUI.Formlar
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
            label1.Text ="Sayın "+form1.adsoyad + " Hoşgeldiniz. ESP Kargo özelliklerine yan tarafta \nbulunan sekmelerden erişebilirsiniz.";
            
        }
    }
}
