namespace Accounts.UI
{
    partial class frmUpdateChefOrder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdReady = new System.Windows.Forms.RadioButton();
            this.rdCancel = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.rdCancel);
            this.groupBox1.Controls.Add(this.rdReady);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 146);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders Status";
            // 
            // rdReady
            // 
            this.rdReady.AutoSize = true;
            this.rdReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdReady.ForeColor = System.Drawing.Color.Tomato;
            this.rdReady.Location = new System.Drawing.Point(34, 27);
            this.rdReady.Name = "rdReady";
            this.rdReady.Size = new System.Drawing.Size(104, 20);
            this.rdReady.TabIndex = 0;
            this.rdReady.TabStop = true;
            this.rdReady.Text = "Order Ready";
            this.rdReady.UseVisualStyleBackColor = true;
            this.rdReady.CheckedChanged += new System.EventHandler(this.rdReady_CheckedChanged);
            // 
            // rdCancel
            // 
            this.rdCancel.AutoSize = true;
            this.rdCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdCancel.ForeColor = System.Drawing.Color.Tomato;
            this.rdCancel.Location = new System.Drawing.Point(34, 54);
            this.rdCancel.Name = "rdCancel";
            this.rdCancel.Size = new System.Drawing.Size(105, 20);
            this.rdCancel.TabIndex = 0;
            this.rdCancel.TabStop = true;
            this.rdCancel.Text = "Order Cancel";
            this.rdCancel.UseVisualStyleBackColor = true;
            this.rdCancel.CheckedChanged += new System.EventHandler(this.rdCancel_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdate.ForeColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.Location = new System.Drawing.Point(15, 92);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 45);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Location = new System.Drawing.Point(89, 92);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmUpdateChefOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 150);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmUpdateChefOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton rdCancel;
        private System.Windows.Forms.RadioButton rdReady;
    }
}