namespace AssetManagementSystem
{
    partial class Form1
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStability = new System.Windows.Forms.Label();
            this.cmbStability = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.cmbTypeOfAsset = new System.Windows.Forms.ComboBox();
            this.lblTypeOfAsset = new System.Windows.Forms.Label();
            this.txtTypeOfAsset = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbNameOfAsset = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtNameOfAsset = new System.Windows.Forms.TextBox();
            this.lblV_Name = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblUnitSalvageValue = new System.Windows.Forms.Label();
            this.lblLifeSpanInYear = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnitSalvageValue = new System.Windows.Forms.TextBox();
            this.txtLifeSpanInYear = new System.Windows.Forms.TextBox();
            this.cmbV_Name = new System.Windows.Forms.ComboBox();
            this.cmbUnitname = new System.Windows.Forms.ComboBox();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnins = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(594, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(48, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(727, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 43);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(698, 12);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(42, 23);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "Min";
            this.btnMin.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(746, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(59, 219);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // lblStability
            // 
            this.lblStability.AutoSize = true;
            this.lblStability.Location = new System.Drawing.Point(76, 83);
            this.lblStability.Name = "lblStability";
            this.lblStability.Size = new System.Drawing.Size(46, 13);
            this.lblStability.TabIndex = 10;
            this.lblStability.Text = "Stability:";
            // 
            // cmbStability
            // 
            this.cmbStability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStability.FormattingEnabled = true;
            this.cmbStability.Location = new System.Drawing.Point(138, 83);
            this.cmbStability.Name = "cmbStability";
            this.cmbStability.Size = new System.Drawing.Size(157, 21);
            this.cmbStability.TabIndex = 19;
            this.cmbStability.SelectedIndexChanged += new System.EventHandler(this.cmbStability_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.Value = new System.DateTime(2016, 12, 16, 21, 18, 41, 0);
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(41, 33);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(81, 13);
            this.lblPurchaseDate.TabIndex = 33;
            this.lblPurchaseDate.Text = "Purchase Date:";
            // 
            // cmbTypeOfAsset
            // 
            this.cmbTypeOfAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeOfAsset.FormattingEnabled = true;
            this.cmbTypeOfAsset.Location = new System.Drawing.Point(138, 130);
            this.cmbTypeOfAsset.Name = "cmbTypeOfAsset";
            this.cmbTypeOfAsset.Size = new System.Drawing.Size(157, 21);
            this.cmbTypeOfAsset.TabIndex = 26;
            this.cmbTypeOfAsset.SelectedIndexChanged += new System.EventHandler(this.cmbTypeOfAsset_SelectedIndexChanged);
            // 
            // lblTypeOfAsset
            // 
            this.lblTypeOfAsset.AutoSize = true;
            this.lblTypeOfAsset.Location = new System.Drawing.Point(45, 130);
            this.lblTypeOfAsset.Name = "lblTypeOfAsset";
            this.lblTypeOfAsset.Size = new System.Drawing.Size(77, 13);
            this.lblTypeOfAsset.TabIndex = 25;
            this.lblTypeOfAsset.Text = "Type Of Asset:";
            // 
            // txtTypeOfAsset
            // 
            this.txtTypeOfAsset.Location = new System.Drawing.Point(322, 130);
            this.txtTypeOfAsset.Name = "txtTypeOfAsset";
            this.txtTypeOfAsset.Size = new System.Drawing.Size(150, 20);
            this.txtTypeOfAsset.TabIndex = 35;
            this.txtTypeOfAsset.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(84, 168);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Name:";
            // 
            // cmbNameOfAsset
            // 
            this.cmbNameOfAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameOfAsset.FormattingEnabled = true;
            this.cmbNameOfAsset.Location = new System.Drawing.Point(138, 168);
            this.cmbNameOfAsset.Name = "cmbNameOfAsset";
            this.cmbNameOfAsset.Size = new System.Drawing.Size(157, 21);
            this.cmbNameOfAsset.TabIndex = 37;
            this.cmbNameOfAsset.SelectedIndexChanged += new System.EventHandler(this.cmbNameOfAsset_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(138, 219);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(157, 81);
            this.txtDescription.TabIndex = 38;
            this.txtDescription.Text = "";
            // 
            // txtNameOfAsset
            // 
            this.txtNameOfAsset.Location = new System.Drawing.Point(322, 168);
            this.txtNameOfAsset.Name = "txtNameOfAsset";
            this.txtNameOfAsset.Size = new System.Drawing.Size(150, 20);
            this.txtNameOfAsset.TabIndex = 39;
            this.txtNameOfAsset.Visible = false;
            // 
            // lblV_Name
            // 
            this.lblV_Name.AutoSize = true;
            this.lblV_Name.Location = new System.Drawing.Point(47, 318);
            this.lblV_Name.Name = "lblV_Name";
            this.lblV_Name.Size = new System.Drawing.Size(75, 13);
            this.lblV_Name.TabIndex = 40;
            this.lblV_Name.Text = "Vendor Name:";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(60, 355);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(62, 13);
            this.lblInvoiceNo.TabIndex = 41;
            this.lblInvoiceNo.Text = "Invoice No:";
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Location = new System.Drawing.Point(529, 191);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(29, 13);
            this.lblUnits.TabIndex = 43;
            this.lblUnits.Text = "Unit:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(502, 278);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(56, 13);
            this.lblUnitPrice.TabIndex = 44;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // lblUnitSalvageValue
            // 
            this.lblUnitSalvageValue.AutoSize = true;
            this.lblUnitSalvageValue.Location = new System.Drawing.Point(457, 315);
            this.lblUnitSalvageValue.Name = "lblUnitSalvageValue";
            this.lblUnitSalvageValue.Size = new System.Drawing.Size(101, 13);
            this.lblUnitSalvageValue.TabIndex = 46;
            this.lblUnitSalvageValue.Text = "Unit Salvage Value:";
            // 
            // lblLifeSpanInYear
            // 
            this.lblLifeSpanInYear.AutoSize = true;
            this.lblLifeSpanInYear.Location = new System.Drawing.Point(466, 362);
            this.lblLifeSpanInYear.Name = "lblLifeSpanInYear";
            this.lblLifeSpanInYear.Size = new System.Drawing.Size(92, 13);
            this.lblLifeSpanInYear.TabIndex = 47;
            this.lblLifeSpanInYear.Text = "Life Span In Year:";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(138, 355);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(100, 20);
            this.txtInvoiceNo.TabIndex = 49;
            this.txtInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNo_KeyPress);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(564, 278);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 52;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // txtUnitSalvageValue
            // 
            this.txtUnitSalvageValue.Location = new System.Drawing.Point(564, 315);
            this.txtUnitSalvageValue.Name = "txtUnitSalvageValue";
            this.txtUnitSalvageValue.Size = new System.Drawing.Size(100, 20);
            this.txtUnitSalvageValue.TabIndex = 54;
            this.txtUnitSalvageValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitSalvageValue_KeyPress);
            // 
            // txtLifeSpanInYear
            // 
            this.txtLifeSpanInYear.Location = new System.Drawing.Point(564, 359);
            this.txtLifeSpanInYear.Name = "txtLifeSpanInYear";
            this.txtLifeSpanInYear.Size = new System.Drawing.Size(100, 20);
            this.txtLifeSpanInYear.TabIndex = 55;
            this.txtLifeSpanInYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLifeSpanInYear_KeyPress);
            // 
            // cmbV_Name
            // 
            this.cmbV_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbV_Name.FormattingEnabled = true;
            this.cmbV_Name.Location = new System.Drawing.Point(138, 318);
            this.cmbV_Name.Name = "cmbV_Name";
            this.cmbV_Name.Size = new System.Drawing.Size(157, 21);
            this.cmbV_Name.TabIndex = 56;
            this.cmbV_Name.SelectedIndexChanged += new System.EventHandler(this.cmbV_Name_SelectedIndexChanged);
            // 
            // cmbUnitname
            // 
            this.cmbUnitname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitname.FormattingEnabled = true;
            this.cmbUnitname.Location = new System.Drawing.Point(564, 191);
            this.cmbUnitname.Name = "cmbUnitname";
            this.cmbUnitname.Size = new System.Drawing.Size(100, 21);
            this.cmbUnitname.TabIndex = 57;
            this.cmbUnitname.SelectedIndexChanged += new System.EventHandler(this.cmbUnitname_SelectedIndexChanged);
            // 
            // txtVendor
            // 
            this.txtVendor.Location = new System.Drawing.Point(302, 318);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(100, 20);
            this.txtVendor.TabIndex = 58;
            this.txtVendor.Visible = false;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(564, 235);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 20);
            this.txtUnit.TabIndex = 59;
            this.txtUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnit_KeyPress);
            // 
            // lblUnins
            // 
            this.lblUnins.AutoSize = true;
            this.lblUnins.Location = new System.Drawing.Point(524, 235);
            this.lblUnins.Name = "lblUnins";
            this.lblUnins.Size = new System.Drawing.Size(34, 13);
            this.lblUnins.TabIndex = 60;
            this.lblUnins.Text = "Units:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 443);
            this.Controls.Add(this.lblUnins);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtVendor);
            this.Controls.Add(this.cmbUnitname);
            this.Controls.Add(this.cmbV_Name);
            this.Controls.Add(this.txtLifeSpanInYear);
            this.Controls.Add(this.txtUnitSalvageValue);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtInvoiceNo);
            this.Controls.Add(this.lblLifeSpanInYear);
            this.Controls.Add(this.lblUnitSalvageValue);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.lblInvoiceNo);
            this.Controls.Add(this.lblV_Name);
            this.Controls.Add(this.txtNameOfAsset);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbNameOfAsset);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtTypeOfAsset);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTypeOfAsset);
            this.Controls.Add(this.cmbTypeOfAsset);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbStability);
            this.Controls.Add(this.lblStability);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStability;
        private System.Windows.Forms.ComboBox cmbStability;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.ComboBox cmbTypeOfAsset;
        private System.Windows.Forms.Label lblTypeOfAsset;
        private System.Windows.Forms.TextBox txtTypeOfAsset;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbNameOfAsset;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtNameOfAsset;
        private System.Windows.Forms.Label lblV_Name;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblUnitSalvageValue;
        private System.Windows.Forms.Label lblLifeSpanInYear;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitSalvageValue;
        private System.Windows.Forms.TextBox txtLifeSpanInYear;
        private System.Windows.Forms.ComboBox cmbV_Name;
        private System.Windows.Forms.ComboBox cmbUnitname;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnins;
    }
}

