using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssetManagementSystem.DbGateway;
using AssetManagementSystem.LogInUI;

namespace AssetManagementSystem.UI
{
    public partial class frmVendorCreation : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader rdr;
        ConnectionString cs = new ConnectionString();
        public string user_id, postofficeIdRA, divisionIdRA, districtIdRA, thanaIdRA;
        public int currentVendorId, affectedRows1, rAdistrictid;

        public frmVendorCreation()
        {
            InitializeComponent();
        }

        private void frmVendorCreation_Load(object sender, EventArgs e)
        {
            user_id = frmLogin.uId.ToString();
            FillDivisionCombo();
        }

        public void FillDivisionCombo()
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(Divisions.Division) from Divisions  order by Divisions.Division_ID desc ";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbRADivision.Items.Add(rdr[0]);
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidateVendor()
        {
            List<Vendor> vendors = new List<Vendor>();

            con = new SqlConnection(cs.DBConn);
            con.Open();
            string ct3 =
                "SELECT V_Name, Phone, Email, WebUrl FROM tblVendor where  tblVendor.V_Name='" +
                VendorNametextBox.Text + "'";
            cmd = new SqlCommand(ct3, con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                if (rdr.HasRows)
                {
                    Vendor x = new Vendor();
                    x.Name = rdr.GetString(0);

                    if (!DBNull.Value.Equals(rdr["Phone"]))
                    {
                        x.Phone = rdr.GetString(1);
                    }
                    else
                    {
                        x.Phone = null;
                    }

                    if (!DBNull.Value.Equals(rdr["Email"]))
                    {
                        x.Email = rdr.GetString(2);
                    }
                    else
                    {
                        x.Email = null;
                    }


                    if (!DBNull.Value.Equals(rdr["WebUrl"]))
                    {
                        x.Weburl = rdr.GetString(3);
                    }
                    else
                    {
                        x.Weburl = null;
                    }

                    vendors.Add(x);
                }
            }
            foreach (Vendor p in vendors)
            {
                if (p.Name == VendorNametextBox.Text && p.Phone == PhonetextBox.Text)
                {
                    MessageBox.Show(@"This Person Exists,Please Input another one" + "\n" + @"Or Use another Phone",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return true;
                }

                if (p.Name == VendorNametextBox.Text && p.Email == EmailAddresstextBox.Text)
                {
                    MessageBox.Show(@"This Person Exists,Please Input another one" + "\n" + @"Or Use another Email",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return true;
                }

                if (p.Name == VendorNametextBox.Text && p.Weburl == WebServiceUrltextBox.Text)
                {
                    MessageBox.Show(
                        @"This Person Exists,Please Input another one" + "\n" + @"Or Use another Web Service URL",
                        "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
                    return true;
                }
            }
            return false;
        }


        private bool ValidateControlls()
        {
            bool validate = true;

            if (string.IsNullOrEmpty(VendorNametextBox.Text))
            {
                MessageBox.Show(@"Please enter Vendor  name", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                validate = false;
                VendorNametextBox.Focus();
            }
            else if (string.IsNullOrEmpty(cmbRADivision.Text))
            {
                MessageBox.Show("Please select division", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                validate = false;
                cmbRADivision.Focus();
            }
            else if (string.IsNullOrWhiteSpace(cmbRADistrict.Text))
            {
                MessageBox.Show("Please Select district", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validate = false;
                cmbRADistrict.Focus();
            }
            else if (string.IsNullOrWhiteSpace(cmbRAThana.Text))
            {
                MessageBox.Show("Please select Thana", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validate = false;
                cmbRAThana.Focus();
            }

            else if (string.IsNullOrWhiteSpace(cmbRAPost.Text))
            {
                MessageBox.Show("Please Select Post Office", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validate = false;
                cmbRAPost.Focus();

            }
            else if (ValidateVendor())
            {
                validate = false;
            }

            return validate;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(VendorNametextBox.Text) && string.IsNullOrEmpty(PhonetextBox.Text) &&
                string.IsNullOrEmpty(EmailAddresstextBox.Text) && string.IsNullOrEmpty(WebServiceUrltextBox.Text))
            {
                MessageBox.Show(@"Please insert phone or email or web service", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ValidateControlls())
            {

                try
                {
                    SaveVendor();
                    SaveVendorAddress("VendorAddress");

                    MessageBox.Show("Saved successfully", "Record", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ResetAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ResetAll()
        {
            VendorNametextBox.Clear();
            PhonetextBox.Clear();
            EmailAddresstextBox.Clear();
            WebServiceUrltextBox.Clear();
            ResetResidentialAddress();
        }

        public void ResetResidentialAddress()
        {
            txtRAFlatNo.Clear();
            txtRAHouseNo.Clear();
            txtRARoadNo.Clear();
            txtRABlock.Clear();
            txtRAArea.Clear();
            txtRAContactNo.Clear();
            txtRAPostCode.Clear();
            cmbRAPost.SelectedIndex = -1;
            cmbRAThana.SelectedIndex = -1;
            cmbRADistrict.SelectedIndex = -1;
            cmbRADivision.SelectedIndex = -1;
        }

        private void SaveVendor()
        {
            string newname = VendorNametextBox.Text;
            con = new SqlConnection(cs.DBConn);
            con.Open();
            string query =
                "INSERT INTO tblVendor (V_Name, UserId, Phone, Email, WebUrl) VALUES(@nname, @d1, @nphone, @nemail, @nweburl)" + "SELECT CONVERT(int, SCOPE_IDENTITY())";
            

            cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@nname", newname);
            cmd.Parameters.AddWithValue("@d1", user_id);
            cmd.Parameters.Add(new SqlParameter("@nphone",
                string.IsNullOrEmpty(PhonetextBox.Text) ? (object) DBNull.Value : PhonetextBox.Text));
            cmd.Parameters.Add(new SqlParameter("@nemail",
                string.IsNullOrEmpty(EmailAddresstextBox.Text) ? (object) DBNull.Value : EmailAddresstextBox.Text));
            cmd.Parameters.Add(new SqlParameter("@nweburl",
                string.IsNullOrEmpty(WebServiceUrltextBox.Text) ? (object) DBNull.Value : WebServiceUrltextBox.Text));        
            currentVendorId = (int) (cmd.ExecuteScalar());
            con.Close();
        }


        private void SaveVendorAddress(string tblName1)
        {
            string tableName = tblName1;

            if (tableName == "VendorAddress")
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string insertQ = "insert into " + tableName +
                                 "(V_Id,PostOfficeId,VFlatNo,VHouseNo,VRoadNo,VBlock,VArea,VAdditionalContactNo) Values(@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8)" +
                                 "SELECT CONVERT(int, SCOPE_IDENTITY())";
                cmd = new SqlCommand(insertQ);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@d1", currentVendorId);
                cmd.Parameters.Add(new SqlParameter("@d2",
                    string.IsNullOrEmpty(postofficeIdRA) ? (object) DBNull.Value : postofficeIdRA));
                cmd.Parameters.Add(new SqlParameter("@d3",
                    string.IsNullOrEmpty(txtRAFlatNo.Text) ? (object) DBNull.Value : txtRAFlatNo.Text));
                cmd.Parameters.Add(new SqlParameter("@d4",
                    string.IsNullOrEmpty(txtRAHouseNo.Text) ? (object) DBNull.Value : txtRAHouseNo.Text));
                cmd.Parameters.Add(new SqlParameter("@d5",
                    string.IsNullOrEmpty(txtRARoadNo.Text) ? (object) DBNull.Value : txtRARoadNo.Text));
                cmd.Parameters.Add(new SqlParameter("@d6",
                    string.IsNullOrEmpty(txtRABlock.Text) ? (object) DBNull.Value : txtRABlock.Text));
                cmd.Parameters.Add(new SqlParameter("@d7",
                    string.IsNullOrEmpty(txtRAArea.Text) ? (object) DBNull.Value : txtRAArea.Text));
                cmd.Parameters.Add(new SqlParameter("@d8",
                    string.IsNullOrEmpty(txtRAContactNo.Text) ? (object) DBNull.Value : txtRAContactNo.Text));
                affectedRows1 = (int) cmd.ExecuteScalar();
                con.Close();
            }
        }

        private void cmbRADivision_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbRADistrict.Items.Clear();
            cmbRADistrict.ResetText();
            cmbRAThana.Items.Clear();
            cmbRAThana.ResetText();
            cmbRAPost.Items.Clear();
            cmbRAPost.ResetText();

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctk = "SELECT  RTRIM(Divisions.Division_ID)  from Divisions WHERE Divisions.Division=@find";

                cmd = new SqlCommand(ctk);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NVarChar, 50, "Division"));
                cmd.Parameters["@find"].Value = cmbRADivision.Text;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    divisionIdRA = (rdr.GetString(0));

                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                cmbRADivision.Text = cmbRADivision.Text.Trim();
                cmbRADistrict.Items.Clear();
                cmbRADistrict.ResetText();
                cmbRAThana.Items.Clear();
                cmbRAThana.ResetText();
                cmbRAThana.SelectedIndex = -1;
                cmbRAPost.Items.Clear();
                cmbRAPost.ResetText();
                cmbRAPost.SelectedIndex = -1;
                txtRAPostCode.Clear();
                cmbRADistrict.Enabled = true;
                cmbRADistrict.Focus();

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(Districts.District) from Districts  Where Districts.Division_ID = '" +
                            divisionIdRA + "' order by Districts.Division_ID desc";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbRADistrict.Items.Add(rdr[0]);
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmbRAThana.Enabled = false;
            cmbRAPost.Enabled = false;
        }

        private void cmbRADistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctk = "SELECT  RTRIM(Districts.D_ID)  from Districts WHERE Districts.District=@find";

                cmd = new SqlCommand(ctk);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NVarChar, 50, "District"));
                cmd.Parameters["@find"].Value = cmbRADistrict.Text;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    districtIdRA = (rdr.GetString(0));

                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                cmbRADistrict.Text = cmbRADistrict.Text.Trim();
                cmbRAThana.Items.Clear();
                cmbRAThana.ResetText();
                cmbRAPost.Items.Clear();
                cmbRAPost.ResetText();
                cmbRAPost.SelectedIndex = -1;
                cmbRAPost.Enabled = false;
                txtRAPostCode.Clear();
                cmbRAThana.Enabled = true;
                cmbRAThana.Focus();


                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(Thanas.Thana) from Thanas  Where Thanas.D_ID = '" + districtIdRA +
                            "' order by Thanas.D_ID desc";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbRAThana.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbRAThana_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs.DBConn);
            con.Open();
            cmd = con.CreateCommand();

            cmd.CommandText = "select D_ID from Districts WHERE District= '" + cmbRADistrict.Text + "'";

            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                rAdistrictid = rdr.GetInt32(0);
            }
            if ((rdr != null))
            {
                rdr.Close();
            }
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }

            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctk = "SELECT  RTRIM(Thanas.T_ID)  from Thanas WHERE Thanas.Thana=@find AND Thanas.D_ID='" +
                             rAdistrictid + "'";
                cmd = new SqlCommand(ctk);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NVarChar, 50, "Thana"));
                cmd.Parameters["@find"].Value = cmbRAThana.Text;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    thanaIdRA = (rdr.GetString(0));

                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                cmbRAThana.Text = cmbRAThana.Text.Trim();
                cmbRAPost.Items.Clear();
                cmbRAPost.ResetText();
                txtRAPostCode.Clear();
                cmbRAPost.Enabled = true;
                cmbRAPost.Focus();

                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ct = "select RTRIM(PostOffice.PostOfficeName) from PostOffice  Where PostOffice.T_ID = '" +
                            thanaIdRA + "' order by PostOffice.T_ID desc";
                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    cmbRAPost.Items.Add(rdr[0]);
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmbRAPost.SelectedIndex = -1;
        }

        private void cmbRAPost_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(cs.DBConn);
                con.Open();
                string ctk =
                    "SELECT  RTRIM(PostOffice.PostOfficeId),RTRIM(PostOffice.PostCode) from PostOffice WHERE PostOffice.PostOfficeName=@find";
                cmd = new SqlCommand(ctk);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NVarChar, 50, "PostOfficeName"));
                cmd.Parameters["@find"].Value = cmbRAPost.Text;
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    postofficeIdRA = (rdr.GetString(0));
                    txtRAPostCode.Text = (rdr.GetString(1));
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

        private void PhonetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
            
        }

        private void EmailAddresstextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(EmailAddresstextBox.Text))
            {
                string emailId = EmailAddresstextBox.Text.Trim();
                Regex mRegxExpression;

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(emailId))
                {

                    MessageBox.Show("Please type your  valid email Address.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EmailAddresstextBox.Clear();
                    EmailAddresstextBox.Focus();

                }
            }
        }

        private void txtRAContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void VendorNametextBox_Leave(object sender, EventArgs e)
        {
           // int Minlen = 3;
            //if (!(VendorNametextBox.Text.Length >= Minlen))
            //{
              //  MessageBox.Show("input atleast 3 Character");
              ////  VendorNametextBox.Clear();
             //   VendorNametextBox.Focus();
            
          //  }
           
            
            if (!string.IsNullOrEmpty(VendorNametextBox.Text))
            {
                string vendorname = VendorNametextBox.Text.Trim();
                Regex mRegxExpression;
                int Minlen = 3;

                mRegxExpression = new Regex(@"^[A-Za-z]+[\s][A-Za-z]+[.][A-Za-z]+$");

                if ((!mRegxExpression.IsMatch(vendorname)) && (!(VendorNametextBox.Text.Length >= Minlen)))
                {

                    MessageBox.Show("Please type your  valid Vendor Name.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    VendorNametextBox.Clear();
                    VendorNametextBox.Focus();

                }
            }


        }

        private void WebServiceUrltextBox_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(WebServiceUrltextBox.Text))
            {
                string urlAddress = WebServiceUrltextBox.Text.Trim();
                Regex mRegxExpression;
                Regex mRegxExpression1;

                mRegxExpression = new Regex (@"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$") ;
                mRegxExpression1 = new Regex(@"^(www.)[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$");

                if ((!mRegxExpression.IsMatch(urlAddress)) &&  (!mRegxExpression1.IsMatch(urlAddress)))
                {

                    MessageBox.Show("Please type your  valid Url Address.", "MojoCRM", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    WebServiceUrltextBox.Clear();
                    WebServiceUrltextBox.Focus();

                }

                
            }
        }      
    }
}
