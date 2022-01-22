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
    public partial class Sayur : Form
    {
        public Sayur()
        {
            InitializeComponent();
        }

        private void Sayur_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sayurOrganikDataSet4.Sayur' table. You can move, or remove it, as needed.
            this.sayurTableAdapter.Fill(this.sayurOrganikDataSet4.Sayur);
            // TODO: This line of code loads data into the 'sayurOrganikDataSet3.Sayur' table. You can move, or remove it, as needed.

        }
    }
}
