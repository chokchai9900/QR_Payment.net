using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Payment.Net.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void GotoBillbutton_Click(object sender, EventArgs e)
        {
            var billForm = new Bill_Form();
            billForm.Show();
        }

        private void GoToGenbutton_Click(object sender, EventArgs e)
        {
            var genForm = new QRGenetator();
            genForm.Show();
        }
    }
}
