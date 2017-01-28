namespace AssetManagementSystem.UI
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAllowanceUnits = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.cmbIncumbentType = new System.Windows.Forms.ComboBox();
            this.cmbIncumbentName = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtIncumbentType = new System.Windows.Forms.TextBox();
            this.txtIncumbentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTypeOfAsset = new System.Windows.Forms.ComboBox();
            this.cmbNameOfAsset = new System.Windows.Forms.ComboBox();
            this.cmbDescription = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Allowance Units:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Allowance Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Incumbent Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Incumbent Name:";
            // 
            // txtAllowanceUnits
            // 
            this.txtAllowanceUnits.Location = new System.Drawing.Point(129, 162);
            this.txtAllowanceUnits.Name = "txtAllowanceUnits";
            this.txtAllowanceUnits.Size = new System.Drawing.Size(121, 20);
            this.txtAllowanceUnits.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(129, 206);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // cmbIncumbentType
            // 
            this.cmbIncumbentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncumbentType.FormattingEnabled = true;
            this.cmbIncumbentType.Location = new System.Drawing.Point(129, 256);
            this.cmbIncumbentType.Name = "cmbIncumbentType";
            this.cmbIncumbentType.Size = new System.Drawing.Size(121, 21);
            this.cmbIncumbentType.TabIndex = 6;
            this.cmbIncumbentType.SelectedIndexChanged += new System.EventHandler(this.cmbIncumbentType_SelectedIndexChanged);
            // 
            // cmbIncumbentName
            // 
            this.cmbIncumbentName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIncumbentName.FormattingEnabled = true;
            this.cmbIncumbentName.Location = new System.Drawing.Point(129, 316);
            this.cmbIncumbentName.Name = "cmbIncumbentName";
            this.cmbIncumbentName.Size = new System.Drawing.Size(121, 21);
            this.cmbIncumbentName.TabIndex = 7;
            this.cmbIncumbentName.SelectedIndexChanged += new System.EventHandler(this.cmbIncumbentName_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(738, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 43);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIncumbentType
            // 
            this.txtIncumbentType.Location = new System.Drawing.Point(275, 256);
            this.txtIncumbentType.Name = "txtIncumbentType";
            this.txtIncumbentType.Size = new System.Drawing.Size(100, 20);
            this.txtIncumbentType.TabIndex = 9;
            this.txtIncumbentType.Visible = false;
            // 
            // txtIncumbentName
            // 
            this.txtIncumbentName.Location = new System.Drawing.Point(275, 316);
            this.txtIncumbentName.Name = "txtIncumbentName";
            this.txtIncumbentName.Size = new System.Drawing.Size(100, 20);
            this.txtIncumbentName.TabIndex = 10;
            this.txtIncumbentName.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type Of Asset:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name Of Asset:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Description:";
            // 
            // cmbTypeOfAsset
            // 
            this.cmbTypeOfAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeOfAsset.FormattingEnabled = true;
            this.cmbTypeOfAsset.Location = new System.Drawing.Point(129, 36);
            this.cmbTypeOfAsset.Name = "cmbTypeOfAsset";
            this.cmbTypeOfAsset.Size = new System.Drawing.Size(121, 21);
            this.cmbTypeOfAsset.TabIndex = 14;
            this.cmbTypeOfAsset.SelectedIndexChanged += new System.EventHandler(this.cmbTypeOfAsset_SelectedIndexChanged);
            // 
            // cmbNameOfAsset
            // 
            this.cmbNameOfAsset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNameOfAsset.FormattingEnabled = true;
            this.cmbNameOfAsset.Location = new System.Drawing.Point(129, 77);
            this.cmbNameOfAsset.Name = "cmbNameOfAsset";
            this.cmbNameOfAsset.Size = new System.Drawing.Size(121, 21);
            this.cmbNameOfAsset.TabIndex = 15;
            this.cmbNameOfAsset.SelectedIndexChanged += new System.EventHandler(this.cmbNameOfAsset_SelectedIndexChanged);
            // 
            // cmbDescription
            // 
            this.cmbDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDescription.FormattingEnabled = true;
            this.cmbDescription.Location = new System.Drawing.Point(129, 118);
            this.cmbDescription.Name = "cmbDescription";
            this.cmbDescription.Size = new System.Drawing.Size(399, 21);
            this.cmbDescription.TabIndex = 16;
            this.cmbDescription.SelectedIndexChanged += new System.EventHandler(this.cmbDescription_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 379);
            this.Controls.Add(this.cmbDescription);
            this.Controls.Add(this.cmbNameOfAsset);
            this.Controls.Add(this.cmbTypeOfAsset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIncumbentName);
            this.Controls.Add(this.txtIncumbentType);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbIncumbentName);
            this.Controls.Add(this.cmbIncumbentType);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txtAllowanceUnits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAllowanceUnits;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cmbIncumbentType;
        private System.Windows.Forms.ComboBox cmbIncumbentName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtIncumbentType;
        private System.Windows.Forms.TextBox txtIncumbentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTypeOfAsset;
        private System.Windows.Forms.ComboBox cmbNameOfAsset;
        private System.Windows.Forms.ComboBox cmbDescription;
    }
}