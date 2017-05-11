using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssetManagementSystem.LogInUI;


namespace AssetManagementSystem.UI
{
    public partial class MainUI1 : Form
    {
        public MainUI1()
        {
            InitializeComponent();
        }

        private void CreateAssetButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistration frm = new frmRegistration();
            frm.Show();
        }

        private void Allowancebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frmm = new Form2();
            frmm.Show();
        }

        private void MainUI1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            frmLogin frmmn = new frmLogin();
            frmmn.Show();
        }

        private void AssetTypeCreationbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTypeOfAssetCreation frm = new frmTypeOfAssetCreation();
            frm.Show();
        }

        private void VendorCreationbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVendorCreation frm = new frmVendorCreation();
            frm.Show();
        }

        private void VendorDetailsbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            VendorGrid frm = new VendorGrid();
            frm.Show();
        }

        private void MainUI1_Load(object sender, EventArgs e)
        {

        }
   
    }
}
