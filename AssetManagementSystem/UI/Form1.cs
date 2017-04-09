using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using AssetManagementSystem.DbGateway;
using AssetManagementSystem.LogInUI;
using AssetManagementSystem.UI;


namespace AssetManagementSystem
{
    public partial class Form1 : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public string user_id;
        public int s_id, t_id, n_id, v_id, unit_id;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            user_id = frmLogin.uId.ToString();
            Stability();
            Unit();
            Vendor();
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



        private void TypeofAsssetLoad()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT S_Id from tblStability WHERE S_Name= '" + cmbStability.Text + "'";
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
                string ctt = "select distinct RTRIM(T_Name) from tblTypeOfAsset where S_Id= '" + s_id + "'";
                cmd = new SqlCommand(ctt);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    //cmbTypeOfAsset.Items.Add(rdr.GetValue(0).ToString());
                    cmbTypeOfAsset.Items.Add(rdr[0]);
                }
                cmbTypeOfAsset.Items.Add("Not In The List");
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

        private void NameofAsssetLoad()
        {

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT N_Id from tblNameOfAsset WHERE N_Name= '" + cmbNameOfAsset.Text + "'";

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

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select distinct RTRIM(N_Name) from tblNameOfAsset where T_Id= " + t_id + "";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbNameOfAsset.Items.Add(rdr[0]);
                }
                cmbNameOfAsset.Items.Add("Not In The List");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbStability_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTypeOfAsset.Items.Clear();
            cmbTypeOfAsset.SelectedIndex = -1;
            cmbTypeOfAsset.ResetText();

            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT S_Id from tblStability WHERE S_Name= '" + cmbStability.Text + "'";
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
                string ct = "select distinct RTRIM(T_Name) from tblTypeOfAsset where S_Id= '" + s_id + "'";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbTypeOfAsset.Items.Add(rdr[0]);
                }
                cmbTypeOfAsset.Items.Add("Not In The List");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbTypeOfAsset_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbNameOfAsset.Items.Clear();
            cmbNameOfAsset.SelectedIndex = -1;
            cmbNameOfAsset.ResetText();


            if (cmbTypeOfAsset.Text == "Not In The List")
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Please Input Asset Type Here", "Input Here",
                    "", -1, -1);
                if (string.IsNullOrWhiteSpace(input))
                {
                    cmbTypeOfAsset.SelectedIndex = -1;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct2 = "select T_Name from tblTypeOfAsset where T_Name='" + input + "' AND S_Id='" + s_id + "'";
                    cmd = new SqlCommand(ct2, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() && !rdr.IsDBNull(0))
                    {
                        MessageBox.Show("This Type of Asset Already Exists,Please Select From List", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        cmbTypeOfAsset.SelectedIndex = -1;
                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string query1 = "insert into tblTypeOfAsset (T_Name, S_Id) values (@d1,@d2)" +
                                            "SELECT CONVERT(int,SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query1, con);
                            cmd.Parameters.AddWithValue("@d1", input);
                            cmd.Parameters.AddWithValue("@d2", s_id);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            cmbTypeOfAsset.Items.Clear();
                            //cmbTypeOfAsset.SelectedIndex = -1;
                            TypeofAsssetLoad();
                            cmbTypeOfAsset.SelectedText = input;
                            

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT T_Id from tblTypeOfAsset WHERE T_Name= '" + cmbTypeOfAsset.Text + "'";

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
                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        cmbNameOfAsset.Items.Add(rdr[0]);
                    }
                    cmbNameOfAsset.Items.Add("Not In The List");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbNameOfAsset_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbNameOfAsset.Text == "Not In The List")
            {
                string inp = Microsoft.VisualBasic.Interaction.InputBox("Please Input Asset Name Here", "Input Here",
                    "", -1, -1);
                if (string.IsNullOrWhiteSpace(inp))
                {
                    cmbNameOfAsset.SelectedIndex = -1;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct2 = "select N_Name from tblNameOfAsset where N_Name='" + inp + "'AND T_Id='" + t_id + "'";
                    cmd = new SqlCommand(ct2, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() && !rdr.IsDBNull(0))
                    {
                        MessageBox.Show("This Name of Asset Already Exists,Please Select From List", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        cmbNameOfAsset.SelectedIndex = -1;
                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string query11 =
                                "insert into tblNameOfAsset (N_Name, T_Id, UserId, CreationDate) values (@d1,@d2,@d3,@d4)" +
                                "SELECT CONVERT(int,SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query11, con);
                            cmd.Parameters.AddWithValue("@d1", inp);
                            cmd.Parameters.AddWithValue("@d2", t_id);
                            cmd.Parameters.AddWithValue("@d3", user_id);
                            cmd.Parameters.AddWithValue("@d4", DateTime.UtcNow.ToLocalTime());
                            cmd.ExecuteNonQuery();
                            con.Close();

                            cmbNameOfAsset.Items.Clear();
                            cmbNameOfAsset.SelectedIndex = -1;
                            cmbNameOfAsset.ResetText();
                            NameofAsssetLoad();
                            cmbNameOfAsset.SelectedText = inp;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandText = "SELECT N_Id from tblNameOfAsset WHERE N_Name= '" + cmbNameOfAsset.Text + "'";

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

                    //con = new SqlConnection(cs.DBConn);
                    //con.Open();
                    //string ct = "select distinct RTRIM(N_Name) from tblNameOfAsset where T_Id= " + t_id + "";
                    //cmd = new SqlCommand(ct);
                    //cmd.Connection = con;
                    //rdr = cmd.ExecuteReader();

                    //while (rdr.Read())
                    //{
                    //    cmbNameOfAsset.Items.Add(rdr[0]);
                    //}
                    //cmbNameOfAsset.Items.Add("Not In The List");
                    //con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void cmbV_Name_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbV_Name.Text == "Not In The List")
            {
                string inpv = Microsoft.VisualBasic.Interaction.InputBox("Please Input Vendor Name Here", "Input Here",
                    "", -1, -1);
                if (string.IsNullOrWhiteSpace(inpv))
                {
                    cmbV_Name.SelectedIndex = -1;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ctt2 = "select V_Name from tblVendor where V_Name='" + inpv + "'";
                    cmd = new SqlCommand(ctt2, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() && !rdr.IsDBNull(0))
                    {
                        MessageBox.Show("This Name of Vendor Already Exists,Please Select From List", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        cmbV_Name.SelectedIndex = -1;
                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string query1 =
                                "insert into tblVendor (V_Name, UserId) values (@d1,@d2)" +
                                "SELECT CONVERT(int,SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query1, con);
                            cmd.Parameters.AddWithValue("@d1", inpv);
                            cmd.Parameters.AddWithValue("@d2", user_id);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            cmbV_Name.Items.Clear();
                            Vendor();
                            cmbV_Name.SelectedText = inpv;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbStability.Text))
            {
                MessageBox.Show("Please  Select Stability", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrWhiteSpace(cmbTypeOfAsset.Text))
            {
                MessageBox.Show("Please  Select Asset Type", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (string.IsNullOrWhiteSpace(cmbNameOfAsset.Text))
            {
                MessageBox.Show("Please  Select Asset Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Please enter Description", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(cmbV_Name.Text))
            {
                MessageBox.Show("Please Select Vendor", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(cmbUnitname.Text))
            {
                MessageBox.Show("Please Select Unit Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtUnit.Text))
            {
                MessageBox.Show("Please enter Quantity", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                MessageBox.Show("Please enter Unit Price", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                String query = "insert into tblAssetDescription(Description, PurchaseDate, V_Id, InvoiceNo, Units, UnitPrice, UserId, U_Id, UnitSalvageValue, LifeSpanInYear, N_Id) values (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@d1", txtDescription.Text);
                cmd.Parameters.AddWithValue("@d2", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@d3", v_id);
                cmd.Parameters.AddWithValue("@d4", Convert.ToDecimal(txtInvoiceNo.Text));
                cmd.Parameters.AddWithValue("@d5", Convert.ToDecimal(txtUnit.Text));
                cmd.Parameters.AddWithValue("@d6", Convert.ToDecimal(txtUnitPrice.Text));
                cmd.Parameters.AddWithValue("@d7", user_id);
                cmd.Parameters.AddWithValue("@d8", unit_id);
                cmd.Parameters.AddWithValue("@d9", Convert.ToDecimal(txtUnitSalvageValue.Text));
                cmd.Parameters.AddWithValue("@d10", Convert.ToDecimal(txtLifeSpanInYear.Text));
                cmd.Parameters.AddWithValue("@d11", n_id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Saved successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
                Stability();
                Unit();
                Vendor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearData()
        {
            dateTimePicker1.ResetText();
            cmbStability.Items.Clear();
            cmbStability.SelectedIndex = -1;

            cmbTypeOfAsset.Items.Clear();
            cmbTypeOfAsset.SelectedIndex = -1;

            cmbNameOfAsset.Items.Clear();
            cmbNameOfAsset.SelectedIndex = -1;

            txtDescription.Clear();

            cmbV_Name.Items.Clear();
            cmbV_Name.SelectedIndex = -1;

            txtInvoiceNo.Clear();

            cmbUnitname.Items.Clear();
            cmbUnitname.SelectedIndex = -1;

            txtUnit.Clear();
            txtUnitPrice.Clear();
            txtUnitSalvageValue.Clear();
            txtLifeSpanInYear.Clear();
        }



        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
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
            if (ch == (char)Keys.Back)
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
            if (ch == (char)Keys.Back)
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



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Should not be exceed Date Time from today", "Warrning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePicker1.ResetText();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            MainUI1 frm3 = new MainUI1();
            frm3.Show();
        }
    }
}










