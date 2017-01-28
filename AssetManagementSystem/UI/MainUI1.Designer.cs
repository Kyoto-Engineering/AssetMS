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
            this.SuspendLayout();
            // 
            // CreateAssetButton
            // 
            this.CreateAssetButton.Location = new System.Drawing.Point(12, 72);
            this.CreateAssetButton.Name = "CreateAssetButton";
            this.CreateAssetButton.Size = new System.Drawing.Size(93, 67);
            this.CreateAssetButton.TabIndex = 0;
            this.CreateAssetButton.Text = "Create Asset Details";
            this.CreateAssetButton.UseVisualStyleBackColor = true;
            this.CreateAssetButton.Click += new System.EventHandler(this.CreateAssetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Asset Management System";
            // 
            // btnRegistration
            // 
            this.btnRegistration.Location = new System.Drawing.Point(12, 159);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(93, 57);
            this.btnRegistration.TabIndex = 2;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = true;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // MainUI1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 261);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateAssetButton);
            this.Name = "MainUI1";
            this.Text = "MainUI1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateAssetButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox lblUser;
        private System.Windows.Forms.Button btnRegistration;
    }
}