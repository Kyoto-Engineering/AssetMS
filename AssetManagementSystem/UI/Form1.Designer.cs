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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblStability = new System.Windows.Forms.Label();
            this.cmbStability = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.cmbTypeOfAsset = new System.Windows.Forms.ComboBox();
            this.lblTypeOfAsset = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbNameOfAsset = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
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
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblUnins = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Yellow;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(813, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 55);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Blue;
            this.lblDescription.Location = new System.Drawing.Point(61, 303);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(109, 22);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description:";
            // 
            // lblStability
            // 
            this.lblStability.AutoSize = true;
            this.lblStability.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStability.ForeColor = System.Drawing.Color.Blue;
            this.lblStability.Location = new System.Drawing.Point(91, 168);
            this.lblStability.Name = "lblStability";
            this.lblStability.Size = new System.Drawing.Size(82, 22);
            this.lblStability.TabIndex = 10;
            this.lblStability.Text = "Stability:";
            // 
            // cmbStability
            // 
            this.cmbStability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStability.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStability.FormattingEnabled = true;
            this.cmbStability.Location = new System.Drawing.Point(179, 167);
            this.cmbStability.Name = "cmbStability";
            this.cmbStability.Size = new System.Drawing.Size(223, 30);
            this.cmbStability.TabIndex = 19;
            this.cmbStability.SelectedIndexChanged += new System.EventHandler(this.cmbStability_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 117);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 25);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.Value = new System.DateTime(2016, 12, 16, 21, 18, 41, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.ForeColor = System.Drawing.Color.Blue;
            this.lblPurchaseDate.Location = new System.Drawing.Point(41, 117);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(135, 22);
            this.lblPurchaseDate.TabIndex = 33;
            this.lblPurchaseDate.Text = "Purchase Date:";
            // 
            // cmbTypeOfAsset
            // 
            this.cmbTypeOfAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeOfAsset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypeOfAsset.FormattingEnabled = true;
            this.cmbTypeOfAsset.Location = new System.Drawing.Point(179, 214);
            this.cmbTypeOfAsset.Name = "cmbTypeOfAsset";
            this.cmbTypeOfAsset.Size = new System.Drawing.Size(334, 30);
            this.cmbTypeOfAsset.TabIndex = 26;
            this.cmbTypeOfAsset.SelectedIndexChanged += new System.EventHandler(this.cmbTypeOfAsset_SelectedIndexChanged);
            // 
            // lblTypeOfAsset
            // 
            this.lblTypeOfAsset.AutoSize = true;
            this.lblTypeOfAsset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfAsset.ForeColor = System.Drawing.Color.Blue;
            this.lblTypeOfAsset.Location = new System.Drawing.Point(45, 214);
            this.lblTypeOfAsset.Name = "lblTypeOfAsset";
            this.lblTypeOfAsset.Size = new System.Drawing.Size(129, 22);
            this.lblTypeOfAsset.TabIndex = 25;
            this.lblTypeOfAsset.Text = "Type Of Asset:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.Location = new System.Drawing.Point(106, 252);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 22);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Name:";
            // 
            // cmbNameOfAsset
            // 
            this.cmbNameOfAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameOfAsset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNameOfAsset.FormattingEnabled = true;
            this.cmbNameOfAsset.Location = new System.Drawing.Point(179, 252);
            this.cmbNameOfAsset.Name = "cmbNameOfAsset";
            this.cmbNameOfAsset.Size = new System.Drawing.Size(334, 30);
            this.cmbNameOfAsset.TabIndex = 37;
            this.cmbNameOfAsset.SelectedIndexChanged += new System.EventHandler(this.cmbNameOfAsset_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(179, 303);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(334, 81);
            this.txtDescription.TabIndex = 38;
            this.txtDescription.Text = "";
            // 
            // lblV_Name
            // 
            this.lblV_Name.AutoSize = true;
            this.lblV_Name.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblV_Name.ForeColor = System.Drawing.Color.Blue;
            this.lblV_Name.Location = new System.Drawing.Point(47, 402);
            this.lblV_Name.Name = "lblV_Name";
            this.lblV_Name.Size = new System.Drawing.Size(126, 22);
            this.lblV_Name.TabIndex = 40;
            this.lblV_Name.Text = "Vendor Name:";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoiceNo.ForeColor = System.Drawing.Color.Blue;
            this.lblInvoiceNo.Location = new System.Drawing.Point(69, 439);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(103, 22);
            this.lblInvoiceNo.TabIndex = 41;
            this.lblInvoiceNo.Text = "Invoice No:";
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.ForeColor = System.Drawing.Color.Blue;
            this.lblUnits.Location = new System.Drawing.Point(664, 126);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(49, 22);
            this.lblUnits.TabIndex = 43;
            this.lblUnits.Text = "Unit:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.Blue;
            this.lblUnitPrice.Location = new System.Drawing.Point(617, 213);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(97, 22);
            this.lblUnitPrice.TabIndex = 44;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // lblUnitSalvageValue
            // 
            this.lblUnitSalvageValue.AutoSize = true;
            this.lblUnitSalvageValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitSalvageValue.ForeColor = System.Drawing.Color.Blue;
            this.lblUnitSalvageValue.Location = new System.Drawing.Point(548, 250);
            this.lblUnitSalvageValue.Name = "lblUnitSalvageValue";
            this.lblUnitSalvageValue.Size = new System.Drawing.Size(168, 22);
            this.lblUnitSalvageValue.TabIndex = 46;
            this.lblUnitSalvageValue.Text = "Unit Salvage Value:";
            // 
            // lblLifeSpanInYear
            // 
            this.lblLifeSpanInYear.AutoSize = true;
            this.lblLifeSpanInYear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLifeSpanInYear.ForeColor = System.Drawing.Color.Blue;
            this.lblLifeSpanInYear.Location = new System.Drawing.Point(559, 297);
            this.lblLifeSpanInYear.Name = "lblLifeSpanInYear";
            this.lblLifeSpanInYear.Size = new System.Drawing.Size(157, 22);
            this.lblLifeSpanInYear.TabIndex = 47;
            this.lblLifeSpanInYear.Text = "Life Span In Year:";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(179, 439);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(223, 29);
            this.txtInvoiceNo.TabIndex = 49;
            this.txtInvoiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvoiceNo_KeyPress_1);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(723, 213);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(182, 29);
            this.txtUnitPrice.TabIndex = 52;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // txtUnitSalvageValue
            // 
            this.txtUnitSalvageValue.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitSalvageValue.Location = new System.Drawing.Point(723, 250);
            this.txtUnitSalvageValue.Name = "txtUnitSalvageValue";
            this.txtUnitSalvageValue.Size = new System.Drawing.Size(182, 29);
            this.txtUnitSalvageValue.TabIndex = 54;
            this.txtUnitSalvageValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitSalvageValue_KeyPress);
            // 
            // txtLifeSpanInYear
            // 
            this.txtLifeSpanInYear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLifeSpanInYear.Location = new System.Drawing.Point(723, 294);
            this.txtLifeSpanInYear.Name = "txtLifeSpanInYear";
            this.txtLifeSpanInYear.Size = new System.Drawing.Size(182, 29);
            this.txtLifeSpanInYear.TabIndex = 55;
            this.txtLifeSpanInYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLifeSpanInYear_KeyPress);
            // 
            // cmbV_Name
            // 
            this.cmbV_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbV_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbV_Name.FormattingEnabled = true;
            this.cmbV_Name.Location = new System.Drawing.Point(179, 402);
            this.cmbV_Name.Name = "cmbV_Name";
            this.cmbV_Name.Size = new System.Drawing.Size(223, 27);
            this.cmbV_Name.TabIndex = 56;
            this.cmbV_Name.SelectedIndexChanged += new System.EventHandler(this.cmbV_Name_SelectedIndexChanged);
            // 
            // cmbUnitname
            // 
            this.cmbUnitname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnitname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnitname.FormattingEnabled = true;
            this.cmbUnitname.Location = new System.Drawing.Point(723, 126);
            this.cmbUnitname.Name = "cmbUnitname";
            this.cmbUnitname.Size = new System.Drawing.Size(182, 27);
            this.cmbUnitname.TabIndex = 57;
            this.cmbUnitname.SelectedIndexChanged += new System.EventHandler(this.cmbUnitname_SelectedIndexChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(723, 170);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(182, 29);
            this.txtUnit.TabIndex = 59;
            this.txtUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnit_KeyPress);
            // 
            // lblUnins
            // 
            this.lblUnins.AutoSize = true;
            this.lblUnins.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnins.ForeColor = System.Drawing.Color.Blue;
            this.lblUnins.Location = new System.Drawing.Point(629, 170);
            this.lblUnins.Name = "lblUnins";
            this.lblUnins.Size = new System.Drawing.Size(86, 22);
            this.lblUnins.TabIndex = 60;
            this.lblUnins.Text = "Quantity:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(414, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 33);
            this.label1.TabIndex = 61;
            this.label1.Text = "Asset Entry Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(995, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblUnins);
            this.Controls.Add(this.txtUnit);
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
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbNameOfAsset);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTypeOfAsset);
            this.Controls.Add(this.cmbTypeOfAsset);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmbStability);
            this.Controls.Add(this.lblStability);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStability;
        private System.Windows.Forms.ComboBox cmbStability;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.ComboBox cmbTypeOfAsset;
        private System.Windows.Forms.Label lblTypeOfAsset;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbNameOfAsset;
        private System.Windows.Forms.RichTextBox txtDescription;
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
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblUnins;
        private System.Windows.Forms.Label label1;
    }
}

