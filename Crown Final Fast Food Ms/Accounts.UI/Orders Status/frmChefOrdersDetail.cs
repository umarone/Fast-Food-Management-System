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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.Common;


namespace Accounts.UI
{
    public partial class frmChefOrdersDetail : Form
    {
        DataTable dt;
        frmUpdateChefOrder frmupdateorderstatus;
        frmChefViewOrder frmchefview;
        frmLogin frmlogin = null;
        ReportDocument RptDocument;
        ConnectionInfo oConnectionInfo = new ConnectionInfo();
        frmFindVouchers frmfindmyOrders;
        public frmChefOrdersDetail()
        {
            InitializeComponent();
        }
        private void frmChefOrdersDetail_Load(object sender, EventArgs e)
        {
            this.grdOrders.AutoGenerateColumns = false;
            LoadOrdersStatus();
            ordersTimer.Start();
        }
        private void LoadOrdersStatus()
        {
            var manager = new SalesHeadBLL();
            List<VoucherDetailEL> list = manager.GetOrdersStatusForKitchen(Operations.IdProject, Operations.BookNo);
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
            //this.Close();
        }
        private void grdOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9)
                e.Value = "View Order";
            else if (e.ColumnIndex == 10)
                e.Value = "Update Order";
            else if (e.ColumnIndex == 11)
                e.Value = "Print Receipt";
        }
        private void grdOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var manager = new SalesHeadBLL();
            if (e.ColumnIndex == 9)
            {
                Int64? IdVoucher = Validation.GetSafeLong(grdOrders.Rows[e.RowIndex].Cells["colOrderId"].Value);
                frmchefview = new frmChefViewOrder();
                frmchefview.IdOrder = IdVoucher.Value;
                frmchefview.ShowDialog();
            }
            else if (e.ColumnIndex == 10)
            {
                Int64? IdVoucher = Validation.GetSafeLong(grdOrders.Rows[e.RowIndex].Cells["colIdVoucher"].Value);
                frmupdateorderstatus = new frmUpdateChefOrder();
                if (frmupdateorderstatus.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (manager.UpdateOrderStatusByChef(IdVoucher.Value, frmupdateorderstatus.OrderStatus).IsSuccess)
                    {
                        MessageBox.Show("Order Status Updated....");
                        LoadOrdersStatus();
                    }
                }
                else
                {
                    MessageBox.Show("Order Update Canceled");       
                }
            }
            else if (e.ColumnIndex == 11)
            {
                Int64? IdVoucher = Validation.GetSafeLong(grdOrders.Rows[e.RowIndex].Cells["colOrderId"].Value);
                PrintReport(IdVoucher.Value);
            }
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (frmlogin == null)
            {
                this.Hide();
                frmlogin = new frmLogin();
                frmlogin.ShowDialog();
                this.Dispose(true);
            }
            else
            {
                frmlogin.ShowDialog();
            }
        }
        private void PrintReport(Int64 Id)
        {
            string strSchemaName = "Transactions";
            string ReportName = "..//..//Reports/" + Operations.ProjectInvoiceName + ".rpt";
            RptDocument = new ReportDocument();
            RptDocument.Load(ReportName);
            TableLogOnInfo oTableLogOnInfo = new TableLogOnInfo();
            DbConnectionStringBuilder connectionBuilder = new DbConnectionStringBuilder();
            connectionBuilder.ConnectionString = DBHelper.DataConnection;
            oConnectionInfo.ServerName = connectionBuilder["Data Source"].ToString();
            oConnectionInfo.DatabaseName = connectionBuilder["initial catalog"].ToString();

            oConnectionInfo.UserID = connectionBuilder["user id"].ToString();
            oConnectionInfo.Password = connectionBuilder["password"].ToString();
            //oConnectionInfo.IntegratedSecurity = true;
            oConnectionInfo.Type = ConnectionInfoType.SQL;


            foreach (CrystalDecisions.CrystalReports.Engine.Table oTable in RptDocument.Database.Tables)
            {
                oTableLogOnInfo = oTable.LogOnInfo;
                oTableLogOnInfo.ConnectionInfo = oConnectionInfo;
                oTable.ApplyLogOnInfo(oTableLogOnInfo);
            }

            for (int i = 0; i <= RptDocument.Database.Tables.Count - 1; i++)
            {
                RptDocument.Database.Tables[i].Location = oConnectionInfo.DatabaseName + "." + strSchemaName + "." + RptDocument.Database.Tables[i].Location.Substring(RptDocument.Database.Tables[i].Location.LastIndexOf(".") + 1);
            }

            ParameterFieldDefinitions crParamFieldDefinitions = RptDocument.DataDefinition.ParameterFields;
            foreach (ParameterFieldDefinition def in crParamFieldDefinitions)
            {

                if (def.ReportName == "")
                {
                    if (def.ParameterFieldName == "@IdInvoice")
                    {
                        ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                        ParameterValues crCurrentValues = def.CurrentValues;


                        //string TayloringNumber = VoucherNo;

                        crParamDiscreteValue.Value = Id;
                        crCurrentValues.Add(crParamDiscreteValue);
                        def.ApplyCurrentValues(crCurrentValues);
                    }
                    else if (def.ParameterFieldName == "@IdProject")
                    {
                        ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                        ParameterValues crCurrentValues = def.CurrentValues;


                        //string TayloringNumber = VoucherNo;

                        crParamDiscreteValue.Value = Operations.IdProject; //"{" + Operations.IdCompany + "}";
                        crCurrentValues.Add(crParamDiscreteValue);
                        def.ApplyCurrentValues(crCurrentValues);
                    }
                    else if (def.ParameterFieldName == "@BookNo")
                    {
                        ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                        ParameterValues crCurrentValues = def.CurrentValues;


                        //string TayloringNumber = VoucherNo;

                        crParamDiscreteValue.Value = Operations.BookNo; //"{" + Operations.IdCompany + "}";
                        crCurrentValues.Add(crParamDiscreteValue);
                        def.ApplyCurrentValues(crCurrentValues);
                    }

                }
            }


            RptDocument.PrintToPrinter(1, false, 0, 0);
            //reportViewer1.repo = RptDocument;

            // crystalReportViewer1.ReportSource = RptDocument;
        }
        private void btnMyOrders_Click(object sender, EventArgs e)
        {
            frmfindmyOrders = new frmFindVouchers();
            frmfindmyOrders.VoucherType = "SaleInvoiceVoucher";
            frmfindmyOrders.ShowDialog();
        }
    }
}
