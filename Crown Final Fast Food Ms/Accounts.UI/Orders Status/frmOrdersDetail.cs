using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.Common;
using Accounts.EL;
using Accounts.BLL;
using MetroFramework.Forms;
using Microsoft.Reporting.WinForms;


namespace Accounts.UI
{
    public partial class frmOrdersDetail : Form
    {
        DataTable dt;
        Int64? WhatIdVoucher;
        public delegate void FindOrderDelegate(Object Sender, Int64 IdVoucherFind);
        public event FindOrderDelegate ExecuteFindOrderEvent;
        public frmOrdersDetail()
        {
            InitializeComponent();
        }
        private void frmOrdersDetail_Load(object sender, EventArgs e)
        {
            this.grdOrders.AutoGenerateColumns = false;
            LoadOrdersStatus();
            ordersTimer.Start();
        }
        private void LoadOrdersStatus()
        {
            var manager = new SalesHeadBLL();
            List<VoucherDetailEL> list = manager.GetOrdersStatus(Operations.IdProject, Operations.BookNo);
            if (list.Count > 0)
            {
                dt = DataOperations.ToDataTable(list);
                grdOrders.DataSource = dt;
            }
            else
                grdOrders.DataSource = null;
        }
        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("FirstName LIKE '%{0}%'", txtCustomerName.Text);
            grdOrders.DataSource = DV;
        }
        private void ordersTimer_Tick(object sender, EventArgs e)
        {
            LoadOrdersStatus();
        }
        private void frmOrdersDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            ordersTimer.Stop();
            if (WhatIdVoucher.HasValue && WhatIdVoucher.Value > 0)
            {
                ExecuteFindOrderEvent(sender, WhatIdVoucher.Value);
            }
        }
        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                WhatIdVoucher = Validation.GetSafeLong(grdOrders.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
        private void grdOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            WhatIdVoucher = Validation.GetSafeLong(grdOrders.Rows[e.RowIndex].Cells[0].Value);
            this.Close();
        }
        private void grdOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                e.Value = "Select Order";
            }
        }
    }
}
