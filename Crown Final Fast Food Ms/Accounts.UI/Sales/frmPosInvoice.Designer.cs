namespace Accounts.UI
{
    partial class frmPosInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPosInvoice));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtInvoiceNumber = new MetroFramework.Controls.MetroTextBox();
            this.VInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblTotalItems = new System.Windows.Forms.Label();
            this.txtTotalItems = new System.Windows.Forms.TextBox();
            this.txtTotalTax = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtFreeVoucher = new System.Windows.Forms.TextBox();
            this.txtInvoiceTotal = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtCashRecieved = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblTaxPercentage = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblFreeVoucher = new System.Windows.Forms.Label();
            this.lblInvoiceTotal = new System.Windows.Forms.Label();
            this.lblPayMode = new System.Windows.Forms.Label();
            this.lblCashRecieved = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.cbxPaymentMode = new System.Windows.Forms.ComboBox();
            this.cbxProducts = new System.Windows.Forms.ComboBox();
            this.toolPosStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripbtnHoldSales = new System.Windows.Forms.ToolStripButton();
            this.toolStripReturn = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCashier = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPromoCode = new System.Windows.Forms.Label();
            this.txtPromoCode = new MetroFramework.Controls.MetroTextBox();
            this.cbxCustomerType = new System.Windows.Forms.ComboBox();
            this.CustEditBox = new MetroFramework.Controls.MetroTextBox();
            this.pnlSalesAccounts = new System.Windows.Forms.Panel();
            this.cbxTaxPayables = new System.Windows.Forms.ComboBox();
            this.cbxNaturalAccounts = new System.Windows.Forms.ComboBox();
            this.lblTaxAcccount = new System.Windows.Forms.Label();
            this.lblSaleAccount = new System.Windows.Forms.Label();
            this.lblCashAccount = new System.Windows.Forms.Label();
            this.cbxCashAccounts = new System.Windows.Forms.ComboBox();
            this.lblInvoiceTotalWithTax = new System.Windows.Forms.Label();
            this.txtInvoiceTotalWithTax = new System.Windows.Forms.TextBox();
            this.lblTotalWithDicount = new System.Windows.Forms.Label();
            this.txtInvoiceTotalAfterDiscount = new System.Windows.Forms.TextBox();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.txtTotalTaxAmount = new System.Windows.Forms.TextBox();
            this.chkNoPrint = new System.Windows.Forms.CheckBox();
            this.btnReadyOrders = new System.Windows.Forms.Button();
            this.btnSendKitchen = new System.Windows.Forms.Button();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.txtOrderTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxOrderType = new System.Windows.Forms.ComboBox();
            this.txtContact = new MetroFramework.Controls.MetroTextBox();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.btncancelorder = new System.Windows.Forms.Button();
            this.lblOrderStatus = new MetroFramework.Controls.MetroLabel();
            this.grdProducts = new Accounts.UI.TabDataGrid();
            this.ColIdVoucherDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackingSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscInPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colAdd = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolPosStrip.SuspendLayout();
            this.pnlSalesAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            resources.ApplyResources(this.lblDate, "lblDate");
            this.lblDate.Name = "lblDate";
            // 
            // txtInvoiceNumber
            // 
            // 
            // 
            // 
            this.txtInvoiceNumber.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtInvoiceNumber.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.txtInvoiceNumber.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtInvoiceNumber.CustomButton.Name = "";
            this.txtInvoiceNumber.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtInvoiceNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInvoiceNumber.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtInvoiceNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInvoiceNumber.CustomButton.UseSelectable = true;
            resources.ApplyResources(this.txtInvoiceNumber, "txtInvoiceNumber");
            this.txtInvoiceNumber.Lines = new string[0];
            this.txtInvoiceNumber.MaxLength = 32767;
            this.txtInvoiceNumber.Name = "txtInvoiceNumber";
            this.txtInvoiceNumber.PasswordChar = '\0';
            this.txtInvoiceNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInvoiceNumber.SelectedText = "";
            this.txtInvoiceNumber.SelectionLength = 0;
            this.txtInvoiceNumber.SelectionStart = 0;
            this.txtInvoiceNumber.ShortcutsEnabled = true;
            this.txtInvoiceNumber.ShowButton = true;
            this.txtInvoiceNumber.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtInvoiceNumber.UseSelectable = true;
            this.txtInvoiceNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInvoiceNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInvoiceNumber.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.txtInvoiceNumber_ButtonClick);
            this.txtInvoiceNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNumber_KeyPress);
            // 
            // VInvoiceDate
            // 
            resources.ApplyResources(this.VInvoiceDate, "VInvoiceDate");
            this.VInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.VInvoiceDate.Name = "VInvoiceDate";
            // 
            // lblInvoiceNo
            // 
            resources.ApplyResources(this.lblInvoiceNo, "lblInvoiceNo");
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            // 
            // lblItems
            // 
            resources.ApplyResources(this.lblItems, "lblItems");
            this.lblItems.Name = "lblItems";
            // 
            // lblTotalItems
            // 
            resources.ApplyResources(this.lblTotalItems, "lblTotalItems");
            this.lblTotalItems.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalItems.Name = "lblTotalItems";
            // 
            // txtTotalItems
            // 
            resources.ApplyResources(this.txtTotalItems, "txtTotalItems");
            this.txtTotalItems.Name = "txtTotalItems";
            // 
            // txtTotalTax
            // 
            resources.ApplyResources(this.txtTotalTax, "txtTotalTax");
            this.txtTotalTax.Name = "txtTotalTax";
            // 
            // txtDiscount
            // 
            resources.ApplyResources(this.txtDiscount, "txtDiscount");
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // txtFreeVoucher
            // 
            resources.ApplyResources(this.txtFreeVoucher, "txtFreeVoucher");
            this.txtFreeVoucher.Name = "txtFreeVoucher";
            this.txtFreeVoucher.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFreeVoucher_KeyPress);
            // 
            // txtInvoiceTotal
            // 
            resources.ApplyResources(this.txtInvoiceTotal, "txtInvoiceTotal");
            this.txtInvoiceTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInvoiceTotal.Name = "txtInvoiceTotal";
            // 
            // txtCardNo
            // 
            resources.ApplyResources(this.txtCardNo, "txtCardNo");
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCardNo_KeyPress);
            // 
            // txtCashRecieved
            // 
            resources.ApplyResources(this.txtCashRecieved, "txtCashRecieved");
            this.txtCashRecieved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCashRecieved.Name = "txtCashRecieved";
            this.txtCashRecieved.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashRecieved_KeyPress);
            // 
            // txtBalance
            // 
            resources.ApplyResources(this.txtBalance, "txtBalance");
            this.txtBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBalance.Name = "txtBalance";
            // 
            // lblTaxPercentage
            // 
            resources.ApplyResources(this.lblTaxPercentage, "lblTaxPercentage");
            this.lblTaxPercentage.BackColor = System.Drawing.SystemColors.Control;
            this.lblTaxPercentage.Name = "lblTaxPercentage";
            // 
            // lblDiscount
            // 
            resources.ApplyResources(this.lblDiscount, "lblDiscount");
            this.lblDiscount.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiscount.Name = "lblDiscount";
            // 
            // lblFreeVoucher
            // 
            resources.ApplyResources(this.lblFreeVoucher, "lblFreeVoucher");
            this.lblFreeVoucher.BackColor = System.Drawing.SystemColors.Control;
            this.lblFreeVoucher.Name = "lblFreeVoucher";
            // 
            // lblInvoiceTotal
            // 
            resources.ApplyResources(this.lblInvoiceTotal, "lblInvoiceTotal");
            this.lblInvoiceTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblInvoiceTotal.Name = "lblInvoiceTotal";
            // 
            // lblPayMode
            // 
            resources.ApplyResources(this.lblPayMode, "lblPayMode");
            this.lblPayMode.BackColor = System.Drawing.SystemColors.Control;
            this.lblPayMode.Name = "lblPayMode";
            // 
            // lblCashRecieved
            // 
            resources.ApplyResources(this.lblCashRecieved, "lblCashRecieved");
            this.lblCashRecieved.BackColor = System.Drawing.SystemColors.Control;
            this.lblCashRecieved.Name = "lblCashRecieved";
            // 
            // lblBalance
            // 
            resources.ApplyResources(this.lblBalance, "lblBalance");
            this.lblBalance.BackColor = System.Drawing.SystemColors.Control;
            this.lblBalance.Name = "lblBalance";
            // 
            // lblCardNo
            // 
            resources.ApplyResources(this.lblCardNo, "lblCardNo");
            this.lblCardNo.BackColor = System.Drawing.SystemColors.Control;
            this.lblCardNo.Name = "lblCardNo";
            // 
            // cbxPaymentMode
            // 
            resources.ApplyResources(this.cbxPaymentMode, "cbxPaymentMode");
            this.cbxPaymentMode.DropDownWidth = 100;
            this.cbxPaymentMode.FormattingEnabled = true;
            this.cbxPaymentMode.Items.AddRange(new object[] {
            resources.GetString("cbxPaymentMode.Items"),
            resources.GetString("cbxPaymentMode.Items1"),
            resources.GetString("cbxPaymentMode.Items2")});
            this.cbxPaymentMode.Name = "cbxPaymentMode";
            // 
            // cbxProducts
            // 
            this.cbxProducts.BackColor = System.Drawing.SystemColors.Info;
            this.cbxProducts.FormattingEnabled = true;
            resources.ApplyResources(this.cbxProducts, "cbxProducts");
            this.cbxProducts.Name = "cbxProducts";
            this.cbxProducts.TextChanged += new System.EventHandler(this.cbxProducts_TextChanged);
            this.cbxProducts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbxProducts_KeyDown);
            // 
            // toolPosStrip
            // 
            resources.ApplyResources(this.toolPosStrip, "toolPosStrip");
            this.toolPosStrip.BackColor = System.Drawing.Color.RosyBrown;
            this.toolPosStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnNew,
            this.toolStripbtnHoldSales,
            this.toolStripReturn,
            this.toolStripBtnCashier});
            this.toolPosStrip.Name = "toolPosStrip";
            // 
            // toolStripBtnNew
            // 
            resources.ApplyResources(this.toolStripBtnNew, "toolStripBtnNew");
            this.toolStripBtnNew.Name = "toolStripBtnNew";
            this.toolStripBtnNew.Click += new System.EventHandler(this.toolStripBtnNew_Click);
            // 
            // toolStripbtnHoldSales
            // 
            resources.ApplyResources(this.toolStripbtnHoldSales, "toolStripbtnHoldSales");
            this.toolStripbtnHoldSales.Name = "toolStripbtnHoldSales";
            this.toolStripbtnHoldSales.Click += new System.EventHandler(this.toolStripbtnHoldSales_Click);
            // 
            // toolStripReturn
            // 
            resources.ApplyResources(this.toolStripReturn, "toolStripReturn");
            this.toolStripReturn.Name = "toolStripReturn";
            this.toolStripReturn.Click += new System.EventHandler(this.toolStripReturn_Click);
            // 
            // toolStripBtnCashier
            // 
            this.toolStripBtnCashier.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.toolStripBtnCashier, "toolStripBtnCashier");
            this.toolStripBtnCashier.Name = "toolStripBtnCashier";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackColor = System.Drawing.Color.IndianRed;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPromoCode
            // 
            resources.ApplyResources(this.lblPromoCode, "lblPromoCode");
            this.lblPromoCode.Name = "lblPromoCode";
            // 
            // txtPromoCode
            // 
            resources.ApplyResources(this.txtPromoCode, "txtPromoCode");
            // 
            // 
            // 
            this.txtPromoCode.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txtPromoCode.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.txtPromoCode.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.txtPromoCode.CustomButton.Name = "";
            this.txtPromoCode.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.txtPromoCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPromoCode.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.txtPromoCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPromoCode.CustomButton.UseSelectable = true;
            this.txtPromoCode.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txtPromoCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPromoCode.Lines = new string[0];
            this.txtPromoCode.MaxLength = 32767;
            this.txtPromoCode.Name = "txtPromoCode";
            this.txtPromoCode.PasswordChar = '\0';
            this.txtPromoCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPromoCode.SelectedText = "";
            this.txtPromoCode.SelectionLength = 0;
            this.txtPromoCode.SelectionStart = 0;
            this.txtPromoCode.ShortcutsEnabled = true;
            this.txtPromoCode.UseSelectable = true;
            this.txtPromoCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPromoCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbxCustomerType
            // 
            this.cbxCustomerType.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.cbxCustomerType, "cbxCustomerType");
            this.cbxCustomerType.FormattingEnabled = true;
            this.cbxCustomerType.Items.AddRange(new object[] {
            resources.GetString("cbxCustomerType.Items"),
            resources.GetString("cbxCustomerType.Items1")});
            this.cbxCustomerType.Name = "cbxCustomerType";
            this.cbxCustomerType.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerType_SelectedIndexChanged);
            this.cbxCustomerType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCustomerType_KeyPress);
            // 
            // CustEditBox
            // 
            this.CustEditBox.BackColor = System.Drawing.SystemColors.Info;
            // 
            // 
            // 
            this.CustEditBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.CustEditBox.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode2")));
            this.CustEditBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.CustEditBox.CustomButton.Margin = ((System.Windows.Forms.Padding)(resources.GetObject("resource.Margin")));
            this.CustEditBox.CustomButton.Name = "";
            this.CustEditBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.CustEditBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.CustEditBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.CustEditBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.CustEditBox.CustomButton.UseSelectable = true;
            this.CustEditBox.Lines = new string[0];
            resources.ApplyResources(this.CustEditBox, "CustEditBox");
            this.CustEditBox.MaxLength = 32767;
            this.CustEditBox.Name = "CustEditBox";
            this.CustEditBox.PasswordChar = '\0';
            this.CustEditBox.PromptText = "Type And Search Customer";
            this.CustEditBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CustEditBox.SelectedText = "";
            this.CustEditBox.SelectionLength = 0;
            this.CustEditBox.SelectionStart = 0;
            this.CustEditBox.ShortcutsEnabled = true;
            this.CustEditBox.ShowButton = true;
            this.CustEditBox.Style = MetroFramework.MetroColorStyle.Brown;
            this.CustEditBox.UseSelectable = true;
            this.CustEditBox.WaterMark = "Type And Search Customer";
            this.CustEditBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.CustEditBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.CustEditBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustEditBox_KeyPress);
            // 
            // pnlSalesAccounts
            // 
            resources.ApplyResources(this.pnlSalesAccounts, "pnlSalesAccounts");
            this.pnlSalesAccounts.Controls.Add(this.cbxTaxPayables);
            this.pnlSalesAccounts.Controls.Add(this.cbxNaturalAccounts);
            this.pnlSalesAccounts.Controls.Add(this.lblTaxAcccount);
            this.pnlSalesAccounts.Controls.Add(this.lblSaleAccount);
            this.pnlSalesAccounts.Controls.Add(this.lblCashAccount);
            this.pnlSalesAccounts.Controls.Add(this.cbxCashAccounts);
            this.pnlSalesAccounts.Name = "pnlSalesAccounts";
            // 
            // cbxTaxPayables
            // 
            resources.ApplyResources(this.cbxTaxPayables, "cbxTaxPayables");
            this.cbxTaxPayables.FormattingEnabled = true;
            this.cbxTaxPayables.Name = "cbxTaxPayables";
            this.cbxTaxPayables.SelectedIndexChanged += new System.EventHandler(this.cbxTaxPayables_SelectedIndexChanged);
            // 
            // cbxNaturalAccounts
            // 
            resources.ApplyResources(this.cbxNaturalAccounts, "cbxNaturalAccounts");
            this.cbxNaturalAccounts.FormattingEnabled = true;
            this.cbxNaturalAccounts.Name = "cbxNaturalAccounts";
            this.cbxNaturalAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxNaturalAccounts_SelectedIndexChanged);
            // 
            // lblTaxAcccount
            // 
            resources.ApplyResources(this.lblTaxAcccount, "lblTaxAcccount");
            this.lblTaxAcccount.Name = "lblTaxAcccount";
            // 
            // lblSaleAccount
            // 
            resources.ApplyResources(this.lblSaleAccount, "lblSaleAccount");
            this.lblSaleAccount.Name = "lblSaleAccount";
            // 
            // lblCashAccount
            // 
            resources.ApplyResources(this.lblCashAccount, "lblCashAccount");
            this.lblCashAccount.Name = "lblCashAccount";
            // 
            // cbxCashAccounts
            // 
            resources.ApplyResources(this.cbxCashAccounts, "cbxCashAccounts");
            this.cbxCashAccounts.FormattingEnabled = true;
            this.cbxCashAccounts.Name = "cbxCashAccounts";
            this.cbxCashAccounts.SelectedIndexChanged += new System.EventHandler(this.cbxCashAccounts_SelectedIndexChanged);
            // 
            // lblInvoiceTotalWithTax
            // 
            resources.ApplyResources(this.lblInvoiceTotalWithTax, "lblInvoiceTotalWithTax");
            this.lblInvoiceTotalWithTax.BackColor = System.Drawing.SystemColors.Control;
            this.lblInvoiceTotalWithTax.Name = "lblInvoiceTotalWithTax";
            // 
            // txtInvoiceTotalWithTax
            // 
            resources.ApplyResources(this.txtInvoiceTotalWithTax, "txtInvoiceTotalWithTax");
            this.txtInvoiceTotalWithTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtInvoiceTotalWithTax.Name = "txtInvoiceTotalWithTax";
            // 
            // lblTotalWithDicount
            // 
            resources.ApplyResources(this.lblTotalWithDicount, "lblTotalWithDicount");
            this.lblTotalWithDicount.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalWithDicount.Name = "lblTotalWithDicount";
            // 
            // txtInvoiceTotalAfterDiscount
            // 
            resources.ApplyResources(this.txtInvoiceTotalAfterDiscount, "txtInvoiceTotalAfterDiscount");
            this.txtInvoiceTotalAfterDiscount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtInvoiceTotalAfterDiscount.Name = "txtInvoiceTotalAfterDiscount";
            // 
            // lblTaxAmount
            // 
            resources.ApplyResources(this.lblTaxAmount, "lblTaxAmount");
            this.lblTaxAmount.BackColor = System.Drawing.SystemColors.Control;
            this.lblTaxAmount.Name = "lblTaxAmount";
            // 
            // txtTotalTaxAmount
            // 
            resources.ApplyResources(this.txtTotalTaxAmount, "txtTotalTaxAmount");
            this.txtTotalTaxAmount.Name = "txtTotalTaxAmount";
            // 
            // chkNoPrint
            // 
            resources.ApplyResources(this.chkNoPrint, "chkNoPrint");
            this.chkNoPrint.Name = "chkNoPrint";
            this.chkNoPrint.UseVisualStyleBackColor = true;
            // 
            // btnReadyOrders
            // 
            resources.ApplyResources(this.btnReadyOrders, "btnReadyOrders");
            this.btnReadyOrders.BackColor = System.Drawing.Color.IndianRed;
            this.btnReadyOrders.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReadyOrders.ForeColor = System.Drawing.Color.White;
            this.btnReadyOrders.Name = "btnReadyOrders";
            this.btnReadyOrders.UseVisualStyleBackColor = false;
            this.btnReadyOrders.Click += new System.EventHandler(this.btnReadyOrders_Click);
            // 
            // btnSendKitchen
            // 
            resources.ApplyResources(this.btnSendKitchen, "btnSendKitchen");
            this.btnSendKitchen.BackColor = System.Drawing.Color.IndianRed;
            this.btnSendKitchen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSendKitchen.ForeColor = System.Drawing.Color.White;
            this.btnSendKitchen.Name = "btnSendKitchen";
            this.btnSendKitchen.UseVisualStyleBackColor = false;
            this.btnSendKitchen.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.txtCustomerName.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode3")));
            this.txtCustomerName.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.txtCustomerName.Lines = new string[0];
            resources.ApplyResources(this.txtCustomerName, "txtCustomerName");
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PromptText = "Customer Name Here....";
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMark = "Customer Name Here....";
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // txtOrderTime
            // 
            resources.ApplyResources(this.txtOrderTime, "txtOrderTime");
            this.txtOrderTime.Name = "txtOrderTime";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Name = "label1";
            // 
            // cbxOrderType
            // 
            this.cbxOrderType.FormattingEnabled = true;
            this.cbxOrderType.Items.AddRange(new object[] {
            resources.GetString("cbxOrderType.Items"),
            resources.GetString("cbxOrderType.Items1"),
            resources.GetString("cbxOrderType.Items2"),
            resources.GetString("cbxOrderType.Items3"),
            resources.GetString("cbxOrderType.Items4")});
            resources.ApplyResources(this.cbxOrderType, "cbxOrderType");
            this.cbxOrderType.Name = "cbxOrderType";
            this.cbxOrderType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxOrderType_KeyPress);
            // 
            // txtContact
            // 
            // 
            // 
            // 
            this.txtContact.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.txtContact.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode4")));
            this.txtContact.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location4")));
            this.txtContact.CustomButton.Name = "";
            this.txtContact.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size4")));
            this.txtContact.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContact.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex4")));
            this.txtContact.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContact.CustomButton.UseSelectable = true;
            this.txtContact.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.txtContact.Lines = new string[0];
            resources.ApplyResources(this.txtContact, "txtContact");
            this.txtContact.MaxLength = 32767;
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.PromptText = "Write Contact Here....";
            this.txtContact.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContact.SelectedText = "";
            this.txtContact.SelectionLength = 0;
            this.txtContact.SelectionStart = 0;
            this.txtContact.ShortcutsEnabled = true;
            this.txtContact.UseSelectable = true;
            this.txtContact.WaterMark = "Write Contact Here....";
            this.txtContact.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContact.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContact_KeyPress);
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.txtAddress.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode5")));
            this.txtAddress.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location5")));
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size5")));
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex5")));
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            this.txtAddress.Lines = new string[0];
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PromptText = "Customer Address Here....";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMark = "Customer Address Here....";
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddress_KeyPress);
            // 
            // btncancelorder
            // 
            resources.ApplyResources(this.btncancelorder, "btncancelorder");
            this.btncancelorder.BackColor = System.Drawing.Color.IndianRed;
            this.btncancelorder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btncancelorder.ForeColor = System.Drawing.Color.White;
            this.btncancelorder.Name = "btncancelorder";
            this.btncancelorder.UseVisualStyleBackColor = false;
            this.btncancelorder.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblOrderStatus
            // 
            resources.ApplyResources(this.lblOrderStatus, "lblOrderStatus");
            this.lblOrderStatus.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblOrderStatus.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblOrderStatus.ForeColor = System.Drawing.Color.Red;
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.UseCustomBackColor = true;
            this.lblOrderStatus.UseCustomForeColor = true;
            // 
            // grdProducts
            // 
            this.grdProducts.AllowUserToAddRows = false;
            this.grdProducts.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.grdProducts, "grdProducts");
            this.grdProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdVoucherDetail,
            this.colIdItem,
            this.colBarCode,
            this.colItemName,
            this.colPackingSize,
            this.colQuantity,
            this.colUnitPrice,
            this.colAmount,
            this.colDiscInPercentage,
            this.colNetAmount,
            this.colMinus,
            this.colAdd,
            this.colDelete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdProducts.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdProducts.EnableHeadersVisualStyles = false;
            this.grdProducts.MultiSelect = false;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdProducts.RowHeadersVisible = false;
            this.grdProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellClick);
            this.grdProducts.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducts_CellEndEdit);
            this.grdProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdProducts_CellFormatting);
            // 
            // ColIdVoucherDetail
            // 
            this.ColIdVoucherDetail.FillWeight = 76.81622F;
            resources.ApplyResources(this.ColIdVoucherDetail, "ColIdVoucherDetail");
            this.ColIdVoucherDetail.Name = "ColIdVoucherDetail";
            // 
            // colIdItem
            // 
            resources.ApplyResources(this.colIdItem, "colIdItem");
            this.colIdItem.Name = "colIdItem";
            this.colIdItem.ReadOnly = true;
            // 
            // colBarCode
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colBarCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.colBarCode.FillWeight = 122.2759F;
            resources.ApplyResources(this.colBarCode, "colBarCode");
            this.colBarCode.Name = "colBarCode";
            this.colBarCode.ReadOnly = true;
            // 
            // colItemName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colItemName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colItemName.FillWeight = 383.448F;
            resources.ApplyResources(this.colItemName, "colItemName");
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colPackingSize
            // 
            this.colPackingSize.FillWeight = 122.9514F;
            resources.ApplyResources(this.colPackingSize, "colPackingSize");
            this.colPackingSize.Name = "colPackingSize";
            this.colPackingSize.ReadOnly = true;
            // 
            // colQuantity
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.colQuantity.FillWeight = 114.9516F;
            resources.ApplyResources(this.colQuantity, "colQuantity");
            this.colQuantity.Name = "colQuantity";
            // 
            // colUnitPrice
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colUnitPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.colUnitPrice.FillWeight = 115.7017F;
            resources.ApplyResources(this.colUnitPrice, "colUnitPrice");
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAmount.FillWeight = 143.4851F;
            resources.ApplyResources(this.colAmount, "colAmount");
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colDiscInPercentage
            // 
            this.colDiscInPercentage.FillWeight = 90.09012F;
            resources.ApplyResources(this.colDiscInPercentage, "colDiscInPercentage");
            this.colDiscInPercentage.Name = "colDiscInPercentage";
            // 
            // colNetAmount
            // 
            this.colNetAmount.FillWeight = 30.11044F;
            resources.ApplyResources(this.colNetAmount, "colNetAmount");
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.ReadOnly = true;
            // 
            // colMinus
            // 
            this.colMinus.FillWeight = 0.05660545F;
            resources.ApplyResources(this.colMinus, "colMinus");
            this.colMinus.Name = "colMinus";
            this.colMinus.ReadOnly = true;
            // 
            // colAdd
            // 
            this.colAdd.FillWeight = 0.05660545F;
            resources.ApplyResources(this.colAdd, "colAdd");
            this.colAdd.Name = "colAdd";
            this.colAdd.ReadOnly = true;
            // 
            // colDelete
            // 
            this.colDelete.FillWeight = 0.05660545F;
            resources.ApplyResources(this.colDelete, "colDelete");
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.FillWeight = 20.30457F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn3.FillWeight = 657.868F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn4.FillWeight = 20.30457F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn5.FillWeight = 20.30457F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn6.FillWeight = 20.30457F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn7.FillWeight = 203.7314F;
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn9, "dataGridViewTextBoxColumn9");
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // frmPosInvoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.lblOrderStatus);
            this.Controls.Add(this.cbxOrderType);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.txtInvoiceNumber);
            this.Controls.Add(this.pnlSalesAccounts);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtPromoCode);
            this.Controls.Add(this.lblPromoCode);
            this.Controls.Add(this.chkNoPrint);
            this.Controls.Add(this.VInvoiceDate);
            this.Controls.Add(this.CustEditBox);
            this.Controls.Add(this.cbxCustomerType);
            this.Controls.Add(this.toolPosStrip);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.cbxProducts);
            this.Controls.Add(this.lblTotalWithDicount);
            this.Controls.Add(this.lblFreeVoucher);
            this.Controls.Add(this.lblPayMode);
            this.Controls.Add(this.lblCashRecieved);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblCardNo);
            this.Controls.Add(this.grdProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalItems);
            this.Controls.Add(this.txtOrderTime);
            this.Controls.Add(this.txtTotalItems);
            this.Controls.Add(this.lblInvoiceTotal);
            this.Controls.Add(this.cbxPaymentMode);
            this.Controls.Add(this.txtTotalTaxAmount);
            this.Controls.Add(this.txtTotalTax);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtFreeVoucher);
            this.Controls.Add(this.txtInvoiceTotalWithTax);
            this.Controls.Add(this.txtInvoiceTotalAfterDiscount);
            this.Controls.Add(this.txtInvoiceTotal);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.txtCashRecieved);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lblTaxPercentage);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.lblInvoiceTotalWithTax);
            this.Controls.Add(this.btnSendKitchen);
            this.Controls.Add(this.btncancelorder);
            this.Controls.Add(this.btnReadyOrders);
            this.Controls.Add(this.btnSave);
            this.KeyPreview = true;
            this.Name = "frmPosInvoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPosInvoice_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmPosInvoice_KeyPress);
            this.toolPosStrip.ResumeLayout(false);
            this.toolPosStrip.PerformLayout();
            this.pnlSalesAccounts.ResumeLayout(false);
            this.pnlSalesAccounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private MetroFramework.Controls.MetroTextBox txtInvoiceNumber;
        private System.Windows.Forms.DateTimePicker VInvoiceDate;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblTotalItems;
        private System.Windows.Forms.TextBox txtTotalItems;
        private System.Windows.Forms.TextBox txtTotalTax;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtFreeVoucher;
        private System.Windows.Forms.TextBox txtInvoiceTotal;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.TextBox txtCashRecieved;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblTaxPercentage;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblFreeVoucher;
        private System.Windows.Forms.Label lblInvoiceTotal;
        private System.Windows.Forms.Label lblPayMode;
        private System.Windows.Forms.Label lblCashRecieved;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox cbxPaymentMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox cbxProducts;
        private System.Windows.Forms.ToolStrip toolPosStrip;
        private System.Windows.Forms.ToolStripButton toolStripBtnNew;
        private System.Windows.Forms.ToolStripButton toolStripbtnHoldSales;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripButton toolStripBtnCashier;
        private System.Windows.Forms.Label lblPromoCode;
        private MetroFramework.Controls.MetroTextBox txtPromoCode;
        private System.Windows.Forms.ToolStripButton toolStripReturn;
        private System.Windows.Forms.ComboBox cbxCustomerType;
        private MetroFramework.Controls.MetroTextBox CustEditBox;
        private System.Windows.Forms.Panel pnlSalesAccounts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label lblInvoiceTotalWithTax;
        private System.Windows.Forms.TextBox txtInvoiceTotalWithTax;
        private System.Windows.Forms.Label lblTotalWithDicount;
        private System.Windows.Forms.TextBox txtInvoiceTotalAfterDiscount;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.TextBox txtTotalTaxAmount;
        private System.Windows.Forms.CheckBox chkNoPrint;
        private System.Windows.Forms.ComboBox cbxCashAccounts;
        private System.Windows.Forms.Label lblCashAccount;
        private System.Windows.Forms.ComboBox cbxNaturalAccounts;
        private System.Windows.Forms.ComboBox cbxTaxPayables;
        private System.Windows.Forms.Label lblSaleAccount;
        private System.Windows.Forms.Label lblTaxAcccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnReadyOrders;
        private System.Windows.Forms.Button btnSendKitchen;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtOrderTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxOrderType;
        private MetroFramework.Controls.MetroTextBox txtContact;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private System.Windows.Forms.Button btncancelorder;
        private MetroFramework.Controls.MetroLabel lblOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdVoucherDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackingSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscInPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colMinus;
        private System.Windows.Forms.DataGridViewButtonColumn colAdd;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private TabDataGrid grdProducts;
    }
}