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
using System.Windows;
using System.IO;

namespace CA2_Asssignment
{
    public partial class WithdrawFunds : Form
    {
        public WithdrawFunds()
        {
            InitializeComponent();
        }
        private void WithdrawFunds_Load(object sender, EventArgs e)
        {
            GetAccNo();
        }

        private void cboAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetNames();
        }



        DAO dao = new DAO();
        SqlDataReader dr;

      

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

      
        private void btnwithdraw_Click(object sender, EventArgs e)
        {
            int accno = int.Parse(cboAccNo.SelectedItem.ToString());
            decimal WAmount = decimal.Parse(txtWAmount.Text);
            decimal bal = decimal.Parse(lblBal.Text);
            decimal newamount = (bal - WAmount) * 100;

            if (WAmount <= bal)
            {
                if (newamount == 0)
                {

                    DialogResult result = MessageBox.Show("Your Account Balance will be 0", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {

                        string update = "UPDATE MyCustomer SET InitialBalance = @na, Amount = @am WHERE AccountNo = @accno";

                        SqlCommand cmd = new SqlCommand(update, dao.OpenCon());
                        cmd.Parameters.AddWithValue("@accno", accno);
                        cmd.Parameters.AddWithValue("@na", newamount);
                        cmd.Parameters.AddWithValue("@am", WAmount);

                        cmd.ExecuteNonQuery();
                        dao.CloseCon();

                        MessageBox.Show("Withdrawl Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtWAmount.Clear();
                        lblBal.Text = "";
                        lblname.Text = "";
                        cboAccNo.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Withdrawl Aborted", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            else
            {
                MessageBox.Show($"Withdrawl Amount cannot excced your balance: {bal} \nPlease Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
