using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico2
{
    public partial class MdiParent1 : Form
    {
        public MdiParent1()
        {
            InitializeComponent();
        }

        private void ventana1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.MdiParent = this;
            form2.Show();
        }
    }
}
