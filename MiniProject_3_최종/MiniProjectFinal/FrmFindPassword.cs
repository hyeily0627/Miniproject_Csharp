using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjectFinal
{
    public partial class FrmFindPassword : Form
    {
        public FrmFindPassword()
        {
            InitializeComponent();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            FrmFindId popup = new FrmFindId();
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog();
        }
    }


}
