namespace Accounts.UI
{
    partial class frmChefViewOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdOrderDetail = new System.Windows.Forms.DataGridView();
            this.colViewItem = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPackingSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscInPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrderDetail
            // 
            this.grdOrderDetail.AllowUserToAddRows = false;
            this.grdOrderDetail.AllowUserToDeleteRows = false;
            this.grdOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOrderDetail.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOrderDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdOrderDetail.ColumnHeadersHeight = 35;
            this.grdOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdItem,
            this.colBarCode,
            this.colItemName,
            this.colPackingSize,
            this.colQuantity,
            this.colUnitPrice,
            this.colAmount,
            this.colDiscInPercentage,
            this.colNetAmount,
            this.colViewItem});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOrderDetail.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdOrderDetail.EnableHeadersVisualStyles = false;
            this.grdOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.grdOrderDetail.MultiSelect = false;
            this.grdOrderDetail.Name = "grdOrderDetail";
            this.grdOrderDetail.ReadOnly = true;
            this.grdOrderDetail.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.grdOrderDetail.RowHeadersVisible = false;
            this.grdOrderDetail.Size = new System.Drawing.Size(1002, 480);
            this.grdOrderDetail.TabIndex = 11;
            this.grdOrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOrderDetail_CellClick);
            this.grdOrderDetail.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grdOrderDetail_CellFormatting);
            // 
            // colViewItem
            // 
            this.colViewItem.HeaderText = "...";
            this.colViewItem.MinimumWidth = 50;
            this.colViewItem.Name = "colViewItem";
            this.colViewItem.ReadOnly = true;
            this.colViewItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colViewItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IdItem";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn2.FillWeight = 406.0914F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Bar Code";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 243;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn3.FillWeight = 39.66759F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Item Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 220;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 220;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Packing";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 70;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn5.FillWeight = 49.53582F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 65;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 65;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn6.FillWeight = 100.4099F;
            this.dataGridViewTextBoxColumn6.HeaderText = "Rate";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 65;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 65;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn7.FillWeight = 203.7314F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 80;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 107;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Disc(%)";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 50;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 59;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Net Amount";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 100;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 116;
            // 
            // colIdItem
            // 
            this.colIdItem.HeaderText = "IdItem";
            this.colIdItem.Name = "colIdItem";
            this.colIdItem.ReadOnly = true;
            this.colIdItem.Visible = false;
            // 
            // colBarCode
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colBarCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.colBarCode.FillWeight = 406.0914F;
            this.colBarCode.HeaderText = "Bar Code";
            this.colBarCode.MinimumWidth = 70;
            this.colBarCode.Name = "colBarCode";
            this.colBarCode.ReadOnly = true;
            // 
            // colItemName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colItemName.DefaultCellStyle = dataGridViewCellStyle3;
            this.colItemName.FillWeight = 39.66759F;
            this.colItemName.HeaderText = "Item Name";
            this.colItemName.MinimumWidth = 220;
            this.colItemName.Name = "colItemName";
            this.colItemName.ReadOnly = true;
            // 
            // colPackingSize
            // 
            this.colPackingSize.HeaderText = "Packing";
            this.colPackingSize.MinimumWidth = 70;
            this.colPackingSize.Name = "colPackingSize";
            this.colPackingSize.ReadOnly = true;
            // 
            // colQuantity
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.colQuantity.FillWeight = 49.53582F;
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 65;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colUnitPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.colUnitPrice.FillWeight = 100.4099F;
            this.colUnitPrice.HeaderText = "Rate";
            this.colUnitPrice.MinimumWidth = 65;
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.ReadOnly = true;
            // 
            // colAmount
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colAmount.DefaultCellStyle = dataGridViewCellStyle6;
            this.colAmount.FillWeight = 203.7314F;
            this.colAmount.HeaderText = "Amount";
            this.colAmount.MinimumWidth = 80;
            this.colAmount.Name = "colAmount";
            this.colAmount.ReadOnly = true;
            // 
            // colDiscInPercentage
            // 
            this.colDiscInPercentage.HeaderText = "Disc(%)";
            this.colDiscInPercentage.MinimumWidth = 50;
            this.colDiscInPercentage.Name = "colDiscInPercentage";
            this.colDiscInPercentage.ReadOnly = true;
            // 
            // colNetAmount
            // 
            this.colNetAmount.HeaderText = "Net Amount";
            this.colNetAmount.MinimumWidth = 100;
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.ReadOnly = true;
            // 
            // frmChefViewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1002, 480);
            this.Controls.Add(this.grdOrderDetail);
            this.Name = "frmChefViewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Order Detail";
            this.Load += new System.EventHandler(this.frmChefViewOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPackingSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscInPercentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNetAmount;
        private System.Windows.Forms.DataGridViewButtonColumn colViewItem;
    }
}