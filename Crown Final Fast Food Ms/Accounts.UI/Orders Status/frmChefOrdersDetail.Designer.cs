namespace Accounts.UI
{
    partial class frmChefOrdersDetail
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdOrders = new System.Windows.Forms.DataGridView();
            this.colViewDetail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colPrint = new System.Windows.Forms.DataGridViewButtonColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.ordersTimer = new System.Windows.Forms.Timer(this.components);
            this.btnSignOut = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdVoucher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSaleTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDeliveryType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMyOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrders
            // 
            this.grdOrders.AllowUserToAddRows = false;
            this.grdOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOrders.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdOrders.ColumnHeadersHeight = 38;
            this.grdOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdVoucher,
            this.colOrderId,
            this.colData,
            this.colPersonName,
            this.colTotalItems,
            this.colTotalAmount,
            this.colSaleTime,
            this.colOrderStatus,
            this.colDeliveryType,
            this.colViewDetail,
            this.colUpdate,
            this.colPrint});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOrders.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdOrders.EnableHeadersVisualStyles = false;
            this.grdOrders.Location = new System.Drawing.Point(2, 41);
            this.grdOrders.MultiSelect = false;
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.ReadOnly = true;
            this.grdOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdOrders.RowHeadersVisible = false;
            this.grdOrders.Size = new System.Drawing.Size(909, 330);
            this.grdOrders.TabIndex = 11;
            this.grdOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrders_CellClick);
            this.grdOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdOrders_CellFormatting);
            // 
            // colViewDetail
            // 
            this.colViewDetail.HeaderText = "...";
            this.colViewDetail.Name = "colViewDetail";
            this.colViewDetail.ReadOnly = true;
            // 
            // colUpdate
            // 
            this.colUpdate.HeaderText = "...";
            this.colUpdate.Name = "colUpdate";
            this.colUpdate.ReadOnly = true;
            // 
            // colPrint
            // 
            this.colPrint.HeaderText = "...";
            this.colPrint.Name = "colPrint";
            this.colPrint.ReadOnly = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(117, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "Filter By Customer";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(411, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(128, 14);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(433, 23);
            this.txtCustomerName.TabIndex = 13;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCustomerName.TextChanged += new System.EventHandler(this.txtCustomerName_TextChanged);
            // 
            // ordersTimer
            // 
            this.ordersTimer.Interval = 5000;
            this.ordersTimer.Tick += new System.EventHandler(this.ordersTimer_Tick);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignOut.Location = new System.Drawing.Point(833, 14);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(75, 23);
            this.btnSignOut.TabIndex = 14;
            this.btnSignOut.Text = "SignOut";
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdVoucher";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdVoucher";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "VoucherNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Order No.";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 145;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "VDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 145;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn4.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 145;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "TotalItems";
            this.dataGridViewTextBoxColumn5.HeaderText = "TotalItems";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 144;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TotalAmount";
            this.dataGridViewTextBoxColumn6.HeaderText = "TotalAmount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 145;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SaleTime";
            this.dataGridViewTextBoxColumn7.HeaderText = "Sale Time";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 145;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "VoucherType";
            this.dataGridViewTextBoxColumn8.HeaderText = "Order Status";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 145;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DeliveryTypeDesc";
            this.dataGridViewTextBoxColumn9.HeaderText = "Delivery Type";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 82;
            // 
            // colIdVoucher
            // 
            this.colIdVoucher.DataPropertyName = "IdVoucher";
            this.colIdVoucher.HeaderText = "IdVoucher";
            this.colIdVoucher.Name = "colIdVoucher";
            this.colIdVoucher.ReadOnly = true;
            this.colIdVoucher.Visible = false;
            // 
            // colOrderId
            // 
            this.colOrderId.DataPropertyName = "VoucherNo";
            this.colOrderId.HeaderText = "Order No.";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.ReadOnly = true;
            // 
            // colData
            // 
            this.colData.DataPropertyName = "VDate";
            this.colData.HeaderText = "Date";
            this.colData.Name = "colData";
            this.colData.ReadOnly = true;
            // 
            // colPersonName
            // 
            this.colPersonName.DataPropertyName = "FirstName";
            this.colPersonName.HeaderText = "Customer Name";
            this.colPersonName.Name = "colPersonName";
            this.colPersonName.ReadOnly = true;
            // 
            // colTotalItems
            // 
            this.colTotalItems.DataPropertyName = "TotalItems";
            this.colTotalItems.HeaderText = "TotalItems";
            this.colTotalItems.Name = "colTotalItems";
            this.colTotalItems.ReadOnly = true;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.DataPropertyName = "TotalAmount";
            this.colTotalAmount.HeaderText = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.ReadOnly = true;
            // 
            // colSaleTime
            // 
            this.colSaleTime.DataPropertyName = "SaleTime";
            this.colSaleTime.HeaderText = "Sale Time";
            this.colSaleTime.Name = "colSaleTime";
            this.colSaleTime.ReadOnly = true;
            // 
            // colOrderStatus
            // 
            this.colOrderStatus.DataPropertyName = "VoucherType";
            this.colOrderStatus.HeaderText = "Order Status";
            this.colOrderStatus.Name = "colOrderStatus";
            this.colOrderStatus.ReadOnly = true;
            // 
            // colDeliveryType
            // 
            this.colDeliveryType.DataPropertyName = "DeliveryTypeDesc";
            this.colDeliveryType.HeaderText = "Delivery Type";
            this.colDeliveryType.Name = "colDeliveryType";
            this.colDeliveryType.ReadOnly = true;
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyOrders.Location = new System.Drawing.Point(759, 14);
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(75, 23);
            this.btnMyOrders.TabIndex = 14;
            this.btnMyOrders.Text = "My Orders";
            this.btnMyOrders.UseVisualStyleBackColor = true;
            this.btnMyOrders.Click += new System.EventHandler(this.btnMyOrders_Click);
            // 
            // frmChefOrdersDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(912, 374);
            this.Controls.Add(this.btnMyOrders);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.grdOrders);
            this.MinimizeBox = false;
            this.Name = "frmChefOrdersDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers Orders Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOrdersDetail_FormClosing);
            this.Load += new System.EventHandler(this.frmChefOrdersDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOrders;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private System.Windows.Forms.Timer ordersTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdVoucher;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colData;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSaleTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDeliveryType;
        private System.Windows.Forms.DataGridViewButtonColumn colViewDetail;
        private System.Windows.Forms.DataGridViewButtonColumn colUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn colPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button btnMyOrders;
    }
}