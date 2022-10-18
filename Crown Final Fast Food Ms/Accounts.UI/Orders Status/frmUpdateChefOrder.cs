using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accounts.UI
{
    public partial class frmUpdateChefOrder : Form
    {
        public int OrderStatus { get; set; }
        public frmUpdateChefOrder()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rdReady.Checked)
                OrderStatus = 2;
            else
                OrderStatus = 3;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdReady_CheckedChanged(object sender, EventArgs e)
        {
            if (rdReady.Checked)
            {
                rdCancel.Checked = false;
            }
        }

        private void rdCancel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCancel.Checked)
            {
                rdReady.Checked = false;
            }
        }
    }
}
