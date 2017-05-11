using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssetManagementSystem.DbGateway;

namespace AssetManagementSystem.UI
{
    public partial class VendorGrid : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        private SqlDataAdapter sda;
        public VendorGrid()
        {
            InitializeComponent();
        }

        private void VendorGrid_Load(object sender, EventArgs e)
        {
            FillVendorGrid();
        }

        private void FillVendorGrid()
        {

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT tblVendor.V_Id, tblVendor.V_Name, tblVendor.Phone, tblVendor.Email, tblVendor.WebUrl, VendorAddress.VFlatNo, VendorAddress.VHouseNo, VendorAddress.VRoadNo, VendorAddress.VBlock, VendorAddress.VArea, VendorAddress.VAdditionalContactNo, PostOffice.PostOfficeName, Thanas.Thana, Districts.District FROM tblVendor LEFT JOIN VendorAddress ON tblVendor.V_Id = VendorAddress.V_Id LEFT JOIN PostOffice ON VendorAddress.PostOfficeId = PostOffice.PostOfficeId LEFT JOIN Thanas ON PostOffice.T_ID = Thanas.T_ID LEFT JOIN Districts ON Thanas.D_ID = Districts.D_ID order by tblVendor.V_Id asc", con);
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5], rdr[6], rdr[7], rdr[8], rdr[9], rdr[10], rdr[11], rdr[12], rdr[13]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //con = new SqlConnection(cs.DBConn);
            //con.Open();

            //sda = new SqlDataAdapter("SELECT tblVendor.V_Name, tblVendor.Phone, tblVendor.Email, tblVendor.WebUrl, VendorAddress.VFlatNo, VendorAddress.VHouseNo, VendorAddress.VRoadNo, VendorAddress.VBlock, VendorAddress.VArea, VendorAddress.VAdditionalContactNo, PostOffice.PostOfficeName, Thanas.Thana, Districts.District FROM tblVendor LEFT JOIN VendorAddress ON tblVendor.V_Id = VendorAddress.V_Id LEFT JOIN PostOffice ON VendorAddress.PostOfficeId = PostOffice.PostOfficeId LEFT JOIN Thanas ON PostOffice.T_ID = Thanas.T_ID LEFT JOIN Districts ON Thanas.D_ID = Districts.D_ID", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;

            //con.Close();
        }

        private void VendorGrid_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainUI1 frm = new MainUI1();
            frm.Show();
        }

        private void SearchVendorNametextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = new SqlCommand("SELECT tblVendor.V_Id, tblVendor.V_Name, tblVendor.Phone, tblVendor.Email, tblVendor.WebUrl, VendorAddress.VFlatNo, VendorAddress.VHouseNo, VendorAddress.VRoadNo, VendorAddress.VBlock, VendorAddress.VArea, VendorAddress.VAdditionalContactNo, PostOffice.PostOfficeName, Thanas.Thana, Districts.District FROM tblVendor LEFT JOIN VendorAddress ON tblVendor.V_Id = VendorAddress.V_Id LEFT JOIN PostOffice ON VendorAddress.PostOfficeId = PostOffice.PostOfficeId LEFT JOIN Thanas ON PostOffice.T_ID = Thanas.T_ID LEFT JOIN Districts ON Thanas.D_ID = Districts.D_ID where tblVendor.V_Name like '" + SearchVendorNametextBox.Text + "%' order by tblVendor.V_Id asc", con);
                
                rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                dataGridView1.Rows.Clear();
                //dataGridView1.ColumnHeadersVisible = true;
                while (rdr.Read() == true)
                {
                    dataGridView1.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3], rdr[4], rdr[5]);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
