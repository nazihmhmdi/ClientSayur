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
    public partial class Pembayaran : Form
    {
        public Pembayaran()
        {
            InitializeComponent();
        }

        private void Pembayaran_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sayurOrganikDataSet5.Pesanan' table. You can move, or remove it, as needed.
            this.pesananTableAdapter.Fill(this.sayurOrganikDataSet5.Pesanan);

        }
    }
}
