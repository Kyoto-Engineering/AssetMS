namespace AssetManagementSystem.UI
{
    partial class MainUI1
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
            this.CreateAssetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.Allowancebutton = new System.Windows.Forms.Button();
            this.VendorCreationbutton = new System.Windows.Forms.Button();
            this.AssetTypeCreationbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateAssetButton
            // 
            this.CreateAssetButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAssetButton.ForeColor = System.Drawing.Color.Crimson;
            this.CreateAssetButton.Location = new System.Drawing.Point(25, 78);
            this.CreateAssetButton.Name = "CreateAssetButton";
            this.CreateAssetButton.Size = new System.Drawing.Size(122, 67);
            this.CreateAssetButton.TabIndex = 0;
            this.CreateAssetButton.Text = "New Asset Entry";
            this.CreateAssetButton.UseVisualStyleBackColor = true;
            this.CreateAssetButton.Click += new System.EventHandler(this.CreateAssetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(211, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asset Management System";
            // 
            // btnRegistration
            // 
            this.btnRegistration.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.ForeColor = System.Drawing.Color.Crimson;
            this.btnRegistration.Location = new System.Drawing.Point(25, 396);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(122, 75);
            this.btnRegistration.TabIndex = 2;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // Allowancebutton
            // 
            this.Allowancebutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allowancebutton.ForeColor = System.Drawing.Color.Crimson;
            this.Allowancebutton.Location = new System.Drawing.Point(25, 319);
            this.Allowancebutton.Name = "Allowancebutton";
            this.Allowancebutton.Size = new System.Drawing.Size(122, 67);
            this.Allowancebutton.TabIndex = 3;
            this.Allowancebutton.Text = "Asset \r\nAllowance";
            this.Allowancebutton.UseVisualStyleBackColor = true;
            this.Allowancebutton.Click += new System.EventHandler(this.Allowancebutton_Click);
            // 
            // VendorCreationbutton
            // 
            this.VendorCreationbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendorCreationbutton.ForeColor = System.Drawing.Color.Crimson;
            this.VendorCreationbutton.Location = new System.Drawing.Point(25, 228);
            this.VendorCreationbutton.Name = "VendorCreationbutton";
            this.VendorCreationbutton.Size = new System.Drawing.Size(122, 81);
            this.VendorCreationbutton.TabIndex = 4;
            this.VendorCreationbutton.Text = "Vendor/ Supplier Registration";
            this.VendorCreationbutton.UseVisualStyleBackColor = true;
            this.VendorCreationbutton.Click += new System.EventHandler(this.VendorCreationbutton_Click);
            // 
            // AssetTypeCreationbutton
            // 
            this.AssetTypeCreationbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssetTypeCreationbutton.ForeColor = System.Drawing.Color.Crimson;
            this.AssetTypeCreationbutton.Location = new System.Drawing.Point(25, 153);
            this.AssetTypeCreationbutton.Name = "AssetTypeCreationbutton";
            this.AssetTypeCreationbutton.Size = new System.Drawing.Size(122, 67);
            this.AssetTypeCreationbutton.TabIndex = 5;
            this.AssetTypeCreationbutton.Text = "Asset Type Creation";
            this.AssetTypeCreationbutton.UseVisualStyleBackColor = true;
            this.AssetTypeCreationbutton.Click += new System.EventHandler(this.AssetTypeCreationbutton_Click);
            // 
            // MainUI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(822, 490);
            this.Controls.Add(this.AssetTypeCreationbutton);
            this.Controls.Add(this.VendorCreationbutton);
            this.Controls.Add(this.Allowancebutton);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateAssetButton);
            this.Name = "MainUI1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainUI1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainUI1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateAssetButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox lblUser;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button Allowancebutton;
        private System.Windows.Forms.Button VendorCreationbutton;
        private System.Windows.Forms.Button AssetTypeCreationbutton;
    }
}