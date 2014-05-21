namespace Employee
{
    partial class ScanCustomerBarCodeForm
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
            this.lblScanCustomerCodeCustomerID = new System.Windows.Forms.Label();
            this.cbxScanCode = new System.Windows.Forms.ComboBox();
            this.btnScanCustomerCodeSelect = new System.Windows.Forms.Button();
            this.btnScanCustomerCodeCancel = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScanCustomerCodeCustomerID
            // 
            this.lblScanCustomerCodeCustomerID.AutoSize = true;
            this.lblScanCustomerCodeCustomerID.Location = new System.Drawing.Point(32, 40);
            this.lblScanCustomerCodeCustomerID.Name = "lblScanCustomerCodeCustomerID";
            this.lblScanCustomerCodeCustomerID.Size = new System.Drawing.Size(65, 13);
            this.lblScanCustomerCodeCustomerID.TabIndex = 0;
            this.lblScanCustomerCodeCustomerID.Text = "Customer ID";
            // 
            // cbxScanCode
            // 
            this.cbxScanCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxScanCode.FormattingEnabled = true;
            this.cbxScanCode.Location = new System.Drawing.Point(112, 37);
            this.cbxScanCode.Name = "cbxScanCode";
            this.cbxScanCode.Size = new System.Drawing.Size(121, 21);
            this.cbxScanCode.TabIndex = 1;
            // 
            // btnScanCustomerCodeSelect
            // 
            this.btnScanCustomerCodeSelect.Location = new System.Drawing.Point(49, 94);
            this.btnScanCustomerCodeSelect.Name = "btnScanCustomerCodeSelect";
            this.btnScanCustomerCodeSelect.Size = new System.Drawing.Size(75, 23);
            this.btnScanCustomerCodeSelect.TabIndex = 2;
            this.btnScanCustomerCodeSelect.Text = "Select";
            this.btnScanCustomerCodeSelect.UseVisualStyleBackColor = true;
            this.btnScanCustomerCodeSelect.Click += new System.EventHandler(this.btnScanCustomerBarCodeSelect_Click);
            // 
            // btnScanCustomerCodeCancel
            // 
            this.btnScanCustomerCodeCancel.Location = new System.Drawing.Point(131, 94);
            this.btnScanCustomerCodeCancel.Name = "btnScanCustomerCodeCancel";
            this.btnScanCustomerCodeCancel.Size = new System.Drawing.Size(75, 23);
            this.btnScanCustomerCodeCancel.TabIndex = 3;
            this.btnScanCustomerCodeCancel.Text = "Cancel";
            this.btnScanCustomerCodeCancel.UseVisualStyleBackColor = true;
            this.btnScanCustomerCodeCancel.Click += new System.EventHandler(this.btnScanCustomerBarCodeCancel_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(Model.Customer);
            // 
            // ScanCustomerBarCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 180);
            this.Controls.Add(this.btnScanCustomerCodeCancel);
            this.Controls.Add(this.btnScanCustomerCodeSelect);
            this.Controls.Add(this.cbxScanCode);
            this.Controls.Add(this.lblScanCustomerCodeCustomerID);
            this.Name = "ScanCustomerBarCodeForm";
            this.Text = "Scan Customer Bar Code";
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScanCustomerCodeCustomerID;
        private System.Windows.Forms.ComboBox cbxScanCode;
        private System.Windows.Forms.Button btnScanCustomerCodeSelect;
        private System.Windows.Forms.Button btnScanCustomerCodeCancel;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}