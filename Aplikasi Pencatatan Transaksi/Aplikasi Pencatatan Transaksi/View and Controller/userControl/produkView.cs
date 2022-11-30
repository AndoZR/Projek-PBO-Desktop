using Aplikasi_Pencatatan_Transaksi.View_and_Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_Pencatatan_Transaksi.View
{
    public partial class produkView : UserControl
    {
        public produkView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new addProduct().Show();
        }
    }
}
