namespace AssetManagementSystem.UI
{
    partial class frmTypeOfAssetCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTypeOfAssetCreation));
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbStability = new System.Windows.Forms.ComboBox();
            this.lblStability = new System.Windows.Forms.Label();
            this.TypeOfAssettextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.ForeColor = System.Drawing.Color.Blue;
            this.lblCategoryName.Location = new System.Drawing.Point(10, 89);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(129, 22);
            this.lblCategoryName.TabIndex = 2;
            this.lblCategoryName.Text = "Type Of Asset:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbStability);
            this.groupBox1.Controls.Add(this.lblStability);
            this.groupBox1.Controls.Add(this.lblCategoryName);
            this.groupBox1.Controls.Add(this.TypeOfAssettextBox);
            this.groupBox1.Location = new System.Drawing.Point(70, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 138);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // cmbStability
            // 
            this.cmbStability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStability.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStability.FormattingEnabled = true;
            this.cmbStability.Location = new System.Drawing.Point(146, 28);
            this.cmbStability.Name = "cmbStability";
            this.cmbStability.Size = new System.Drawing.Size(281, 30);
            this.cmbStability.TabIndex = 0;
            this.cmbStability.SelectedIndexChanged += new System.EventHandler(this.cmbStability_SelectedIndexChanged);
            this.cmbStability.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbStability_KeyDown);
            // 
            // lblStability
            // 
            this.lblStability.AutoSize = true;
            this.lblStability.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStability.ForeColor = System.Drawing.Color.Blue;
            this.lblStability.Location = new System.Drawing.Point(52, 32);
            this.lblStability.Name = "lblStability";
            this.lblStability.Size = new System.Drawing.Size(87, 22);
            this.lblStability.TabIndex = 20;
            this.lblStability.Text = "Stability :";
            // 
            // TypeOfAssettextBox
            // 
            this.TypeOfAssettextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeOfAssettextBox.Location = new System.Drawing.Point(146, 86);
            this.TypeOfAssettextBox.Name = "TypeOfAssettextBox";
            this.TypeOfAssettextBox.Size = new System.Drawing.Size(281, 29);
            this.TypeOfAssettextBox.TabIndex = 1;
            this.TypeOfAssettextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TypeOfAssettextBox_KeyDown);
            this.TypeOfAssettextBox.Leave += new System.EventHandler(this.TypeOfAssettextBox_Leave);
            // 
            // Savebutton
            // 
            this.Savebutton.BackColor = System.Drawing.Color.Lime;
            this.Savebutton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebutton.ForeColor = System.Drawing.Color.Blue;
            this.Savebutton.Location = new System.Drawing.Point(312, 246);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(124, 70);
            this.Savebutton.TabIndex = 4;
            this.Savebutton.Text = "Save ";
            this.Savebutton.UseVisualStyleBackColor = false;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(220, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Asset Type Creation";
            // 
            // frmTypeOfAssetCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(660, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Savebutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTypeOfAssetCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTypeOfAssetCreation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTypeOfAssetCreation_FormClosed);
            this.Load += new System.EventHandler(this.frmTypeOfAssetCreation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TypeOfAssettextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.ComboBox cmbStability;
        private System.Windows.Forms.Label lblStability;
        private System.Windows.Forms.Label label1;
    }
}