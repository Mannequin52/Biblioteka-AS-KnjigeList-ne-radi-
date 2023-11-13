using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_AS
{
    public partial class Korisnik : Form
    {
        List <Korisnik> korisnikList = new List<Korisnik>();
        public Korisnik()
        {
            InitializeComponent();
        }

        private void imekorisniktxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
