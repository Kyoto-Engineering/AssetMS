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

namespace AssetManagementSystem.UI
{
    public partial class Form2 : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public int incumbent_type_id, t_id, n_id, incumbent_id, TypeofIncumbntId, NameofIncumbentId, d_id, user_id;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
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

            txtIncumbentType.Visible = false;
            txtIncumbentName.Visible = false;

            if (cmbIncumbentType.Text == "Not In The List")
            {
                txtIncumbentType.Visible = true;
                txtIncumbentType.Focus();

                cmbIncumbentName.Items.Add("Not In The List");
            }
            else
            {
                txtIncumbentType.Clear();
                txtIncumbentType.Visible = false;

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
            txtIncumbentName.Visible = false;
            if (cmbIncumbentName.Text == "Not In The List")
            {
                txtIncumbentName.Visible = true;
                txtIncumbentName.Focus();
               

            }
            else
            {
                try
                {
                    con = new SqlConnection(cs.DBConn);

                    con.Open();
                    cmd = con.CreateCommand();

                    cmd.CommandText = "SELECT Incumbent_Id from Incumbent WHERE Incumbent_Name= '" + cmbIncumbentName.Text + "'";
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
            if (cmbTypeOfAsset.Text == "")
            {
                MessageBox.Show("Please Select Type of Asset", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbNameOfAsset.Text == "")
            {
                MessageBox.Show("Please  Select Asset Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbDescription.Text == "")
            {
                MessageBox.Show("Please  Select Description", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtAllowanceUnits.Text == "")
            {
                MessageBox.Show("Please  enter Allowance Units", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbIncumbentType.Text == "")
            {
                MessageBox.Show("Please Select IncumbentType", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbIncumbentType.Text == "Not In The List")
            {
                //txtIncumbentType.Clear();
                //txtIncumbentType.Visible = false;
                //cmbIncumbentType.Focus();

              
                //cmbIncumbentName.Text = "";
                //cmbIncumbentName.Items.Clear();
                //cmbIncumbentName.SelectedIndex = -1;
                //txtIncumbentName.Clear();
                //txtIncumbentName.Visible = false;


                //try
                //{
                //    con = new SqlConnection(cs.DBConn);
                //    con.Open();
                //    string ct = "select Incumbent_Type_Name from TypeOfIncumbent where Incumbent_Type_Id='" + incumbent_type_id + "'  ";
                    

                //    cmd = new SqlCommand(ct);
                //    cmd.Connection = con;
                //    rdr = cmd.ExecuteReader();

                //    if (rdr.Read())
                //    {
                //        MessageBox.Show("This Type Of Incumbent Already Exists,Please Select From List", "Error",
                //            MessageBoxButtons.OK,
                //            MessageBoxIcon.Error);
                //        return;
                //    }

                //    else
                //    {
                       try
                        {

                            con = new SqlConnection(cs.DBConn);
                            //String query = "insert into TypeOfIncumbent(Incumbent_Type_Name) values (@d1)"; 
                            String query = "insert into TypeOfIncumbent(Incumbent_Type_Name) values (@d1)" +
                                           "SELECT CONVERT(int,SCOPE_IDENTITY())";
                            
                            cmd = new SqlCommand(query);
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("d1", txtIncumbentType.Text);
                            

                            con.Open();
                            TypeofIncumbntId = (int)cmd.ExecuteScalar();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            //}
            else
            {
                TypeofIncumbntId = incumbent_type_id;
            }


            if (cmbIncumbentName.Text == "")
            {
                MessageBox.Show("Please  select Incumbent Name", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (cmbIncumbentName.Text == "Not In The List")
            {


                //try
                //{
                //    con = new SqlConnection(cs.DBConn);
                //    con.Open();
                //    string ct = "select Incumbent_Name from Incumbent where Incumbent_Type_Id='" + incumbent_type_id + "'";

                //    cmd = new SqlCommand(ct);
                //    cmd.Connection = con;
                //    rdr = cmd.ExecuteReader();

                //    if (rdr.Read())
                //    {
                //        MessageBox.Show("This Name Of Incumbent Already Exists,Please Select From List", "Error",
                //            MessageBoxButtons.OK,
                //            MessageBoxIcon.Error);
                //    }

                //    else
                //    {
                        try
                        {

                            con = new SqlConnection(cs.DBConn);
                            String query = "insert into Incumbent (Incumbent_Name, Incumbent_Type_Id) values (@d1,@d2)" +
                                           "SELECT CONVERT(int,SCOPE_IDENTITY())";
                            
                            cmd = new SqlCommand(query);
                            cmd.Connection = con;
                            cmd.Parameters.AddWithValue("d1", txtIncumbentName.Text);
                            cmd.Parameters.AddWithValue("d2", TypeofIncumbntId);
                            con.Open();
                            NameofIncumbentId = (int) cmd.ExecuteScalar();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

            //}
            else
            {
                NameofIncumbentId = incumbent_id;
            }
            
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
                MessageBox.Show("Added successfully", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        
    }
}
