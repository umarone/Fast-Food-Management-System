using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Accounts.EL;
using Accounts.BLL;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmChefViewOrder : Form
    {
        #region Variables
        public Int64 IdOrder { get; set; }
        public frmChefViewOrder()
        {
            InitializeComponent();
        }
        frmProducts frmproduct;
        #endregion
        #region Form Methods and Events
        private void frmChefViewOrder_Load(object sender, EventArgs e)
        {
            grdOrderDetail.AutoGenerateColumns = false;
            LoadOrderById();
        }
        private void LoadOrderById()
        {
            var manager = new SalesHeadBLL();
            List<VoucherDetailEL> list = manager.GetPosSalesTransactionsByNumber(IdOrder, Operations.IdProject, Operations.BookNo);
            if (list.Count > 0)
            {
                FillPosSale(list);  
            }
        }
        private void FillPosSale(List<VoucherDetailEL> List)
        {
            if (grdOrderDetail.Rows.Count > 0)
            {
                grdOrderDetail.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {

                for (int i = 0; i < List.Count; i++)
                {
                    grdOrderDetail.Rows.Add();
                    //DgvStockReceipt.Rows[i].Cells[0].Value = List[i].TransactionID;
                    grdOrderDetail.Rows[i].Cells[0].Value = List[i].IdItem;
                    grdOrderDetail.Rows[i].Cells[1].Value = List[i].BarCode;
                    grdOrderDetail.Rows[i].Cells[2].Value = List[i].ItemName;
                    grdOrderDetail.Rows[i].Cells[3].Value = List[i].PackingSize;


                    grdOrderDetail.Rows[i].Cells[4].Value = CommonFunctions.RemoveTrailingZeros(List[i].Units);
                    grdOrderDetail.Rows[i].Cells[5].Value = List[i].UnitPrice;
                    grdOrderDetail.Rows[i].Cells[6].Value = List[i].Amount;
                    grdOrderDetail.Rows[i].Cells[7].Value = List[i].Discount.ToString() + "%";
                    grdOrderDetail.Rows[i].Cells[8].Value = List[i].DiscountAmount;

                }
            }
        }
        #endregion
        #region Grid Events
        private void grdOrderDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                e.Value = "View Detail";
            }
        }

        private void grdOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {
                frmproduct = new frmProducts();
                frmproduct.IsFromOtherSide = true;
                frmproduct.IdItem = Validation.GetSafeLong(grdOrderDetail.Rows[e.RowIndex].Cells[0].Value);
                frmproduct.ShowDialog();
            }
        }
        #endregion
    }
}
