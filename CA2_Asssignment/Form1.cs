using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CA2_Asssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditAcc Eacc = new EditAcc();
            Eacc.Show();
        }

        private void depositFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepositFunds df = new DepositFunds();
            df.Show();
        }

        private void withdrawFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WithdrawFunds wf = new WithdrawFunds();
            wf.Show();
        }

        private void transferFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferFunds tf = new TransferFunds();
            tf.Show();
        }
    }
}
