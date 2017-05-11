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
using AssetManagementSystem.LogInUI;
using System.Text.RegularExpressions;

namespace AssetManagementSystem.UI
{
    public partial class frmTypeOfAssetCreation : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public string user_id;
        public int s_id;
        public frmTypeOfAssetCreation()
        {
            InitializeComponent();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbStability.Text))
            {
                MessageBox.Show("Please  Select Stability", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (TypeOfAssettextBox.Text == "")
            {
                MessageBox.Show("Please Enter Type Of Asset!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TypeOfAssettextBox.Focus();
                return;
            }

            else
            {
                try
                {

                    con = new SqlConnection(cs.DBConn);
                    con.Open();
                    string ct = "select T_Name from tblTypeOfAsset where T_Name='" + TypeOfAssettextBox.Text + "'";

                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        MessageBox.Show("This Asset Type Already Exists!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        TypeOfAssettextBox.Text = "";
                        TypeOfAssettextBox.Focus();

                        if ((rdr != null))
                        {
                            rdr.Close();
                        }
                        return;
                    }

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
                    string query = "insert into tblTypeOfAsset(T_Name,S_Id, UserId, DateAndTime) values(@d1,@d2,@d3,@d4)" + "SELECT CONVERT(int,SCOPE_IDENTITY())"; ;
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@d1", TypeOfAssettextBox.Text);
                    cmd.Parameters.AddWithValue("@d2", s_id);
                    cmd.Parameters.AddWithValue("@d3", user_id);
                    cmd.Parameters.AddWithValue("@d4", DateTime.UtcNow.ToLocalTime());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Saved Successfully", "Information", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    cmbStability.SelectedIndex = -1;
                    TypeOfAssettextBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmTypeOfAssetCreation_Load(object sender, EventArgs e)
        {
            user_id = frmLogin.uId.ToString();
            Stability();

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

        private void frmTypeOfAssetCreation_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainUI1 frm = new MainUI1();
            frm.Show();
        }

        private void TypeOfAssettextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TypeOfAssettextBox.Text))
            {
                string vendorname = TypeOfAssettextBox.Text.Trim();
                Regex mRegxExpression;
                int Minlen = 3;

                mRegxExpression = new Regex(@"^[A-Za-z]+[\s][A-Za-z]+[.][A-Za-z]+$");

                if ((!mRegxExpression.IsMatch(vendorname)) && (!(TypeOfAssettextBox.Text.Length >= Minlen)))
                {

                    MessageBox.Show("Please type your  valid Asset type.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TypeOfAssettextBox.Clear();
                    TypeOfAssettextBox.Focus();

                }
            }
        }

    }
}
