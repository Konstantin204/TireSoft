using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TireSoft
{
    public partial class FormMain : Form
    { 
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCheckInfo_Click(object sender, EventArgs e)
        {
            var fexi = new FormExistInfo();
            fexi.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var fai = new FormAddInfo();
            fai.ShowDialog();
        }

        private void buttonRepair_Click(object sender, EventArgs e)
        {
            var fr = new FormRepair();
            fr.ShowDialog();
        }

        

    }
}
