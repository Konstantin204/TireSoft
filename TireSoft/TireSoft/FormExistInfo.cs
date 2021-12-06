using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TireSoft
{
    public partial class FormExistInfo : Form
    {

        public FormExistInfo()
        {
            InitializeComponent();
        }

        private void buttonCancle_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonCarInfo_Click(object sender, EventArgs e)
        {
            var fci = new FormCars();
            
            fci.ShowDialog();
        }

        private void buttonTireInfo_Click(object sender, EventArgs e)
        {
            var fti = new FormTires();

            fti.ShowDialog();
        }
    }
}
