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

using Microsoft.Reporting.WinForms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.Common;

namespace Accounts.UI
{
    public partial class frmPosInvoice : Form
    {
        #region Variables
        int EnterCounter = 0;
        string CashRecievedAmount = string.Empty;
        frmFindAccounts frmfindAccounts;
        string CustomerAccountNo = string.Empty;
        string CashAccountNo = string.Empty;
        string SalesAccountNo = string.Empty;
        string SalesTaxAccountNo = string.Empty;
        frmPOSInfoDialogue frmposdialogue;
        frmPosReturn frmposreturn;
        Int64? IdVoucher = null;
        public Int64? PosInvoiceNumber = null;
        frmOrdersDetail frmcustomerordersstatus;
        ReportDocument RptDocument;
        ConnectionInfo oConnectionInfo = new ConnectionInfo();
        frmFindVouchers frmfindVouchers;
        private bool IsKitchenConfiguratonInSoftware;
        #endregion
        #region Form Methods And Events
        public frmPosInvoice()
        {
            InitializeComponent();
        }
        private void frmPosInvoice_Load(object sender, EventArgs e)
        {
            LoadAllItems();
            cbxPaymentMode.SelectedIndex = 0;
            toolStripBtnCashier.Text = Operations.UserName;
            cbxCustomerType.SelectedIndex = 0;
            FillData();
            CheckSoftwareCreditNature();
            CheckSoftwareTaxableNature();
            FillSalesTaxAccounts(string.Empty);
            FillSalesAccounts(string.Empty);
            FillCashAccounts(string.Empty);
            lblOrderStatus.Text = lblOrderStatus.Text + " New";
            if (PosInvoiceNumber != null)
            {
                cbxProducts.Enabled = false;
                btnSave.Enabled = false;
                grdProducts.Enabled = false;
                toolPosStrip.Enabled = false;
                txtInvoiceNumber.Text = PosInvoiceNumber.Value.ToString();
                FillPosInvoiceByNumber();
            }
           
            txtInvoiceNumber.Enabled = true;
            txtInvoiceNumber.ReadOnly = false;
            CheckKitchenConfiguration();
            if (IsKitchenConfiguratonInSoftware)
            {
                btnSendKitchen.Enabled = true;
                btnReadyOrders.Enabled = true;
                btncancelorder.Enabled = true;
            }
            else
            {
                btnSendKitchen.Enabled = false;
                btnReadyOrders.Enabled = false;
                btncancelorder.Enabled = false;
            }
        }
        private void frmPosInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                ClearControls();
                FillData();
            }
        }
        #endregion
        #region Simple Methods
        private void CheckKitchenConfiguration()
        {
            SoftwareChecksEL oelSoftwareCheck = DataOperations.SoftwareChecks.ToList().Find(x => x.SoftwareCheckName == "IsKitchenConfiguration");
            if (oelSoftwareCheck != null)
            {
                if (oelSoftwareCheck.IsMust.Value)
                {
                    IsKitchenConfiguratonInSoftware = true;
                }
                else
                    IsKitchenConfiguratonInSoftware = false;
            }
        }
        private void FillData()
        {
            var manager = new SalesHeadBLL();
            txtInvoiceNumber.Text = manager.GetMaxSalesInvoiceNumberBySaleType(Operations.IdProject, Operations.BookNo, true, 1).ToString();
        }
        private void LoadAllItems()
        {
            var manager = new ItemsBLL();
            List<ItemsEL> list = manager.GetAllItemsByType(Operations.IdProject,2);
            if (list.Count > 0)
            {
                //cbxProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //cbxProducts.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbxProducts.DataSource = list;
                cbxProducts.DisplayMember = "ItemName";
                cbxProducts.ValueMember = "IdItem";
                cbxProducts.SelectedIndex = -1;
                cbxProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxProducts.AutoCompleteSource = AutoCompleteSource.ListItems;

                //foreach (var item in list)
                //{
                //    cbxProducts.AutoCompleteCustomSource.Add(item.ItemName);
                //}
            }
        }
        private void CheckSoftwareCreditNature()
        {
            SoftwareChecksEL oelSoftwareNatureCheck = DataOperations.SoftwareChecks.Find(x => x.SoftwareCheckName == "CreditSale");
            if (oelSoftwareNatureCheck != null)
            {
                if (!oelSoftwareNatureCheck.IsMust.Value)
                {
                    cbxCustomerType.Enabled = false;
                    txtCustomerName.Visible = true;
                    //cbxProducts.Width = 341;
                }
                else
                {
                    cbxCustomerType.Enabled = true;
                    txtCustomerName.Visible = false;
                    //cbxProducts.Width = 582;
                }
            }
            else
            {
                cbxCustomerType.Enabled = false;
                txtCustomerName.Visible = true;
                //cbxProducts.Width = 341;
            }
        }
        private bool CheckSoftwareTaxableNature()
        {
            SoftwareChecksEL oelSoftwareNatureCheck = DataOperations.SoftwareChecks.Find(x => x.SoftwareCheckName == "Taxable");
            bool Status = false;
            if (oelSoftwareNatureCheck != null)
            {
                if (!oelSoftwareNatureCheck.IsMust.Value)
                {                  
                    txtTotalTax.Enabled = false;
                    txtTotalTaxAmount.Enabled = false;
                    txtInvoiceTotalWithTax.Enabled = false;
                }
                else
                {
                    txtTotalTax.Enabled = false;
                    txtTotalTaxAmount.Enabled = true;
                    txtInvoiceTotalWithTax.Enabled = true;
                    Status = true;
                }
            }
            else
            {
                txtTotalTax.Enabled = false;
                txtTotalTaxAmount.Enabled = false;
                txtInvoiceTotalWithTax.Enabled = false;
            }
            return Status;
        }
        private void CalculateTax()
        {
            if (CheckSoftwareTaxableNature())
            {
                txtTotalTax.Text = Validation.GetSafeDecimal(XmlConfiguration.ReadXmlTaxConfiguration()[1]).ToString();
                txtTotalTaxAmount.Text = Validation.GetSafeString(((Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) * Validation.GetSafeDecimal(txtTotalTax.Text)) / 100).ToString("0.00"));
                txtInvoiceTotalWithTax.Text = Validation.GetSafeString((Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) + (Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) * Validation.GetSafeDecimal(txtTotalTax.Text)) / 100).ToString("0.00"));
            }
        }
        private void FillSalesAccounts(string AccountNo)
        {
            var manager = new AccountsBLL();
            #region Fill Sales Account
            List<AccountsEL> list = manager.GetAccountsByType("Net Sales", Operations.IdCompany, Operations.IdProject);
            if (AccountNo == "")
            {
                if (list.Count > 0)
                {

                    list.Insert(0, new AccountsEL() { AccountNo = "0", AccountName = "" });

                    cbxNaturalAccounts.DataSource = list;
                    cbxNaturalAccounts.DisplayMember = "AccountName";
                    cbxNaturalAccounts.ValueMember = "AccountNo";

                    cbxNaturalAccounts.SelectedIndex = 1;
                }
            }
            else
            {
                cbxNaturalAccounts.SelectedValue = AccountNo;
            }
            #endregion
        }
        private void FillSalesTaxAccounts(string AccountNo)
        {
            var manager = new AccountsBLL();
            #region Fill Tax Accounts Account
            List<AccountsEL> list = manager.GetAccountsByType("Tax Payables", Operations.IdCompany, Operations.IdProject);
            if (AccountNo == "")
            {
                if (list.Count > 0)
                {

                    list.Insert(0, new AccountsEL() { AccountNo = "0", AccountName = "" });

                    cbxTaxPayables.DataSource = list;
                    cbxTaxPayables.DisplayMember = "AccountName";
                    cbxTaxPayables.ValueMember = "AccountNo";

                    cbxTaxPayables.SelectedIndex = 1;
                }
            }
            else
            {
                cbxTaxPayables.SelectedValue = AccountNo;
            }
            #endregion
        }
        private void FillCashAccounts(string AccountNo)
        {
            #region Fill Cash Accounts
            var manager = new AccountsBLL();
            List<AccountsEL> listCash = manager.GetAccountsByType("Cash Accounts", Operations.IdCompany, Operations.IdProject);
            if (AccountNo == "")
            {
                if (listCash.Count > 0)
                {
                    cbxCashAccounts.DataSource = listCash;
                    listCash.Insert(0, new AccountsEL() { AccountNo = "0", AccountName = "" });

                    cbxCashAccounts.DisplayMember = "AccountName";
                    cbxCashAccounts.ValueMember = "AccountNo";

                    cbxCashAccounts.SelectedIndex = 1;
                }
            }
            else
            {
                cbxCashAccounts.SelectedValue = AccountNo;
            }

            #endregion
        }
        private string BuildRemarks()
        {
            string Remarks = "";
            string First = "Following Are Sales To " + CustEditBox.Text + "~"; //: txtDescription.Text + "~";
            for (int i = 0; i < grdProducts.Rows.Count; i++)
            {
                Remarks += grdProducts.Rows[i].Cells[2].Value.ToString() + " "
                           + grdProducts.Rows[i].Cells[4].Value.ToString() + " Units"
                           + "@" + grdProducts.Rows[i].Cells[8].Value.ToString() + "~";
            }
            First += Remarks;
            return First;
        }
        private void ClearControls()
        {
            grdProducts.Rows.Clear();
            txtTotalItems.Text = string.Empty;
            txtTotalTax.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtFreeVoucher.Text = string.Empty;
            txtInvoiceTotal.Text = string.Empty;
            txtInvoiceTotalAfterDiscount.Text = string.Empty;
            txtTotalTaxAmount.Text = string.Empty;
            txtInvoiceTotalWithTax.Text = string.Empty;
            txtCardNo.Text = string.Empty;
            txtCashRecieved.Text = string.Empty;
            txtBalance.Text = string.Empty;
            EnterCounter = 0;
            CashRecievedAmount = string.Empty;
            cbxProducts.Focus();
            if (CustEditBox.Visible)
            {
                CustomerAccountNo = string.Empty;
                CustEditBox.Text = string.Empty;
                CustEditBox.Visible = false;
            }
            cbxOrderType.SelectedIndex = 0;
            txtCustomerName.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtAddress.Text = string.Empty;
            IdVoucher = null;

            btnSave.Enabled = true;
            btnSendKitchen.Enabled = true;
            btncancelorder.Enabled = true;
            lblOrderStatus.Text = "Order Status :" + " New";
            lblOrderStatus.ForeColor = Color.Red;
        }
        #endregion
        #region Grid Events
        private void grdProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal Amount = 0;
            decimal TotalQuantity = 0;
            if (e.ColumnIndex == 5)
            {
                grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colQuantity"].Value) * Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                                                                        
                if (grdProducts.Rows[e.RowIndex].Cells["colDiscInPercentage"].Value != null)
                {
                    string CellValue = Validation.GetSafeString(grdProducts.Rows[e.RowIndex].Cells["colDiscInPercentage"].Value);
                    if (CellValue.Contains('%'))
                    {
                        CellValue = CellValue.Substring(0, CellValue.Length - 1);
                    }
                    if (Validation.GetSafeDecimal(CellValue) > 0)
                    {
                        grdProducts.Rows[e.RowIndex].Cells["colNetAmount"].Value = (Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value) - ((Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value) / 100)
                                                                                      * Validation.GetSafeDecimal(CellValue)));

                    }
                    else
                    {
                        grdProducts.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value);
                    }
                    grdProducts.Rows[e.RowIndex].Cells["colDiscInPercentage"].Value = CellValue + "%";
                }
                else
                {
                    grdProducts.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value);
                    grdProducts.Rows[e.RowIndex].Cells["colDiscInPercentage"].Value = "0" + "%";
                }
            }
            if (e.ColumnIndex == 8)
            {               
                if (grdProducts.Rows[e.RowIndex].Cells["colDiscInPercentage"].Value != null)
                {
                    string CellValue = Validation.GetSafeString(grdProducts.Rows[e.RowIndex].Cells["colDiscInPercentage"].Value);
                    if (CellValue.Contains('%'))
                    {
                        CellValue = CellValue.Substring(0, CellValue.Length - 1);
                    }
                    if (Validation.GetSafeDecimal(CellValue) > 0)
                    {
                        grdProducts.Rows[e.RowIndex].Cells["colNetAmount"].Value = (Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value) - ((Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value) / 100)
                                                                                      * Validation.GetSafeDecimal(CellValue)));

                    }
                    else
                    {
                        grdProducts.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value);                        
                    }
                    grdProducts.Rows[e.RowIndex].Cells["colDiscInPercentage"].Value = Validation.GetSafeString(grdProducts.Rows[e.RowIndex].Cells["colDiscInPercentage"].Value) + "%";
                }
                else
                {
                    grdProducts.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value);
                    grdProducts.Rows[e.RowIndex].Cells["colDiscInPercentage"].Value = "0" + "%";
                }                              
            }
            for (int i = 0; i < grdProducts.Rows.Count; i++)
            {
                Amount += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colNetAmount"].Value);
                TotalQuantity += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colQuantity"].Value);
            }
            txtTotalItems.Text = TotalQuantity.ToString(); ;
            txtInvoiceTotal.Text = Amount.ToString("0.00");
            //txtInvoiceTotalAfterDiscount.Text = Amount.ToString("0.00");
            txtInvoiceTotalAfterDiscount.Text = Validation.GetSafeString(Validation.GetSafeDecimal(Amount) - (Validation.GetSafeDecimal(txtDiscount.Text) + Validation.GetSafeDecimal(txtFreeVoucher.Text)));
            CalculateTax();
        }
        private void grdProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                e.Value = "-";
            }
            else if (e.ColumnIndex == 11)
            {
                e.Value = "+";
            }
            else if (e.ColumnIndex == 12)
            {
                e.Value = "Delete";
            }
        }
        private void grdProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal Amount = 0;
            decimal TotalQuantity = 0;
            if (e.ColumnIndex == 10)
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow ORow = grdProducts.Rows[e.RowIndex];
                    decimal CurrentRowQuantity = Validation.GetSafeDecimal(ORow.Cells["colQuantity"].Value);
                    if (CurrentRowQuantity >= 1)
                    {
                        CurrentRowQuantity--;
                        if (CurrentRowQuantity > 0)
                        {
                            grdProducts.Rows[e.RowIndex].Cells["colQuantity"].Value = CurrentRowQuantity;
                            grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value = CurrentRowQuantity * Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                            if (Validation.GetSafeDecimal(grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colDiscInPercentage"].Value) == 0)
                            {
                                grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colDiscInPercentage"].Value = 0;
                                grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colNetAmount"].Value = grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colAmount"].Value;
                            }
                            else
                            {
                                grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colNetAmount"].Value = (Validation.GetSafeDecimal(grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colAmount"].Value)) - ((Validation.GetSafeDecimal(grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colAmount"].Value) * Validation.GetSafeDecimal(grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colDiscInPercentage"].Value)) / 100);
                            }
                        }
                    }
                }
            }
            else if (e.ColumnIndex == 11)
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow ORow = grdProducts.Rows[e.RowIndex];
                    decimal CurrentRowQuantity = Validation.GetSafeDecimal(ORow.Cells["colQuantity"].Value);
                    if (CurrentRowQuantity >= 1)
                    {
                        CurrentRowQuantity++;
                        grdProducts.Rows[e.RowIndex].Cells["colQuantity"].Value = CurrentRowQuantity;
                        grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value = CurrentRowQuantity * Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colUnitPrice"].Value);

                        if (Validation.GetSafeDecimal(grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colDiscInPercentage"].Value) == 0)
                        {
                            grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colDiscInPercentage"].Value = 0;
                            grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colNetAmount"].Value = grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colAmount"].Value;
                        }
                        else
                        {
                            grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colNetAmount"].Value = (Validation.GetSafeDecimal(grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colAmount"].Value)) - ((Validation.GetSafeDecimal(grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colAmount"].Value) * Validation.GetSafeDecimal(grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colDiscInPercentage"].Value)) / 100);
                        }
                    }
                }
            }
            else if (e.ColumnIndex == 12)
            {
                if (e.RowIndex > -1)
                {
                    DataGridViewRow ORow = grdProducts.Rows[e.RowIndex];
                    grdProducts.Rows.Remove(ORow);
                }
            }
            for (int i = 0; i < grdProducts.Rows.Count; i++)
            {
                Amount += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colNetAmount"].Value);
                TotalQuantity += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colQuantity"].Value);
            }
            txtTotalItems.Text = TotalQuantity.ToString();
            txtInvoiceTotal.Text = Amount.ToString("0.00");
            txtInvoiceTotalAfterDiscount.Text = Validation.GetSafeString(Validation.GetSafeDecimal(Amount) - (Validation.GetSafeDecimal(txtDiscount.Text) + Validation.GetSafeDecimal(txtFreeVoucher.Text)));
            if (grdProducts.Rows.Count == 0)
            {
                txtDiscount.Text = string.Empty;
                txtFreeVoucher.Text = string.Empty;
                txtBalance.Text = string.Empty;
                txtCashRecieved.Text = string.Empty;
                txtInvoiceTotalAfterDiscount.Text = "0.00";
            }
            CalculateTax();
        }
        #endregion        
        #region Validate Methods
        private bool ValidateRows()
        {

            if (grdProducts.Rows.Count == 0)
                return false;
            else
                return true;
        }
        private bool ValidateControls()
        {
            if (CustEditBox.Visible)
            {
                if (CustomerAccountNo == string.Empty)
                {
                    MessageBox.Show("Customer Is Missing...");
                    return false;
                }
                else if (SalesAccountNo == string.Empty)
                {
                    MessageBox.Show("Sales Account Missing, Please Select...");
                    return false;
                }
            }
            else if (!CustEditBox.Visible)
            {
                if (CashAccountNo == string.Empty)
                {
                    MessageBox.Show("Cash Account Missing...");
                    return false;
                }
                else if (SalesAccountNo == string.Empty)
                {
                    MessageBox.Show("Sales Account Missing, Please Select...");
                    return false;
                }
            }
            if (cbxOrderType.SelectedIndex == 0 || cbxOrderType.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Order Type :");
                return false;
            }
            return true;
        }
        private bool ValidateBookPeriod()
        {
            bool Status = true;
            if (Operations.BookPeriod == "" || Operations.BookPeriod == "Open")
            {
                Status = true;
            }
            else
            {
                string[] Period = Operations.BookPeriod.Split('=');
                if (Period.Length == 2)
                {
                    int FirstMonth = Convert.ToInt32(Period[0].Split(',')[0]);
                    int FirstYear = Convert.ToInt32(Period[0].Split(',')[1]);

                    int SecondMonth = Convert.ToInt32(Period[1].Split(',')[0]);
                    int SecondYear = Convert.ToInt32(Period[1].Split(',')[1]);
                    if (VInvoiceDate.Value.Year == FirstYear || VInvoiceDate.Value.Year == SecondYear)
                    {
                        if (VInvoiceDate.Value.Month < FirstMonth && VInvoiceDate.Value.Year == FirstYear)
                        {
                            Status = false;
                        }
                        else if (VInvoiceDate.Value.Month > SecondMonth && VInvoiceDate.Value.Year == SecondYear)
                        {
                            Status = false;
                        }
                        else
                        {
                            Status = true;
                        }
                    }
                    else
                    {
                        Status = false;
                    }
                    //if (VDate.Value.Month == FirstMonth && VDate.Value.Year == FirstYear || (VDate.Value.Month == SecondMonth && VDate.Value.Year == SecondYear))
                    //{
                    //    Status = true;
                    //}
                }
                else
                {
                    Status = false;
                }
            }
            return Status;
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Variables
            frmposdialogue = new frmPOSInfoDialogue();
            List<VoucherDetailEL> oelSalesDetailCollection = new List<VoucherDetailEL>();
            List<VoucherDetailEL> oelCostOfSalesCollection = new List<VoucherDetailEL>();
            List<VoucherDetailEL> oelProductsProfitLossCollection = new List<VoucherDetailEL>();
            Button btnWhat = sender as Button;
            #endregion
            #region Main Button Area
            if (ValidateRows())
            {
                if (ValidateControls())
                {
                    if (ValidateBookPeriod())
                    {
                        #region VoucherHead
                        VouchersEL oelVoucher = new VouchersEL();
                        if (!IdVoucher.HasValue)
                        {
                            oelVoucher.IdVoucher = 0;
                        }
                        else
                        {
                            oelVoucher.IdVoucher = IdVoucher;
                        }
                        oelVoucher.IdUser = Operations.UserID;
                        oelVoucher.IdProject = Operations.IdProject;
                        oelVoucher.SheetNo = 0;
                        oelVoucher.BookNo = Operations.BookNo;
                        oelVoucher.TerminalNumber = Validation.GetSafeInteger(XmlConfiguration.ReadXmlTerminalsConfiguration()[0]);
                        oelVoucher.BiltyNo = string.Empty;
                        oelVoucher.SampleNo = 0;
                        oelVoucher.FirstName = txtCustomerName.Text;
                        oelVoucher.Contact = txtContact.Text;
                        oelVoucher.Cnic = string.Empty;
                        oelVoucher.Address = txtAddress.Text;
                        oelVoucher.SoftwareType = string.Empty;
                        if (CustEditBox.Visible)
                        {
                            oelVoucher.AccountNo = CustomerAccountNo;
                        }
                        else
                        {
                            oelVoucher.AccountNo = CashAccountNo;
                        }
                        // if (IdVoucher != null || IdVoucher > 0)
                        {
                            oelVoucher.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                        }
                        oelVoucher.SubAccountNo = string.Empty;
                        oelVoucher.EmployeeAccountNo = string.Empty;
                        oelVoucher.VDiscription = string.Empty;

                        oelVoucher.OutWardGatePassNo = string.Empty;
                        oelVoucher.VDate = VInvoiceDate.Value;
                        if (btnWhat.Name == "btnSave")
                        {
                            oelVoucher.DueDate = DateTime.Now;
                        }
                        if (CustEditBox.Visible)
                        {
                            oelVoucher.ClosingBalance = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, CustomerAccountNo)[0].ClosingBalance;//CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, CustomerAccountNo)[0].ClosingBalance;  //Validation.GetSafeDecimal(txtCurrentBalance.Text);
                        }
                        else
                        {
                            oelVoucher.ClosingBalance = 0;
                        }
                        oelVoucher.TotalItems = Validation.GetSafeDecimal(txtTotalItems.Text);
                        oelVoucher.BillAmount = Validation.GetSafeDecimal(txtInvoiceTotal.Text);
                        oelVoucher.ExtraDiscount = Validation.GetSafeDecimal(txtDiscount.Text);
                        oelVoucher.FreeVoucher = Validation.GetSafeDecimal(txtFreeVoucher.Text);
                        oelVoucher.TotalFreight = Validation.GetSafeDecimal(0);
                        oelVoucher.TotalAmount = Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text);
                        oelVoucher.TaxPercentage = Validation.GetSafeDecimal(txtTotalTax.Text);
                        oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(txtTotalTaxAmount.Text);
                        oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(txtInvoiceTotalWithTax.Text);
                        oelVoucher.VAT = 0;//Validation.GetSafeInteger(txtVat.Text);
                        oelVoucher.VATAmount = 0;//Validation.GetSafeDecimal(txtTotalAmount.Text);
                        oelVoucher.CardNo = txtCardNo.Text;
                        oelVoucher.PaymentType = cbxPaymentMode.SelectedIndex;
                        oelVoucher.CashRecieved = Validation.GetSafeDecimal(txtCashRecieved.Text);
                        oelVoucher.Balance = Validation.GetSafeDecimal(txtBalance.Text);
                        oelVoucher.SaleTime = Validation.GetSafeString(txtOrderTime.Text);
                        if (btnWhat.Name == "btnSendKitchen")
                        {
                            oelVoucher.SaleStatus = 1;
                        }
                        else if (btnWhat.Name == "btnSave")
                            oelVoucher.SaleStatus = 4;
                        else
                            oelVoucher.SaleStatus = 3;
                        oelVoucher.DeliveryType = cbxOrderType.SelectedIndex;
                        oelVoucher.Transactiondays = 0;
                        oelVoucher.IsRecieved = false;
                        oelVoucher.IsImportTransaction = false;
                        if (cbxCustomerType.SelectedIndex == 0)
                            oelVoucher.IsNetTransaction = true;
                        else
                            oelVoucher.IsNetTransaction = false;
                        oelVoucher.Posted = true;
                        #endregion
                        #region Add Stock
                        for (int i = 0; i < grdProducts.Rows.Count; i++)
                        {
                            VoucherDetailEL oelSaleDetial = new VoucherDetailEL();
                            ItemsEL oelItem = new ItemsEL();
                            if (grdProducts.Rows[i].Cells["ColIdVoucherDetail"].Value != null)
                            {
                                //oelSaleDetial.TransactionID = new Guid(DgvStockReceipt.Rows[i].Cells["ColTransaction"].Value.ToString());
                                oelSaleDetial.IdVoucherDetail = Validation.GetSafeLong(grdProducts.Rows[i].Cells["ColIdVoucherDetail"].Value.ToString());
                                oelSaleDetial.IsNew = false;
                            }
                            else
                            {
                                oelSaleDetial.IdVoucherDetail = 0;
                                //oelSaleDetial.TransactionID = Guid.NewGuid();
                                oelSaleDetial.IsNew = true;
                            }
                            oelSaleDetial.SeqNo = i + 1;
                            oelSaleDetial.IdVoucher = oelVoucher.IdVoucher;
                            oelSaleDetial.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelSaleDetial.IdItem = Validation.GetSafeLong(grdProducts.Rows[i].Cells["colIdItem"].Value);
                            oelItem.IdItem = Validation.GetSafeLong(grdProducts.Rows[i].Cells["colIdItem"].Value);
                            oelSaleDetial.PackingSize = Validation.GetSafeString(grdProducts.Rows[i].Cells["colPackingSize"].Value);
                            oelSaleDetial.Discription = "N/A"; //Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colRemarks"].Value);
                            oelSaleDetial.TotalCartons = 0; //Validation.GetSafeLong(grdProducts.Rows[i].Cells["colCartons"].Value);
                            oelSaleDetial.BatchNo = string.Empty;
                            oelSaleDetial.Expiry = string.Empty;
                            oelSaleDetial.EngineNo = string.Empty;
                            oelSaleDetial.ChasisNo = string.Empty;
                            oelSaleDetial.VehicleModel = string.Empty;
                            oelSaleDetial.VehicleNo = string.Empty;
                            oelSaleDetial.FirstIMEI = string.Empty;
                            oelSaleDetial.SecondIMEI = string.Empty;
                            oelSaleDetial.ColorCode = 0;
                            oelSaleDetial.CurrentStock = 0;
                            oelSaleDetial.Units = Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colQuantity"].Value);
                            oelSaleDetial.Bonus = 0;
                            oelSaleDetial.RemainingUnits = 0;
                            oelSaleDetial.UnitPrice = Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colUnitPrice"].Value);
                            oelItem.CurrentUnitPrice = Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colUnitPrice"].Value);
                            oelSaleDetial.Amount = Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colAmount"].Value);
                            oelSaleDetial.Discount = Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colDiscInPercentage"].Value.ToString().Replace('%', ' '));
                            oelSaleDetial.DiscountAmount = Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colNetAmount"].Value);

                            oelSalesDetailCollection.Add(oelSaleDetial);
                        }
                        #endregion
                        #region Add Products Profit & Loss

                        for (int k = 0; k < grdProducts.Rows.Count; k++)
                        {
                            var IManager = new ItemsBLL();
                            VoucherDetailEL oelProductsProfitLoss = new VoucherDetailEL();
                            oelProductsProfitLoss.IdItem = Validation.GetSafeLong(grdProducts.Rows[k].Cells["colIdItem"].Value);
                            oelProductsProfitLoss.NetSaleAmount = Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colAmount"].Value);
                            oelProductsProfitLoss.SaleCost = Validation.GetSafeDecimal(IManager.GetItemsAvgValueWOT(oelProductsProfitLoss.IdItem.Value)) *
                                                                     Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value);
                            oelProductsProfitLoss.Units = Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value);
                            oelProductsProfitLoss.NetProfit = oelProductsProfitLoss.NetSaleAmount - oelProductsProfitLoss.SaleCost;

                            oelProductsProfitLossCollection.Add(oelProductsProfitLoss);
                        }

                        #endregion
                        #region Add Inventory And COGS Accounts
                        for (int k = 0; k < grdProducts.Rows.Count; k++)
                        {
                            var IManager = new ItemsBLL();
                            List<ItemsEL> EachItem = IManager.GetItemById(Validation.GetSafeLong(grdProducts.Rows[k].Cells["colIdItem"].Value));
                            if (oelCostOfSalesCollection.Count > 0)
                            {
                                VoucherDetailEL oelFindInventoryDetail = oelCostOfSalesCollection.Find(x => x.AccountNo == EachItem[0].InventoryAccount);
                                if (oelFindInventoryDetail != null)
                                {
                                    oelFindInventoryDetail.Credit += Validation.GetSafeDecimal(IManager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) *
                                                                     Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value); //EachItem[0].AVGEvaluationUnitPrice;
                                    //oelCostOfSalesCollection.Add(oelFindInventoryDetail);
                                }
                                else
                                {
                                    oelCostOfSalesCollection.Add(CreateInventoryTransaction(oelVoucher, EachItem, Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value)));
                                }
                            }
                            else
                            {
                                oelCostOfSalesCollection.Add(CreateInventoryTransaction(oelVoucher, EachItem, Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value)));
                            }
                            if (oelCostOfSalesCollection.Count > 0)
                            {
                                /// COGS
                                VoucherDetailEL oelFindCOGSDetail = oelCostOfSalesCollection.Find(x => x.AccountNo == EachItem[0].COGSAccount);
                                if (oelFindCOGSDetail != null)
                                {
                                    oelFindCOGSDetail.Debit += Validation.GetSafeDecimal(IManager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) *
                                                                     Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value); //EachItem[0].AVGEvaluationUnitPrice;
                                    //oelCostOfSalesCollection.Add(oelFindCOGSDetail);
                                }
                                else
                                {
                                    oelCostOfSalesCollection.Add(CreateCOGSTransaction(oelVoucher, EachItem, Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value)));
                                }
                            }
                            else
                            {
                                oelCostOfSalesCollection.Add(CreateCOGSTransaction(oelVoucher, EachItem, Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value)));
                            }
                        }

                        #endregion
                        #region Add Customer
                        if (cbxCustomerType.SelectedIndex == 1)
                        {
                            VoucherDetailEL oelCustomerTransaction = new VoucherDetailEL();
                            SoftwareChecksEL oelSoftwareCheck = DataOperations.SoftwareChecks.ToList().Find(x => x.SoftwareCheckName == "ItemWiseLederPrint");
                            //if (CustomerTransactionId.HasValue && CustomerTransactionId.Value > 0)
                            //{
                            //    oelCustomerTransaction.IdTransactionDetail = CustomerTransactionId.Value;
                            //    oelCustomerTransaction.IsNew = false;
                            //}
                            //else
                            //{
                                oelCustomerTransaction.IdTransactionDetail = 0;
                                oelCustomerTransaction.IsNew = true;
                            //}
                            oelCustomerTransaction.IsNetTransaction = CustEditBox.Visible ? false : true;
                            oelCustomerTransaction.SeqNo = 1;
                            oelCustomerTransaction.TrackNumber = 1;
                            oelCustomerTransaction.IdProject = Operations.IdProject;
                            oelCustomerTransaction.BookNo = Operations.BookNo;
                            oelCustomerTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelCustomerTransaction.AccountNo = CustomerAccountNo;
                            oelCustomerTransaction.SubAccountNo = "0";
                            oelCustomerTransaction.Date = VInvoiceDate.Value;
                            oelCustomerTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelCustomerTransaction.VoucherType = "S";
                            oelCustomerTransaction.TransactionType = 1;
                            oelCustomerTransaction.TransactionMode = "DR";
                            if (oelSoftwareCheck != null && oelSoftwareCheck.IsMust.Value)
                            {
                                oelCustomerTransaction.Description = BuildRemarks(); //txtDescription.Text;
                            }
                            else
                            {
                                if (CheckSoftwareTaxableNature())
                                {
                                    oelCustomerTransaction.Description = "Credit Sale To : " + CustEditBox.Text + " Including Tax";
                                }
                                else
                                {
                                    oelCustomerTransaction.Description = "Credit Sale To : " + CustEditBox.Text;
                                }
                            }
                            oelCustomerTransaction.Credit = 0;
                            if (CheckSoftwareTaxableNature())
                            {
                                oelCustomerTransaction.Debit = Validation.GetSafeDecimal(txtInvoiceTotalWithTax);
                            }
                            else
                            {
                                oelCustomerTransaction.Debit = Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount);
                            }
                                oelCustomerTransaction.Posted = true;
                            oelCustomerTransaction.CreatedDateTime = VInvoiceDate.Value;

                            oelCostOfSalesCollection.Add(oelCustomerTransaction);

                        }
                        #endregion
                        #region Add Cash
                        if (cbxCustomerType.SelectedIndex == 0)
                        {
                            VoucherDetailEL oelCashTransaction = new VoucherDetailEL();
                            //if (CashTransactionId.HasValue && CashTransactionId.Value > 0)
                            //{
                            //    oelCashTransaction.IdTransactionDetail = CashTransactionId.Value;
                            //    oelCashTransaction.IsNew = false;
                            //}
                            //else
                            //{
                                oelCashTransaction.IdTransactionDetail = 0;
                                oelCashTransaction.IsNew = true;
                            //}
                            oelCashTransaction.IsNetTransaction = CustEditBox.Visible ? false : true;
                            oelCashTransaction.SeqNo = 1;
                            oelCashTransaction.TrackNumber = 1;
                            oelCashTransaction.IdProject = Operations.IdProject;
                            oelCashTransaction.BookNo = Operations.BookNo;
                            oelCashTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelCashTransaction.AccountNo = CashAccountNo;
                            oelCashTransaction.SubAccountNo = "0";
                            oelCashTransaction.Date = VInvoiceDate.Value;
                            oelCashTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelCashTransaction.VoucherType = "S";
                            oelCashTransaction.TransactionType = 1;
                            oelCashTransaction.TransactionMode = "DR";
                           
                            oelCashTransaction.Description = "Counter Cash Sale";
                            oelCashTransaction.Credit = 0;
                            if (CheckSoftwareTaxableNature())
                            {
                                oelCashTransaction.Debit = Validation.GetSafeDecimal(txtInvoiceTotalWithTax.Text);
                            }
                            else
                            {
                                oelCashTransaction.Debit = Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text);
                            }
                            oelCashTransaction.Posted = true;
                            oelCashTransaction.CreatedDateTime = VInvoiceDate.Value;

                            oelCostOfSalesCollection.Add(oelCashTransaction);
                        }
                        #endregion
                        #region Add Sales Account In Transactions
                        /// Add Sales Account...
                        VoucherDetailEL oelSaleTransaction = new TransactionsEL();
                        //if (SalesTransactionId.HasValue && SalesTransactionId.Value > 0)
                        //{
                        //    oelSaleTransaction.IdTransactionDetail = SalesTransactionId.Value;
                        //    oelSaleTransaction.IsNew = false;
                        //}
                        //else
                        //{
                            oelSaleTransaction.IdTransactionDetail = 0;
                            oelSaleTransaction.IsNew = true;
                        //}
                        oelSaleTransaction.IsNetTransaction = CustEditBox.Visible ? false : true;
                        oelSaleTransaction.SeqNo = 2;
                        oelSaleTransaction.TrackNumber = 2;
                        oelSaleTransaction.IdProject = Operations.IdProject;
                        oelSaleTransaction.BookNo = Operations.BookNo;
                        oelSaleTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                        oelSaleTransaction.IdVoucher = oelVoucher.IdVoucher;
                        //oelPurchaseTransaction.AccountNo = Validation.GetSafeLong(PurchasesEditBox.Text);
                        oelSaleTransaction.AccountNo = SalesAccountNo;
                        oelSaleTransaction.SubAccountNo = "0";
                        oelSaleTransaction.Date = VInvoiceDate.Value;
                        oelSaleTransaction.VoucherType = "S";
                        oelSaleTransaction.TransactionType = 2;
                        if(CustEditBox.Visible)
                            oelSaleTransaction.Description = "Credit Sale To : " + CustEditBox.Text;
                        else
                            oelSaleTransaction.Description = "Sales Account Credit";
                        oelSaleTransaction.Debit = 0;
                        oelSaleTransaction.Credit = Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text);
                        
                        oelSaleTransaction.TransactionMode = "CR";
                        oelSaleTransaction.CreatedDateTime = VInvoiceDate.Value;
                        oelSaleTransaction.Posted = true;

                        oelCostOfSalesCollection.Add(oelSaleTransaction);
                        #endregion region
                        #region Add Sale Tax Transaction
                        if (CheckSoftwareTaxableNature())
                        {
                            VoucherDetailEL oelSaleTaxTransaction = new VoucherDetailEL();
                            //if (CustomerTransactionId.HasValue && CustomerTransactionId.Value > 0)
                            //{
                            //    oelCustomerTransaction.IdTransactionDetail = CustomerTransactionId.Value;
                            //    oelCustomerTransaction.IsNew = false;
                            //}
                            //else
                            //{
                            oelSaleTaxTransaction.IdTransactionDetail = 0;
                            oelSaleTaxTransaction.IsNew = true;
                            //}
                            oelSaleTaxTransaction.IsNetTransaction = CustEditBox.Visible ? false : true;
                            oelSaleTaxTransaction.SeqNo = 1;
                            oelSaleTaxTransaction.TrackNumber = 1;
                            oelSaleTaxTransaction.IdProject = Operations.IdProject;
                            oelSaleTaxTransaction.BookNo = Operations.BookNo;
                            oelSaleTaxTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelSaleTaxTransaction.AccountNo = SalesTaxAccountNo;
                            oelSaleTaxTransaction.SubAccountNo = "0";
                            oelSaleTaxTransaction.Date = VInvoiceDate.Value;
                            oelSaleTaxTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelSaleTaxTransaction.VoucherType = "S";
                            oelSaleTaxTransaction.TransactionType = 1;
                            oelSaleTaxTransaction.TransactionMode = "DR";


                            oelSaleTaxTransaction.Description = "Sale Tax Transaction";

                            oelSaleTaxTransaction.Debit = 0;

                            oelSaleTaxTransaction.Credit = Validation.GetSafeDecimal(txtTotalTaxAmount.Text);
                            oelSaleTaxTransaction.Posted = true;
                            oelSaleTaxTransaction.CreatedDateTime = VInvoiceDate.Value;

                            oelCostOfSalesCollection.Add(oelSaleTaxTransaction);

                        }
                        #endregion
                        #region Saving Code
                        if (IdVoucher == null || IdVoucher == 0)
                        {
                            var manager = new SalesHeadBLL();
                            string msg = string.Empty;
                            SoftwareChecksEL oelSoftwareCheck = DataOperations.SoftwareChecks.ToList().Find(x => x.SoftwareCheckName == "IsKitchenConfiguration");
                            if (oelSoftwareCheck != null)
                            {
                                if (oelSoftwareCheck.IsMust.Value)
                                {
                                    if (btnWhat.Name == "btnSave")
                                    {
                                        if (lblOrderStatus.Text != "Order Status :" + " Ready")
                                        {
                                            MessageBox.Show("Order Not Ready To Sale :");
                                            return;
                                        }
                                        else
                                            msg = "Confirm Order ?";
                                    }
                                    else if (btnWhat.Name == "btnSendKitchen")
                                    {
                                        if (lblOrderStatus.Text == "Order Status :" + " In Kitchen")
                                        {
                                            MessageBox.Show("Order Is Already In Kitchen : ");
                                            return;
                                        }
                                        else
                                            msg = "Send To Kithecn ?";
                                    }
                                    else
                                        msg = "Are You Sure To Cancel Order ?";
                                }
                                else
                                {
                                    msg = "Confirm Order ?";
                                }
                            }
                            if (MessageBox.Show("'"+msg+"'","Saving Sale", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                EntityoperationInfo infoResult = manager.InsertSales(oelVoucher, oelSalesDetailCollection, oelProductsProfitLossCollection, oelCostOfSalesCollection);
                                if (infoResult.IsSuccess)
                                {
                                    txtInvoiceNumber.Text = infoResult.VoucherNo.ToString();
                                    IdVoucher = infoResult.IntID;                                   
                                    if (btnWhat.Name == "btnSave")
                                    {                                        
                                        frmposdialogue.TotalItems = txtTotalItems.Text;
                                        frmposdialogue.Discount = txtDiscount.Text;
                                        frmposdialogue.FreeVoucher = txtFreeVoucher.Text;
                                        if (txtInvoiceTotalWithTax.Text == string.Empty)
                                        {
                                            frmposdialogue.InvoiceTotal = txtInvoiceTotalAfterDiscount.Text;
                                        }
                                        else
                                            frmposdialogue.InvoiceTotal = txtInvoiceTotalWithTax.Text;
                                        frmposdialogue.CashRecieved = txtCashRecieved.Text;
                                        frmposdialogue.BalanceAmount = txtBalance.Text;
                                        if (!chkNoPrint.Checked)
                                        {
                                            PrintReport(IdVoucher.Value);
                                        }
                                        if (frmposdialogue.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                        {
                                            ClearControls();
                                            FillData();
                                        }
                                    }
                                    else if (btnWhat.Name == "btnSendKitchen")
                                    {
                                        if (MessageBox.Show("Order Sent To Kitchen For Preparation Do You Want To Print Slip ?...", "Print Slip", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                        {
                                            PrintReport(infoResult.IntID);
                                            ClearControls();
                                            FillData();
                                        }
                                        else
                                        {
                                            ClearControls();
                                            FillData();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Order Canceled...");
                                        ClearControls();
                                        FillData();
                                    }

                                }
                            }
                        }
                        else
                        {
                            var manager = new SalesHeadBLL();
                            EntityoperationInfo infoResult = manager.UpdateSales(oelVoucher, oelSalesDetailCollection, oelProductsProfitLossCollection, oelCostOfSalesCollection);
                            if (infoResult.IsSuccess)
                            {
                                if (btnWhat.Name == "btnSave")
                                {
                                    if (!chkNoPrint.Checked)
                                    {
                                        PrintReport(IdVoucher.Value);
                                    }
                                    frmposdialogue.TotalItems = txtTotalItems.Text;
                                    frmposdialogue.Discount = txtDiscount.Text;
                                    frmposdialogue.FreeVoucher = txtFreeVoucher.Text;
                                    if (txtInvoiceTotalWithTax.Text == string.Empty || Validation.GetSafeDecimal(txtInvoiceTotalWithTax) == 0)
                                    {
                                        frmposdialogue.InvoiceTotal = txtInvoiceTotalAfterDiscount.Text;
                                    }
                                    else
                                        frmposdialogue.InvoiceTotal = txtInvoiceTotalWithTax.Text;
                                    frmposdialogue.CashRecieved = txtCashRecieved.Text;
                                    frmposdialogue.BalanceAmount = txtBalance.Text;
                                    if (frmposdialogue.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                    {
                                        ClearControls();
                                        FillData();
                                    }
                                }                               
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Voucher In This Book Period :" + Operations.BookPeriod);
                    }
                }
                else
                {
                    MessageBox.Show("Check Values....");
                }
            }
            else
            {
                MessageBox.Show("No Record Found...");
            }
            #endregion            
        }
        private void toolStripBtnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void toolStripReturn_Click(object sender, EventArgs e)
        {
            frmposreturn = new frmPosReturn();
            frmposreturn.Show();
        }
        private void toolStripbtnHoldSales_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnReadyOrders_Click(object sender, EventArgs e)
        {
            frmcustomerordersstatus = new frmOrdersDetail();
            frmcustomerordersstatus.ExecuteFindOrderEvent += new frmOrdersDetail.FindOrderDelegate(frmcustomerordersstatus_ExecuteFindOrderEvent);
            frmcustomerordersstatus.ShowDialog();
        }
        void frmcustomerordersstatus_ExecuteFindOrderEvent(object Sender, long IdVoucherFind)
        {
            IdVoucher = IdVoucherFind;
            FillPosInvoiceByInvoiceId();
        }
        private VoucherDetailEL CreateInventoryTransaction(VouchersEL oelVoucher, List<ItemsEL> EachItem, decimal Quantity)
        {
            VoucherDetailEL oelInventoryVoucherDetail = new VoucherDetailEL();
            var manager = new ItemsBLL();
            oelInventoryVoucherDetail.IdVoucher = oelVoucher.IdVoucher;
            oelInventoryVoucherDetail.IdProject = Operations.IdProject;
            oelInventoryVoucherDetail.BookNo = Operations.BookNo;
            oelInventoryVoucherDetail.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
            oelInventoryVoucherDetail.IdTransactionDetail = 0;
            oelInventoryVoucherDetail.IsNew = true;
            //if (DgvSalesTransactions.Rows[k].Cells["ColIdDetailVoucher"].Value != null)
            //{
            //    oelVoucherDetail.IdTransactionDetail = Validation.GetSafeLong(DgvSalesTransactions.Rows[k].Cells["ColIdDetailVoucher"].Value.ToString());
            //    oelVoucherDetail.IsNew = false;
            //}
            //else
            //{
            //    oelVoucherDetail.IdTransactionDetail = 0;
            //    oelVoucherDetail.IsNew = true;

            //}
            oelInventoryVoucherDetail.SheetNo = 0;

            oelInventoryVoucherDetail.Description = "Inventory Credit";
            oelInventoryVoucherDetail.IsNetTransaction = CustEditBox.Visible ? false : true;
            oelInventoryVoucherDetail.SeqNo = 0;
            oelInventoryVoucherDetail.TrackNumber = 0;
            oelInventoryVoucherDetail.VoucherType = "S";
            oelInventoryVoucherDetail.AccountNo = Validation.GetSafeString(EachItem[0].InventoryAccount);
            oelInventoryVoucherDetail.Credit = Validation.GetSafeDecimal(manager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) * Quantity; //EachItem[0].AVGEvaluationUnitPrice);

            oelInventoryVoucherDetail.TransactionMode = "CR";
            oelInventoryVoucherDetail.Posted = true;
            oelInventoryVoucherDetail.CreatedDateTime = VInvoiceDate.Value;

            return oelInventoryVoucherDetail;
        }
        private VoucherDetailEL CreateCOGSTransaction(VouchersEL oelVoucher, List<ItemsEL> EachItem, decimal Quantity)
        {
            var manager = new ItemsBLL();
            VoucherDetailEL oelCOGSVoucherDetail = new VoucherDetailEL();
            oelCOGSVoucherDetail.IdVoucher = oelVoucher.IdVoucher;
            oelCOGSVoucherDetail.IdProject = Operations.IdProject;
            oelCOGSVoucherDetail.BookNo = Operations.BookNo;
            oelCOGSVoucherDetail.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
            oelCOGSVoucherDetail.IdTransactionDetail = 0;
            oelCOGSVoucherDetail.IsNew = true;
            //if (DgvSalesTransactions.Rows[k].Cells["ColIdDetailVoucher"].Value != null)
            //{
            //    oelVoucherDetail.IdTransactionDetail = Validation.GetSafeLong(DgvSalesTransactions.Rows[k].Cells["ColIdDetailVoucher"].Value.ToString());
            //    oelVoucherDetail.IsNew = false;
            //}
            //else
            //{
            //    oelVoucherDetail.IdTransactionDetail = 0;
            //    oelVoucherDetail.IsNew = true;

            //}
            oelCOGSVoucherDetail.IsNetTransaction = CustEditBox.Visible ? false : true;
            oelCOGSVoucherDetail.SheetNo = 0;


            oelCOGSVoucherDetail.Description = "COGS Debit";


            oelCOGSVoucherDetail.VoucherType = "S";
            oelCOGSVoucherDetail.AccountNo = Validation.GetSafeString(EachItem[0].COGSAccount);
            oelCOGSVoucherDetail.Debit = Validation.GetSafeDecimal(manager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) * Quantity;//EachItem[0].AVGEvaluationUnitPrice);
            oelCOGSVoucherDetail.TransactionMode = "DR";
            oelCOGSVoucherDetail.Posted = true;
            oelCOGSVoucherDetail.CreatedDateTime = VInvoiceDate.Value;

            return oelCOGSVoucherDetail;
        }
        private void PrintReport(Int64 IdVoucher)
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

                        crParamDiscreteValue.Value = IdVoucher;
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
        #endregion
        #region CumboBox Methods And Events
        private void cbxNaturalAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNaturalAccounts.SelectedIndex > 0)
            {
                SalesAccountNo = Validation.GetSafeString(cbxNaturalAccounts.SelectedValue);
            }
            else
            {
                SalesAccountNo = string.Empty;
            }
        }
        private void cbxTaxPayables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTaxPayables.SelectedIndex > 0)
            {
                SalesTaxAccountNo = Validation.GetSafeString(cbxTaxPayables.SelectedValue);
            }
            else
            {
                SalesTaxAccountNo = string.Empty;
            }
        }
        private void cbxCashAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCashAccounts.SelectedIndex > 0)
            {
                CashAccountNo = Validation.GetSafeString(cbxCashAccounts.SelectedValue);
            }
            else
            {
                CashAccountNo = string.Empty;
            }
        }
        private void cbxCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCustomerType.SelectedIndex == 1)
            {
                CustEditBox.Visible = true;
            }
            else
            {
                CustEditBox.Visible = false;
            }
        }
        #endregion
        #region WinControls And Custom Controls Methods And Events
        private void txtInvoiceNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                FillPosInvoiceByNumber();
            }
        }
        private void txtInvoiceNumber_ButtonClick(object sender, EventArgs e)
        {
            frmfindVouchers = new frmFindVouchers();
            frmfindVouchers.VoucherType = VoucherTypes.SaleInvoiceVoucher.ToString();
            frmfindVouchers.IsNetTransaction = true;
            frmfindVouchers.ExecuteFindVouchersEvent += new frmFindVouchers.VouchersDelegate(frmfindVouchers_ExecuteFindVouchersEvent);
            frmfindVouchers.ShowDialog();
        }
        void frmfindVouchers_ExecuteFindVouchersEvent(VouchersEL oelVoucher)
        {
            IdVoucher = oelVoucher.IdVoucher;
            txtInvoiceNumber.Text = oelVoucher.VoucherNo.ToString();
            FillPosInvoiceByNumber();
        }
        private void cbxProducts_TextChanged(object sender, EventArgs e)
        {           
            GetItemByBarCode(Validation.GetSafeString(cbxProducts.Text));
        }
        private void cbxProducts_KeyUp(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Down || (e.KeyCode == Keys.Shift && e.KeyCode == Keys.Home))
            //    return;
            //if (e.KeyCode != Keys.Enter)
            //{
            //    cbxProducts.DroppedDown = true;
            //}
            //else if (e.KeyCode == Keys.Enter)
            //{
            //    cbxProducts.DroppedDown = false;
            //}
            //int index;
            //string actual;
            //string found;
            //actual = this.cbxProducts.Text;
            //index = cbxProducts.FindString(actual);
            //if (index > -1)
            //{
            //    found =   ((ItemsEL)(this.cbxProducts.Items[index])).ItemName;

            //    //Select this item from the list.
            //    this.cbxProducts.SelectedIndex = index;

            //    //Select the portion of the text that was automatically
            //    //added so that additional typing replaces it.
            //    this.cbxProducts.SelectionStart = actual.Length;
            //    this.cbxProducts.SelectionLength = found.Length;
            //}

        }
        private void cbxProducts_Leave(object sender, EventArgs e)
        {
            //int iFoundIndex;
            //iFoundIndex = cbxProducts.FindStringExact(cbxProducts.Text);
            //cbxProducts.SelectedIndex = iFoundIndex;
        }
        private void cbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbxProducts.SelectedIndex > 0)
            //{
            //    MessageBox.Show(cbxProducts.Text);
            //    MessageBox.Show(cbxProducts.SelectedValue.ToString());
            //}
        }
        private void cbxProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Down || e.KeyCode == Keys.Up || (e.KeyCode == Keys.Shift && e.KeyCode == Keys.Home))
            {
                return;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (cbxProducts.Text != string.Empty)
                {
                    GetItemById(Validation.GetSafeLong(cbxProducts.SelectedValue));
                    cbxProducts.Text = string.Empty;
                }
                else
                {
                    EnterCounter++;
                    if (EnterCounter >= 2 && grdProducts.Rows.Count > 0)
                    {
                        EnterCounter = 0;
                        cbxOrderType.Focus();
                        cbxOrderType.DroppedDown = true;
                        //txtCashRecieved.Focus();
                        //txtCustomerName.Focus();
                    }
                }
            }
            //else
            //{
            //    if (!char.IsNumber((char)e.KeyCode))
            //        e.SuppressKeyPress = false;
            //    else
            //    {
            //        GetItemByBarCode(Validation.GetSafeString(cbxProducts.Text));
            //        cbxProducts.Text = string.Empty;
            //    }
            //}
        }
        private void cbxCustomerType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cbxCustomerType.Text == "Credit Customer")
                {
                    CustEditBox.Focus();
                }
                else
                {
                    cbxProducts.Focus();
                }
            }
        }
        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                //txtCashRecieved.Focus();
                txtContact.Focus();
            }
        }
        private void cbxOrderType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtCustomerName.Focus();
            }
        }
        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                if (cbxOrderType.Text != "On Spot Delivery")
                {
                    txtAddress.Focus();
                }
                else
                {
                    txtCashRecieved.Focus();
                }
            }
        }
        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtCashRecieved.Focus();
            }
        }
        private void CustEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {

                e.Handled = true;
                frmfindAccounts = new frmFindAccounts();
                frmfindAccounts.SearchText = e.KeyChar.ToString();
                frmfindAccounts.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmfindAccounts_ExecuteFindAccountEvent);
                frmfindAccounts.ShowDialog();

            }
            else
                e.Handled = false;
        }
        void frmfindAccounts_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            CustomerAccountNo = oelAccount.AccountNo;
            CustEditBox.Text = oelAccount.AccountName;
        }
        #endregion
        #region Item Fetch Methods
        private void GetItemById(Int64? Id)
        {
            var manager = new ItemsBLL();
            List<ItemsEL> list = manager.GetItemById(Id.Value);
            FillProductInGrid(list, Id);
        }
        private void GetItemByBarCode(string BarCode)
        {
            if (!string.IsNullOrEmpty(BarCode))
            {
                var manager = new ItemsBLL();
                List<ItemsEL> list = manager.GetItemByBarCode(Operations.IdProject, BarCode);
                if (list.Count > 0)
                {
                    MessageBox.Show(cbxProducts.Text);
                    FillProductInGrid(list, list[0].IdItem);
                    cbxProducts.Text = string.Empty;
                }
            }
        }
        private void FillProductInGrid(List<ItemsEL> list, Int64? Id)
        {
            decimal Amount = 0;
            decimal TotalQuantity = 0;
            bool IsItemFound = false;
            int ItemFoundIndex = 0;
            if (list.Count > 0)
            {
                //MessageBox.Show(cbxProducts.Text);
                //MessageBox.Show(cbxProducts.SelectedValue.ToString());   
                //First Check Item If Exists In Grid
                if (grdProducts.Rows.Count > 0)
                {
                    for (int i = 0; i < grdProducts.Rows.Count; i++)
                    {
                        if (Id == Validation.GetSafeLong(grdProducts.Rows[i].Cells["colIdItem"].Value))
                        {
                            IsItemFound = true;
                            ItemFoundIndex = i;
                            break;
                        }
                    }
                }
                if (IsItemFound)
                {
                    // Update Items Here...   
                    string CellValue = Validation.GetSafeString(grdProducts.Rows[ItemFoundIndex].Cells["colDiscInPercentage"].Value);
                    if (CellValue.Contains('%'))
                    {
                        CellValue = CellValue.Substring(0, CellValue.Length - 1);
                    }
                    DataGridViewRow oFoundRow = grdProducts.Rows[ItemFoundIndex];
                    grdProducts.Rows[ItemFoundIndex].Cells["colQuantity"].Value = Validation.GetSafeDecimal(grdProducts.Rows[ItemFoundIndex].Cells["colQuantity"].Value) + 1;
                    grdProducts.Rows[ItemFoundIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(grdProducts.Rows[ItemFoundIndex].Cells["colUnitPrice"].Value) * Validation.GetSafeDecimal(grdProducts.Rows[ItemFoundIndex].Cells["colQuantity"].Value);
                    if (Validation.GetSafeDecimal(CellValue) == 0)
                    {
                        grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colDiscInPercentage"].Value = "0" + "%";
                        grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colNetAmount"].Value = grdProducts.Rows[ItemFoundIndex].Cells["colAmount"].Value;
                    }
                    else
                    {
                        grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colNetAmount"].Value = (Validation.GetSafeDecimal(grdProducts.Rows[ItemFoundIndex].Cells["colAmount"].Value)) - ((Validation.GetSafeDecimal(grdProducts.Rows[ItemFoundIndex].Cells["colAmount"].Value) * Validation.GetSafeDecimal(CellValue)) / 100);
                    }
                }
                else
                {
                    // Add New Items Here If No Item Found
                    grdProducts.Rows.Add();
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colIdItem"].Value = Id;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colBarCode"].Value = list[0].BarCode;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colItemName"].Value = list[0].ItemName;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colPackingSize"].Value = list[0].PackingSize;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colQuantity"].Value = 1;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colUnitPrice"].Value = list[0].MRP;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colAmount"].Value = 1 * list[0].MRP;
                    string CellValue = Validation.GetSafeString(grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colDiscInPercentage"].Value);
                    if (CellValue.Contains('%'))
                    {
                        CellValue = CellValue.Substring(0, CellValue.Length - 1);
                    }
                    if (Validation.GetSafeDecimal(CellValue) == 0)
                    {
                        grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colDiscInPercentage"].Value = "0" + "%";
                        grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colNetAmount"].Value = grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colAmount"].Value;
                    }
                    else
                    {
                        grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colNetAmount"].Value = (Validation.GetSafeDecimal(grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colAmount"].Value)) - ((Validation.GetSafeDecimal(grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colAmount"].Value) * Validation.GetSafeDecimal(CellValue)) / 100);
                    }
                }
                for (int i = 0; i < grdProducts.Rows.Count; i++)
                {
                    Amount += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colNetAmount"].Value);
                    TotalQuantity += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colQuantity"].Value);
                }
                txtTotalItems.Text = TotalQuantity.ToString(); ;
                txtInvoiceTotal.Text = Amount.ToString("0.00");
                //txtInvoiceTotalAfterDiscount.Text = Amount.ToString("0.00");
                txtInvoiceTotalAfterDiscount.Text = Validation.GetSafeString(Validation.GetSafeDecimal(Amount) - (Validation.GetSafeDecimal(txtDiscount.Text) + Validation.GetSafeDecimal(txtFreeVoucher.Text)));
                CalculateTax();
            }
        }
        #endregion
        #region Invoice Calculation Fields Methods And Events
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtInvoiceTotalAfterDiscount.Text = Validation.GetSafeString(Validation.GetSafeDecimal(txtInvoiceTotal.Text) - (Validation.GetSafeDecimal(txtDiscount.Text) + Validation.GetSafeDecimal(txtFreeVoucher.Text)));//Validation.GetSafeDecimal(txtDiscount.Text));
                CalculateTax();
                txtFreeVoucher.Focus();
            }
        }
        private void txtFreeVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtInvoiceTotalAfterDiscount.Text = Validation.GetSafeString(Validation.GetSafeDecimal(txtInvoiceTotal.Text) - (Validation.GetSafeDecimal(txtDiscount.Text) + Validation.GetSafeDecimal(txtFreeVoucher.Text)));
                CalculateTax();
                txtCashRecieved.Focus();
            }
        }
        //private void txtTotalTax_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == (char)Keys.Enter)
        //    {
        //        e.Handled = true;
        //        txtTotalTaxAmount.Text = Validation.GetSafeString(((Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) * Validation.GetSafeDecimal(txtTotalTax.Text)) / 100).ToString("0.00"));
        //        txtInvoiceTotalWithTax.Text = Validation.GetSafeString((Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) + (Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) * Validation.GetSafeDecimal(txtTotalTax.Text)) / 100).ToString("0.00"));
        //        if (txtTotalTax.Text != string.Empty)
        //        {
        //            txtTotalTax.Text = txtTotalTax.Text + "%";
        //        }
        //        txtCardNo.Focus();
        //    }
        //}
        //private void txtTotalTax_Enter(object sender, EventArgs e)
        //{
        //    txtTotalTax.Text = string.Empty;
        //}
        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtCashRecieved.Focus();
            }
        }
        private void txtCashRecieved_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                    if (txtCashRecieved.Text != string.Empty)
                    {
                        if (CheckSoftwareTaxableNature())
                        {
                            txtBalance.Text = CommonFunctions.RemoveTrailingZeros(Validation.GetSafeDecimal(txtCashRecieved.Text) - Validation.GetSafeDecimal(txtInvoiceTotalWithTax.Text));
                        }
                        else
                        {
                            txtBalance.Text = CommonFunctions.RemoveTrailingZeros(Validation.GetSafeDecimal(txtCashRecieved.Text) - Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text));
                        }
                        CashRecievedAmount = string.Empty;
                        //btnSave.Focus();
                        if (IsKitchenConfiguratonInSoftware)
                        {
                            btnSendKitchen.Focus();
                        }
                        else
                            btnSave.Focus();
                    }
                    else
                    {
                        if (IsKitchenConfiguratonInSoftware)
                        {
                            btnSendKitchen.Focus();
                        }
                        else
                            btnSave.Focus();
                    }
                }
                else
                    e.Handled = false;
            }
            else
            {
                e.Handled = false;
                CashRecievedAmount += e.KeyChar;
            }
        }
        #endregion}    
        #region Invoice Info Region
        private void FillPosInvoiceByNumber()
        {
            #region Variables

            var Manager = new SalesHeadBLL();
            #endregion
            #region Filling Sales Header And Detail
            List<VoucherDetailEL> ListSales = Manager.GetPosSalesTransactionsByNumber(Validation.GetSafeLong(txtInvoiceNumber.Text), Operations.IdProject, Operations.BookNo);
            if (ListSales.Count > 0)
            {
                IdVoucher = ListSales[0].IdVoucher;
                cbxOrderType.SelectedIndex = ListSales[0].DeliveryType;
                txtCustomerName.Text = ListSales[0].FirstName;
                txtContact.Text = ListSales[0].Contact;
                txtAddress.Text = ListSales[0].Address;
                lblOrderStatus.Text = string.Empty;
                if (ListSales[0].SaleStatus == 1)
                {
                    lblOrderStatus.Text = "Order Status :" + " In Kitchen";
                    lblOrderStatus.ForeColor = Color.LightSkyBlue;
                    btnSave.Enabled = false;
                    btnSendKitchen.Enabled = false;
                    btncancelorder.Enabled = true;
                }
                else if (ListSales[0].SaleStatus == 2)
                {
                    lblOrderStatus.Text = "Order Status :" + " Ready";
                    lblOrderStatus.ForeColor = Color.LightGreen;
                    btnSave.Enabled = true;
                    btnSendKitchen.Enabled = false;
                    btncancelorder.Enabled = false;
                }
                else if (ListSales[0].SaleStatus == 3)
                {
                    lblOrderStatus.Text = "Order Status :" + " Canceled";
                    btnSave.Enabled = false;
                    btnSendKitchen.Enabled = false;
                    btncancelorder.Enabled = false;
                }
                else if (ListSales[0].SaleStatus == 4)
                {
                    lblOrderStatus.Text = "Order Status :" + " Delivered";
                    lblOrderStatus.ForeColor = Color.Green;
                    btnSendKitchen.Enabled = false;
                    btncancelorder.Enabled = false;
                }
                else
                {
                    lblOrderStatus.Text = "Order Status :" + " New";
                    btnSave.Enabled = true;
                    btnSendKitchen.Enabled = true;
                    btncancelorder.Enabled = false;
                }
                txtTotalItems.Text = Validation.GetSafeString(ListSales[0].TotalItems);
                txtInvoiceTotal.Text = Validation.GetSafeString(ListSales[0].BillAmount);
                txtDiscount.Text = Validation.GetSafeString(ListSales[0].ExtraDiscount);
                txtFreeVoucher.Text = Validation.GetSafeString(ListSales[0].FreeVoucher);
                txtInvoiceTotalAfterDiscount.Text = Validation.GetSafeString(ListSales[0].TotalAmount);
                txtTotalTax.Text = Validation.GetSafeString(ListSales[0].TaxPercentage);
                txtTotalTaxAmount.Text = Validation.GetSafeString(ListSales[0].TotalTaxAmount);
                txtInvoiceTotalWithTax.Text = Validation.GetSafeString(ListSales[0].TotalAmountAfterTax);
                cbxPaymentMode.SelectedIndex = Validation.GetSafeInteger(ListSales[0].PaymentType);
                txtCardNo.Text = Validation.GetSafeString(ListSales[0].CardNo);
                txtCashRecieved.Text = Validation.GetSafeString(ListSales[0].CashRecieved);
                txtBalance.Text = Validation.GetSafeString(ListSales[0].Balance);
                FillPosSale(ListSales);
            }
            else
            {
                MessageBox.Show("Invoice Number Not Found ...");
                ClearControls();
            }
            #endregion
        }
        private void FillPosInvoiceByInvoiceId()
        {
            #region Variables

            var Manager = new SalesHeadBLL();
            #endregion
            #region Filling Sales Header And Detail
            List<VoucherDetailEL> ListSales = Manager.GetPosSalesTransactionsById(IdVoucher.Value, Operations.IdProject, Operations.BookNo);
            if (ListSales.Count > 0)
            {
                IdVoucher = ListSales[0].IdVoucher;
                cbxOrderType.SelectedIndex = ListSales[0].DeliveryType;
                string ShortMsg = string.Empty;
                txtCustomerName.Text = ListSales[0].FirstName;
                txtContact.Text = ListSales[0].Contact;
                txtAddress.Text = ListSales[0].Address;
                lblOrderStatus.Text = string.Empty;
                if (ListSales[0].SaleStatus == 1)
                {
                    lblOrderStatus.Text = "Order Status :" + " In Kitchen";
                    lblOrderStatus.ForeColor = Color.LightSkyBlue;
                    btnSave.Enabled = false;
                    btnSendKitchen.Enabled = false;
                    btncancelorder.Enabled = true;
                }
                else if (ListSales[0].SaleStatus == 2)
                {
                    lblOrderStatus.Text = "Order Status :" + " Ready";
                    lblOrderStatus.ForeColor = Color.Blue;
                    btnSave.Enabled = true;
                    btnSendKitchen.Enabled = false;
                    btncancelorder.Enabled = false;
                }
                else if (ListSales[0].SaleStatus == 3)
                {
                    lblOrderStatus.Text = "Order Status :" + " Canceled";
                    btnSave.Enabled = false;
                    btnSendKitchen.Enabled = false;
                    btncancelorder.Enabled = false;
                }
                else if (ListSales[0].SaleStatus == 4)
                {
                    lblOrderStatus.Text = "Order Status :" + " Delivered";
                    lblOrderStatus.ForeColor = Color.Green;
                    btnSave.Enabled = false;
                    btnSendKitchen.Enabled = false;
                    btncancelorder.Enabled = false;
                }
                else
                {
                    lblOrderStatus.Text = "Order Status :" + " New";
                    lblOrderStatus.ForeColor = Color.Red;
                    btnSave.Enabled = true;
                    btnSendKitchen.Enabled = true;
                    btncancelorder.Enabled = false;
                }
                txtTotalItems.Text = Validation.GetSafeString(ListSales[0].TotalItems);
                txtInvoiceTotal.Text = Validation.GetSafeString(ListSales[0].BillAmount);
                txtDiscount.Text = Validation.GetSafeString(ListSales[0].ExtraDiscount);
                txtFreeVoucher.Text = Validation.GetSafeString(ListSales[0].FreeVoucher);
                txtInvoiceTotalAfterDiscount.Text = Validation.GetSafeString(ListSales[0].TotalAmount);
                txtTotalTax.Text = Validation.GetSafeString(ListSales[0].TaxPercentage);
                txtTotalTaxAmount.Text = Validation.GetSafeString(ListSales[0].TotalTaxAmount);
                txtInvoiceTotalWithTax.Text = Validation.GetSafeString(ListSales[0].TotalAmountAfterTax);
                cbxPaymentMode.SelectedIndex = Validation.GetSafeInteger(ListSales[0].PaymentType);
                txtCardNo.Text = Validation.GetSafeString(ListSales[0].CardNo);
                txtCashRecieved.Text = Validation.GetSafeString(ListSales[0].CashRecieved);
                txtBalance.Text = Validation.GetSafeString(ListSales[0].Balance);

                FillPosSale(ListSales);
            }
            else
            {
                MessageBox.Show("Invoice Number Not Found ...");
                ClearControls();
            }
            #endregion
        }
        private void FillPosSale(List<VoucherDetailEL> List)
        {
            if (grdProducts.Rows.Count > 0)
            {
                grdProducts.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {

                for (int i = 0; i < List.Count; i++)
                {
                    grdProducts.Rows.Add();
                    //DgvStockReceipt.Rows[i].Cells[0].Value = List[i].TransactionID;
                    grdProducts.Rows[i].Cells[0].Value = List[i].IdVoucherDetail;
                    grdProducts.Rows[i].Cells[1].Value = List[i].IdItem;
                    grdProducts.Rows[i].Cells[2].Value = List[i].BarCode;
                    grdProducts.Rows[i].Cells[3].Value = List[i].ItemName;
                    grdProducts.Rows[i].Cells[4].Value = List[i].PackingSize;
                 

                    grdProducts.Rows[i].Cells[5].Value = CommonFunctions.RemoveTrailingZeros(List[i].Units);
                    grdProducts.Rows[i].Cells[6].Value = List[i].UnitPrice;
                    grdProducts.Rows[i].Cells[7].Value = List[i].Amount;
                    grdProducts.Rows[i].Cells[8].Value = List[i].Discount.ToString() + "%";
                    grdProducts.Rows[i].Cells[9].Value = List[i].DiscountAmount;

                }
            }
        }
        #endregion   
    }
}
