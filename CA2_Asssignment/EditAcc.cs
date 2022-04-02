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
using DAL;

namespace CA2_Asssignment
{
    public partial class EditAcc : Form
    {
        public EditAcc()
        {
            InitializeComponent();
        }

        private void EditAcc_Load(object sender, EventArgs e)
        {
            cbocy.DataSource = Enum.GetValues(typeof(Counties));
            GetAccNo();       
        }

        private void cboAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAccNo();
            GetNames();
        }


        UpdateCus up = new UpdateCus();
        DAO dao = new DAO();
        SqlDataReader dr;
        private void btnupdate_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string add1 = txtadd1.Text;
            string add2 = txtadd2.Text;
            string city = txtcity.Text;
            string county = cbocy.SelectedItem.ToString();
            int AccountNo = int.Parse(cboAccNo.SelectedItem.ToString());
            
            up.UpdateCustomer(email,add1,add2,city,county,AccountNo);

            MessageBox.Show("Data Updates Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtemail.Clear();
            txtadd1.Clear();
            txtadd2.Clear();
            txtcity.Clear();
        }


        void GetAccNo()
        {
            string select = "SELECT * FROM MyCustomer";

            SqlCommand cmd = new SqlCommand(select, dao.OpenCon());

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string acc = dr["AccountNo"].ToString();
                cboAccNo.Items.Add(acc);

            }
            dao.CloseCon();
        }

        void GetNames()
        {
            string select = "SELECT * FROM MyCustomer WHERE AccountNo = @accno";
            string AcNo = cboAccNo.SelectedItem.ToString();

            SqlCommand cmd = new SqlCommand(select, dao.OpenCon());
            cmd.Parameters.AddWithValue("@accno", AcNo);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string fn = dr["Firstname"].ToString();
                string sn = dr["Surname"].ToString();
                string email = dr["Email"].ToString();
                string add1 = dr["Address1"].ToString();
                string add2 = dr["Address2"].ToString();
                string city = dr["City"].ToString();
                string cy = dr["County"].ToString();
                lblfn.Text = fn;
                lblsn.Text = sn;
                txtemail.Text = email;
                txtadd1.Text = add1;
                txtadd2.Text = add2;
                txtcity.Text = city;
                cbocy.Text = cy;
            }

            dao.CloseCon();
        }

    }
}
