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
    public partial class Knjige : Form
    {
        List<KnjigaClass> knjigaList = new List<KnjigaClass>();
        public Knjige()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void osvjezibtn_Click(object sender, EventArgs e)
        {
            ispisKnjigetxt.Clear();

            ispisKnjigetxt.Text = "Naziv" + "\n" + "Autor" + "\n" + "Izdavac" + "\n" + "Godina izdanja" + "\n" + "ISBN"+ "\n\n";
            foreach (KnjigaClass upisknjige in knjigaList)
            {
                ispisKnjigetxt.AppendText("\n" + upisknjige.ToString());
            }
        }
    }
}
