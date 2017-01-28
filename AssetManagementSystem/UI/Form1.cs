using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using AssetManagementSystem.DbGateway;
using AssetManagementSystem.UI;

namespace AssetManagementSystem
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        //public string S_Name;
        public int s_id, t_id, n_id, v_id, unit_id, TypeofAsetId, NameofAsetId, NameofVendorId, user_id;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stability();
            Vendor();
            Unit();
        }

        private void Unit()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select Unit_Name from tblUnit";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbUnitname.Items.Add(rdr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Vendor()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select V_Name from tblVendor";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbV_Name.Items.Add(rdr.GetValue(0).ToString());
                }
                cmbV_Name.Items.Add("Not In The List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Stability()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select S_Name from tblStability";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbStability.Items.Add(rdr.GetValue(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStability_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTypeOfAsset.Text = "";
            cmbTypeOfAsset.Items.Clear();
            cmbTypeOfAsset.SelectedIndex = -1;

            cmbNameOfAsset.Text = "";
            cmbNameOfAsset.Items.Clear();
            cmbNameOfAsset.SelectedIndex = -1;

            txtTypeOfAsset.Visible = false;
            txtNameOfAsset.Visible = false;
            txtDescription.Clear();

            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT S_Id from tblStability WHERE S_Name= '" + cmbStability.Text + "'";
                //cmd.CommandText = "SELECT S_Id from Stability WHERE S_Name= '" + cmbStability.Text + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    s_id = rdr.GetInt32(0);
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select distinct RTRIM(T_Name) from tblTypeOfAsset where S_Id= " + s_id + "";
                //string ct = "select distinct RTRIM(T_Name) from TypeOfAsset where S_Id= " + s_id + "";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbTypeOfAsset.Items.Add(rdr[0]);
                }
                con.Close();
                cmbTypeOfAsset.Items.Add("Not In The List");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTypeOfAsset_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNameOfAsset.Text = "";
            cmbNameOfAsset.Items.Clear();
            cmbNameOfAsset.SelectedIndex = -1;
            txtNameOfAsset.Clear();
            txtNameOfAsset.Visible = false;
            txtDescription.Clear();


            if (cmbTypeOfAsset.Text == "Not In The List")
            {
                txtTypeOfAsset.Visible = true;
                txtTypeOfAsset.Focus();

                cmbNameOfAsset.Items.Add("Not In The List");
            }
            else
            {
                txtTypeOfAsset.Clear();
                txtTypeOfAsset.Visible = false;
                try
                {
                    con = new SqlConnection(cs.DBConn);

                    con.Open();
                    cmd = con.CreateCommand();

                    cmd.CommandText = "SELECT T_Id from tblTypeOfAsset WHERE T_Name= '" + cmbTypeOfAsset.Text + "'";
                    //cmd.CommandText = "SELECT T_Id from TypeOfAsset WHERE T_Name= '" + cmbTypeOfAsset.Text + "'";
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        t_id = rdr.GetInt32(0);
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct = "select distinct RTRIM(N_Name) from tblNameOfAsset where T_Id= " + t_id + "";
                    //string ct = "select distinct RTRIM(N_Name) from NameOfAsset where T_Id= " + t_id + "";
                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        cmbNameOfAsset.Items.Add(rdr[0]);
                    }
                    con.Close();
                    cmbNameOfAsset.Items.Add("Not In The List");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbNameOfAsset_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNameOfAsset.Visible = false;
            if (cmbNameOfAsset.Text == "Not In The List")
            {
                txtNameOfAsset.Visible = true;
                txtNameOfAsset.Focus();
                txtDescription.Clear();

            }
            else
            {
                txtNameOfAsset.Visible = true;
                
                txtDescription.Clear();
                try
                {
                    con = new SqlConnection(cs.DBConn);

                    con.Open();
                    cmd = con.CreateCommand();

                    cmd.CommandText = "SELECT N_Id from tblNameOfAsset WHERE N_Name= '" + cmbNameOfAsset.Text + "'";
                    //cmd.CommandText = "SELECT T_Id from TypeOfAsset WHERE T_Name= '" + cmbTypeOfAsset.Text + "'";
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        n_id = rdr.GetInt32(0);
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbStability.Text == "")
            {
                MessageBox.Show("Please  Select Stability", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbTypeOfAsset.Text == "")
            {
                MessageBox.Show("Please Select Type of Asset", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbTypeOfAsset.Text == "Not In The List")
            {
                cmbTypeOfAsset.Text = "";
                cmbTypeOfAsset.Items.Clear();
                cmbTypeOfAsset.SelectedIndex = -1;
                txtTypeOfAsset.Clear();
                txtTypeOfAsset.Visible = false;
                cmbTypeOfAsset.Focus();

                cmbNameOfAsset.Text = "";
                cmbNameOfAsset.Items.Clear();
                cmbNameOfAsset.SelectedIndex = -1;
                txtNameOfAsset.Clear();
                txtNameOfAsset.Visible = false;

                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct = "select T_Name from tblTypeOfAsset where S_Id='" + s_id + "'";

                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        MessageBox.Show("This Type Of Asset Already Exists,Please Select From List", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        return;
                    }

                    else
                    {
                        try
                        {

                            con = new SqlConnection(cs.DBConn);
                            String query = "insert into tblTypeOfAsset (T_Name, S_Id) values (@d1,@d2)" +
                                           "SELECT CONVERT(int,SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query);
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("d1", txtTypeOfAsset.Text);
                            cmd.Parameters.AddWithValue("d2", s_id);
                            con.Open();
                            TypeofAsetId = (int) cmd.ExecuteScalar();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                TypeofAsetId = t_id;
            }
            if (cmbNameOfAsset.Text == "")
            {
                MessageBox.Show("Please  enter Asset Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cmbNameOfAsset.Text == "Not In The List")
            {
               

                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct = "select N_Name from tblNameOfAsset where T_Id='" + t_id + "'";

                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        MessageBox.Show("This Name Of Asset Already Exists,Please Select From List", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    else
                    {
                        try
                        {

                            con = new SqlConnection(cs.DBConn);
                            String query = "insert into tblNameOfAsset (N_Name, T_Id) values (@d1,@d2)" +
                                           "SELECT CONVERT(int,SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query);
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("d1", txtNameOfAsset.Text);
                            cmd.Parameters.AddWithValue("d2", t_id);
                            con.Open();
                            NameofAsetId = (int)cmd.ExecuteScalar();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                NameofAsetId = n_id;
            }

          
            if (cmbV_Name.Text == "")
            {
                MessageBox.Show("Please  enter Vendor Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbV_Name.Text == "Not In The List")
            {

                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct = "select V_Name from tblVendor where UserId='" + user_id + "'";

                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        MessageBox.Show("This Vendor Name Already Exists,Please Select From List", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }

                    else
                    {
                        try
                        {

                            con = new SqlConnection(cs.DBConn);
                            String query = "insert into tblVendor (V_Name, UserId) values (@d1,@d2)" +
                                           "SELECT CONVERT(int,SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query);
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("@d1", txtVendor.Text);
                            cmd.Parameters.AddWithValue("@d2", user_id);
                            con.Open();
                            NameofVendorId = (int)cmd.ExecuteScalar();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                NameofVendorId = v_id;
            }

            
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Please  enter Description", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtInvoiceNo.Text == "")
            {
                MessageBox.Show("Please  enter InvoiceNo", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbUnitname.Text == "")
            {
                MessageBox.Show("Please  enter Unit Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtUnitPrice.Text == "")
            {
                MessageBox.Show("Please  enter Unit Price", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtUnitSalvageValue.Text == "")
            {
                MessageBox.Show("Please  enter Unit Salvage Value", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtLifeSpanInYear.Text == "")
            {
                MessageBox.Show("Please  enter Life Span In Year", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String query = "insert into tblAssetDescription(Description, PurchaseDate, V_Id, InvoiceNo, Units, UnitPrice, U_Id, UnitSalvageValue, LifeSpanInYear, N_Id) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", txtDescription.Text);
                cmd.Parameters.AddWithValue("@d2", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@d3", NameofVendorId);
                cmd.Parameters.AddWithValue("@d4", Convert.ToDecimal(txtInvoiceNo.Text));
                cmd.Parameters.AddWithValue("@d5", Convert.ToDecimal(txtUnit.Text));
                cmd.Parameters.AddWithValue("@d6", Convert.ToDecimal(txtUnitPrice.Text));
                cmd.Parameters.AddWithValue("@d7", unit_id);
                cmd.Parameters.AddWithValue("@d8", Convert.ToDecimal(txtUnitSalvageValue.Text));
                cmd.Parameters.AddWithValue("@d9", Convert.ToDecimal(txtLifeSpanInYear.Text));
                cmd.Parameters.AddWithValue("@d10", NameofAsetId);
                
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void cmbV_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbV_Name.Text == "Not In The List")
            {
                txtVendor.Visible = true;
                txtVendor.Focus();
            }
            else
            {
                txtVendor.Clear();
                txtVendor.Visible = false;

                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT V_Id from tblVendor WHERE V_Name= '" + cmbV_Name.Text + "'";
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        v_id = rdr.GetInt32(0);
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbUnitname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT Unit_Id from tblUnit WHERE Unit_Name= '" + cmbUnitname.Text + "'";
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    unit_id = rdr.GetInt32(0);
                }
                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char) Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtUnitPrice.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void txtUnitSalvageValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char) Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtUnitSalvageValue.Text + ch, out x))
            {
                e.Handled = true;
            }

        }

        private void txtLifeSpanInYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char) Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(txtLifeSpanInYear.Text + ch, out x))
            {
                e.Handled = true;
            }

        }

        private void txtInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void txtUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

             
    }
}
            
        
   







