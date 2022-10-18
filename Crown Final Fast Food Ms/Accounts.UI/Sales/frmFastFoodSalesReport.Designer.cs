namespace Accounts.UI
{
    partial class frmFastFoodSalesReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLoad = new MetroFramework.Controls.MetroButton();
            this.cbxReportType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtEnd = new MetroFramework.Controls.MetroDateTime();
            this.dtStart = new MetroFramework.Controls.MetroDateTime();
            this.ReportLedger = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 62);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(578, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fast Food Sales Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.cbxReportType);
            this.panel2.Controls.Add(this.metroLabel3);
            this.panel2.Controls.Add(this.metroLabel2);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Controls.Add(this.dtEnd);
            this.panel2.Controls.Add(this.dtStart);
            this.panel2.Location = new System.Drawing.Point(4, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 63);
            this.panel2.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(717, 16);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(92, 29);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Report";
            this.btnLoad.UseSelectable = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbxReportType
            // 
            this.cbxReportType.FormattingEnabled = true;
            this.cbxReportType.ItemHeight = 23;
            this.cbxReportType.Items.AddRange(new object[] {
            "",
            "Sales Type Summary",
            "Delivery Type Sales Summary"});
            this.cbxReportType.Location = new System.Drawing.Point(493, 16);
            this.cbxReportType.Name = "cbxReportType";
            this.cbxReportType.Size = new System.Drawing.Size(218, 29);
            this.cbxReportType.TabIndex = 3;
            this.cbxReportType.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(444, 19);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Type :";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(226, 19);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(31, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "To :";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(7, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "From :";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(261, 15);
            this.dtEnd.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(177, 29);
            this.dtEnd.TabIndex = 1;
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(62, 14);
            this.dtStart.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(158, 29);
            this.dtStart.TabIndex = 1;
            // 
            // ReportLedger
            // 
            this.ReportLedger.ActiveViewIndex = -1;
            this.ReportLedger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportLedger.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReportLedger.Cursor = System.Windows.Forms.Cursors.Default;
            this.ReportLedger.Location = new System.Drawing.Point(7, 132);
            this.ReportLedger.Name = "ReportLedger";
            this.ReportLedger.Size = new System.Drawing.Size(849, 314);
            this.ReportLedger.TabIndex = 2;
            this.ReportLedger.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmFastFoodSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.ReportLedger);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmFastFoodSalesReport";
            this.Text = "Fast Food Sales Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtStart;
        private MetroFramework.Controls.MetroButton btnLoad;
        private MetroFramework.Controls.MetroComboBox cbxReportType;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtEnd;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer ReportLedger;
    }
}