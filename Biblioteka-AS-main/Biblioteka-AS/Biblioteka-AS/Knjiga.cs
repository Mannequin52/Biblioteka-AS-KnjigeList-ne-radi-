using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Biblioteka_AS
{
    public partial class Knjiga : Form
    {

        public List<KnjigaClass> knjigaList = new List<KnjigaClass>();
        public Knjiga()
        {
            InitializeComponent();
        }

        private void Knjiga_Load(object sender, EventArgs e)
        {

        }

        private void autorimetxt_TextChanged(object sender, EventArgs e)
        {

        }


        private void unesiknjigubtn_Click(object sender, EventArgs e)
        {
            try
            {
                string isbnprovjera = Convert.ToString(isbntxt.Text);
                for (int i = 0; i < isbnprovjera.Length; i++)
                {
                    if (isbnprovjera[i] >= 0 || isbnprovjera[i] <= 9 || isbnprovjera[i] == '-')
                    {
                        KnjigaClass upisknjige = new KnjigaClass(autorimetxt.Text, nazivknjigetxt.Text, isbntxt.Text, izdavactxt.Text, Convert.ToInt32(godinatxt.Text));
                        knjigaList.Add(upisknjige);
                    }
                }
                
            }
            catch(Exception greska)
            {
             MessageBox.Show(greska.Message, "Pogrešan unos.",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void odustaniknjigabtn_Click(object sender, EventArgs e)
        {
            this.CancelButton = this.odustaniknjigabtn;
            this.Controls.Add(this.odustaniknjigabtn);
            this.ResumeLayout(false);
        }
    }
}
