namespace Employee
{
    partial class NewZipCodeForm
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
            this.labelNewZipCode = new System.Windows.Forms.Label();
            this.cbxNewZipNewState = new System.Windows.Forms.ComboBox();
            this.labelNewZipStateNew = new System.Windows.Forms.Label();
            this.txtNewZipNewCity = new System.Windows.Forms.TextBox();
            this.labelNewZipCityNew = new System.Windows.Forms.Label();
            this.btnNewZipConfirm = new System.Windows.Forms.Button();
            this.btnNewZipCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNewZipCode
            // 
            this.labelNewZipCode.AutoSize = true;
            this.labelNewZipCode.Location = new System.Drawing.Point(13, 16);
            this.labelNewZipCode.Name = "labelNewZipCode";
            this.labelNewZipCode.Size = new System.Drawing.Size(35, 13);
            this.labelNewZipCode.TabIndex = 0;
            this.labelNewZipCode.Text = "label1";
            // 
            // cbxNewZipNewState
            // 
            this.cbxNewZipNewState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxNewZipNewState.FormattingEnabled = true;
            this.cbxNewZipNewState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AR",
            "AZ",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "IA",
            "ID",
            "IL",
            "IN",
            "KS",
            "KY",
            "LA",
            "MA",
            "MD",
            "ME",
            "MI",
            "MO",
            "MN",
            "MS",
            "MT",
            "NC",
            "ND",
            "NE",
            "NH",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VA",
            "VT",
            "WA",
            "WI",
            "WV",
            "WY"});
            this.cbxNewZipNewState.Location = new System.Drawing.Point(51, 104);
            this.cbxNewZipNewState.Name = "cbxNewZipNewState";
            this.cbxNewZipNewState.Size = new System.Drawing.Size(38, 21);
            this.cbxNewZipNewState.TabIndex = 21;
            // 
            // labelNewZipStateNew
            // 
            this.labelNewZipStateNew.AutoSize = true;
            this.labelNewZipStateNew.Location = new System.Drawing.Point(13, 108);
            this.labelNewZipStateNew.Name = "labelNewZipStateNew";
            this.labelNewZipStateNew.Size = new System.Drawing.Size(32, 13);
            this.labelNewZipStateNew.TabIndex = 20;
            this.labelNewZipStateNew.Text = "State";
            // 
            // txtNewZipNewCity
            // 
            this.txtNewZipNewCity.Location = new System.Drawing.Point(51, 59);
            this.txtNewZipNewCity.Name = "txtNewZipNewCity";
            this.txtNewZipNewCity.Size = new System.Drawing.Size(132, 20);
            this.txtNewZipNewCity.TabIndex = 19;
            // 
            // labelNewZipCityNew
            // 
            this.labelNewZipCityNew.AutoSize = true;
            this.labelNewZipCityNew.Location = new System.Drawing.Point(14, 62);
            this.labelNewZipCityNew.Name = "labelNewZipCityNew";
            this.labelNewZipCityNew.Size = new System.Drawing.Size(24, 13);
            this.labelNewZipCityNew.TabIndex = 18;
            this.labelNewZipCityNew.Text = "City";
            // 
            // btnNewZipConfirm
            // 
            this.btnNewZipConfirm.Location = new System.Drawing.Point(56, 191);
            this.btnNewZipConfirm.Name = "btnNewZipConfirm";
            this.btnNewZipConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnNewZipConfirm.TabIndex = 22;
            this.btnNewZipConfirm.Text = "OK";
            this.btnNewZipConfirm.UseVisualStyleBackColor = true;
            this.btnNewZipConfirm.Click += new System.EventHandler(this.btnNewZipCodeOK_Click);
            // 
            // btnNewZipCancel
            // 
            this.btnNewZipCancel.Location = new System.Drawing.Point(150, 191);
            this.btnNewZipCancel.Name = "btnNewZipCancel";
            this.btnNewZipCancel.Size = new System.Drawing.Size(75, 23);
            this.btnNewZipCancel.TabIndex = 23;
            this.btnNewZipCancel.Text = "Cancel";
            this.btnNewZipCancel.UseVisualStyleBackColor = true;
            this.btnNewZipCancel.Click += new System.EventHandler(this.btnNewZipCodeCancel_Click);
            // 
            // NewZipCodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnNewZipCancel);
            this.Controls.Add(this.btnNewZipConfirm);
            this.Controls.Add(this.cbxNewZipNewState);
            this.Controls.Add(this.labelNewZipStateNew);
            this.Controls.Add(this.txtNewZipNewCity);
            this.Controls.Add(this.labelNewZipCityNew);
            this.Controls.Add(this.labelNewZipCode);
            this.Name = "NewZipCodeForm";
            this.Text = "NewZipCodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNewZipCode;
        private System.Windows.Forms.ComboBox cbxNewZipNewState;
        private System.Windows.Forms.Label labelNewZipStateNew;
        private System.Windows.Forms.TextBox txtNewZipNewCity;
        private System.Windows.Forms.Label labelNewZipCityNew;
        private System.Windows.Forms.Button btnNewZipConfirm;
        private System.Windows.Forms.Button btnNewZipCancel;
    }
}