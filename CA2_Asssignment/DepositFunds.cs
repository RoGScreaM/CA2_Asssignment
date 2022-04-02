using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;

namespace CA2_Asssignment
{
    public partial class DepositFunds : Form
    {
        public DepositFunds()
        {
            InitializeComponent();
        }

        DAO dao = new DAO();
        SqlDataReader dr;

        private void DepositFunds_Load(object sender, EventArgs e)
        {
            GetAccNo();
            
        }

        private void cboAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNames();
        }


        private void btndeposit_Click(object sender, EventArgs e)
        {

            int accno = int.Parse(cboAccNo.SelectedItem.ToString());
            decimal DAmount = decimal.Parse(txtDAmount.Text);
            decimal bal = decimal.Parse(lblBal.Text);
            decimal newamount = (DAmount + bal) * 100;

            string update = "UPDATE MyCustomer SET InitialBalance = @na,Amount = @am WHERE AccountNo = @accno";

            SqlCommand cmd = new SqlCommand(update, dao.OpenCon());
            cmd.Parameters.AddWithValue("@accno", accno);
            cmd.Parameters.AddWithValue("@na",newamount);
            cmd.Parameters.AddWithValue("@am", DAmount);

            cmd.ExecuteNonQuery();
            dao.CloseCon();

            MessageBox.Show("Deposit Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            txtDAmount.Clear();
            lblBal.Text = "";
            lblname.Text = "";
            cboAccNo.Text = "";


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
                decimal bal = decimal.Parse(dr["InitialBalance"].ToString())/100;
                lblname.Text = fn + " " + sn;
                lblBal.Text = bal.ToString();
                
            }

            dao.CloseCon();
        }

        
    }
}
