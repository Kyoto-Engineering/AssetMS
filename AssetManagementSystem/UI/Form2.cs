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
using AssetManagementSystem.DbGateway;
using AssetManagementSystem.LogInUI;

namespace AssetManagementSystem.UI
{
    public partial class Form2 : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public int incumbent_type_id, t_id, n_id, incumbent_id, d_id;
        public string user_id;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            user_id = frmLogin.uId.ToString();
            Incumbent_type();
            Type_Of_Asset();
        }

        private void Incumbent_type()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select Incumbent_Type_Name from TypeOfIncumbent";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbIncumbentType.Items.Add(rdr.GetValue(0).ToString());
                }
                cmbIncumbentType.Items.Add("Not In The List");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void NameofIncumbentLoad()
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandText = "SELECT Incumbent_Id from Incumbent WHERE Incumbent_Name= '" + cmbIncumbentName.Text +
                                  "'";

                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    incumbent_id = rdr.GetInt32(0);
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
                string ct = "select distinct RTRIM(Incumbent_Name) from Incumbent where Incumbent_Type_Id= " +
                            incumbent_type_id + "";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbIncumbentName.Items.Add(rdr[0]);
                }
                cmbIncumbentName.Items.Add("Not In The List");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Type_Of_Asset()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select T_Name from tblTypeOfAsset";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    cmbTypeOfAsset.Items.Add(rdr.GetValue(0).ToString());
                }
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

            cmbDescription.Text = "";
            cmbDescription.Items.Clear();
            cmbDescription.SelectedIndex = -1;

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
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbNameOfAsset_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDescription.Text = "";
            cmbDescription.Items.Clear();
            cmbDescription.SelectedIndex = -1;

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
                string ct = "select distinct RTRIM(Description) from tblAssetDescription where N_Id= " + n_id + "";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbDescription.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT D_Id from tblAssetDescription WHERE Description= '" + cmbDescription.Text + "'";

                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    d_id = rdr.GetInt32(0);
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

        private void cmbIncumbentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbIncumbentName.Text = "";
            cmbIncumbentName.Items.Clear();
            cmbIncumbentName.SelectedIndex = -1;
 
            if (cmbIncumbentType.Text == "Not In The List")
            {
                //string inputt = Microsoft.VisualBasic.Interaction.InputBox("Please Input Incumbent Type Here", "Input Here",
                //    "", -1, -1);
                string inputt = null;
                InputBox.Show("Please Input Incumbent Type Here", "Inpute Here", ref inputt);
                if (string.IsNullOrWhiteSpace(inputt))
                {
                    cmbIncumbentType.SelectedIndex = -1;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ctt2 = "select Incumbent_Type_Name from TypeOfIncumbent where Incumbent_Type_Name='" + inputt + "'";
                    cmd = new SqlCommand(ctt2, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() && !rdr.IsDBNull(0))
                    {
                        MessageBox.Show("This Type of Incumbent Already Exists,Please Select From List", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        cmbIncumbentType.SelectedIndex = -1;
                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string query1 = "insert into TypeOfIncumbent (Incumbent_Type_Name) values (@d1)" +
                                            "SELECT CONVERT(int,SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query1, con);
                            cmd.Parameters.AddWithValue("@d1", inputt);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            cmbIncumbentType.Items.Clear();
                            Incumbent_type();
                            cmbIncumbentType.SelectedText = inputt;

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
                    cmd.CommandText = "SELECT Incumbent_Type_Id from TypeOfIncumbent WHERE Incumbent_Type_Name= '" + cmbIncumbentType.Text + "'";

                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        incumbent_type_id = rdr.GetInt32(0);
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
                    string ct = "select distinct RTRIM(Incumbent_Name) from Incumbent where Incumbent_Type_Id= " + incumbent_type_id + "";
                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        cmbIncumbentName.Items.Add(rdr[0]);
                    }
                    cmbIncumbentName.Items.Add("Not In The List");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cmbIncumbentName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbIncumbentName.Text == "Not In The List")
            {
                //string inpp = Microsoft.VisualBasic.Interaction.InputBox("Please Input Incumbent Name Here",
                //    "Input Here",
                //    "", -1, -1);
                string inpp = null;
                InputBox.Show("Please Input Incumbent Name Here", "Inpute Here", ref inpp);
                if (string.IsNullOrWhiteSpace(inpp))
                {
                    cmbIncumbentName.SelectedIndex = -1;
                }
                else
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct2 = "select Incumbent_Name from Incumbent where Incumbent_Name='" + inpp +
                                 "'AND Incumbent_Type_Id='" + incumbent_type_id + "'";
                    cmd = new SqlCommand(ct2, con);
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read() && !rdr.IsDBNull(0))
                    {
                        MessageBox.Show("This Name of Incumbent Already Exists,Please Select From List", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        con.Close();
                        cmbIncumbentName.SelectedIndex = -1;
                    }
                    else
                    {
                        try
                        {
                            con = new SqlConnection(cs.DBConn);
                            con.Open();
                            string query11 =
                                "insert into Incumbent (Incumbent_Name, Incumbent_Type_Id) values (@d1,@d2)" +
                                "SELECT CONVERT(int,SCOPE_IDENTITY())";
                            cmd = new SqlCommand(query11, con);
                            cmd.Parameters.AddWithValue("@d1", inpp);
                            cmd.Parameters.AddWithValue("@d2", incumbent_type_id);
                            //cmd.Parameters.AddWithValue("@d3", user_id);
                            //cmd.Parameters.AddWithValue("@d4", DateTime.UtcNow.ToLocalTime());
                            cmd.ExecuteNonQuery();
                            con.Close();

                            cmbIncumbentName.Items.Clear();
                            cmbIncumbentName.SelectedIndex = -1;
                            cmbIncumbentName.ResetText();
                            NameofIncumbentLoad();
                            cmbIncumbentName.SelectedText = inpp;
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
                    cmd.CommandText = "SELECT Incumbent_Id from Incumbent WHERE Incumbent_Name= '" +
                                      cmbIncumbentName.Text + "'";

                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        incumbent_id = rdr.GetInt32(0);
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
            if (string.IsNullOrWhiteSpace(cmbTypeOfAsset.Text))
            {
                MessageBox.Show("Please Select Type of Asset", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(cmbNameOfAsset.Text))
            {
                MessageBox.Show("Please  Select Asset Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(cmbDescription.Text))
            {
                MessageBox.Show("Please  Select Description", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(txtAllowanceUnits.Text))
            {
                MessageBox.Show("Please  enter Allowance Units", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(cmbIncumbentType.Text))
            {
                MessageBox.Show("Please Select Incumbent Type", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrWhiteSpace(cmbIncumbentName.Text))
            {
                MessageBox.Show("Please Select Incumbent Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {


                try
                {
                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    String query = "insert into Allowance(A_Units, FirstA_Date, D_Id, UserId) values (@d1,@d2,@d3,@d4)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@d1", Convert.ToDecimal(txtAllowanceUnits.Text));
                    cmd.Parameters.AddWithValue("@d2", dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@d3", d_id);
                    cmd.Parameters.AddWithValue("@d4", user_id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Added successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearAll()
        {
            dateTimePicker2.ResetText();
           
            cmbTypeOfAsset.Items.Clear();
            cmbTypeOfAsset.SelectedIndex = -1;

            cmbNameOfAsset.Items.Clear();
            cmbNameOfAsset.SelectedIndex = -1;
            
            cmbDescription.Items.Clear();
            cmbDescription.SelectedIndex = -1;

            txtAllowanceUnits.Clear();
            dateTimePicker2.ResetText();

            cmbIncumbentType.Items.Clear();
            cmbIncumbentType.SelectedIndex = -1;

            cmbIncumbentName.Items.Clear();
            cmbIncumbentName.SelectedIndex = -1;


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            MainUI1 frm2 = new MainUI1();
            frm2.Show();
        }

    }
}
