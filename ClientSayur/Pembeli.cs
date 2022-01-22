using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSayur
{
    public partial class Pembeli : Form
    {
        public Pembeli()
        {
            InitializeComponent();
        }

        private void Pembeli_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sayurOrganikDataSet2.Pembeli' table. You can move, or remove it, as needed.
            this.pembeliTableAdapter.Fill(this.sayurOrganikDataSet2.Pembeli);

        }
    }
}
