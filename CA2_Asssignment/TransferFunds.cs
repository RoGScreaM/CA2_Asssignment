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
    public partial class TransferFunds : Form
    {
        public TransferFunds()
        {
            InitializeComponent();
        }
        
        DAO dao = new DAO();
        FundTransfer ft = new FundTransfer();
        SqlDataReader dr;
        private void TransferFunds_Load(object sender, EventArgs e)
        {
            GetAccNo();
        }
        private void cboSenderAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSenderNames();
        }

        private void cboRecieverAccNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetRecieverNames();
        }

        private void btnTransferFunds_Click(object sender, EventArgs e)
        {

            int SenderAccNo = int.Parse(cboSenderAccNo.SelectedItem.ToString());
            decimal SBalance = decimal.Parse(lblBal.Text);
            decimal ODLimit = decimal.Parse(lblOL.Text);
            decimal TAmount = decimal.Parse(txtTAmount.Text);

            int RecieverAccNo = int.Parse(cboRecieverAccNo.SelectedItem.ToString());
            int SortCode = int.Parse(txtRSortCode.Text);

            
            string date = DateTime.Now.ToString();

            Random r = new Random();
            int RNo = r.Next(1000,1000000);

            
            
            

            decimal Limit = SBalance + ODLimit;

            
            if(rdoSavings.Checked && SortCode == 101010)
            {
                if(TAmount <= Limit)
                {
                    SenderTransfer();
                    RecieverTransfer();

                    ft.ViewTransactions(SenderAccNo, RecieverAccNo, SortCode, TAmount, RNo, date);
                    MessageBox.Show( "Your Transfer is Successfull", "Success Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information); 


                }
                else
                {
                    MessageBox.Show( $"The Transfer Limit is {Limit}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                }

            }
            else if(rdoSavings.Checked && SortCode != 101010)
            {
                MessageBox.Show( "This Transfer cannot be made as it is a Savings Account", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            else if(rdoCurrent.Checked)
            {
                SenderTransfer();
                RecieverTransfer();

                ft.ViewTransactions(SenderAccNo, RecieverAccNo, SortCode, TAmount, RNo, date);
                MessageBox.Show("Your Transfer is Successfull", "Success Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }



        }


        void SenderTransfer()
        {

            int accno = int.Parse(cboSenderAccNo.SelectedItem.ToString());
            decimal TAmount = decimal.Parse(txtTAmount.Text);
            decimal bal = decimal.Parse(lblBal.Text);
            decimal newamount = bal - TAmount;


            decimal ODLimit = decimal.Parse(lblOL.Text);
            decimal Limit = bal + ODLimit;


            if (TAmount <= Limit)
            {
                string update = "UPDATE Customer SET InitialBalance = @na WHERE AccountNo = @accno";

                SqlCommand cmd = new SqlCommand(update, dao.OpenCon());
                cmd.Parameters.AddWithValue("@accno", accno);
                cmd.Parameters.AddWithValue("@na", newamount);

                cmd.ExecuteNonQuery();
                dao.CloseCon();

                
            }
            else
            {
                MessageBox.Show($"This Transfer cannot excced your balance: {bal} \nPlease Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        void RecieverTransfer()
        {
            int accno = int.Parse(cboRecieverAccNo.SelectedItem.ToString());
            decimal RAmount = decimal.Parse(txtTAmount.Text);
            decimal bal = decimal.Parse(lblBal.Text);
            decimal newamount = GetRecieverBalance(bal) + RAmount  ; 

            

            string update = "UPDATE Customer SET InitialBalance = @na WHERE AccountNo = @accno";

            SqlCommand cmd = new SqlCommand(update, dao.OpenCon());
            cmd.Parameters.AddWithValue("@accno", accno);
            cmd.Parameters.AddWithValue("@na", newamount);

            cmd.ExecuteNonQuery();
            dao.CloseCon();

            txtTAmount.Clear();
            lblBal.Text = "";
            lblname.Text = "";
            cboRecieverAccNo.Text = "";

        }



        // methods to populate combobox and labels
        void GetAccNo()
        {
            string select = "SELECT * FROM Customer";

            SqlCommand cmd = new SqlCommand(select, dao.OpenCon());

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string acc = dr["AccountNo"].ToString();
                cboSenderAccNo.Items.Add(acc);
                cboRecieverAccNo.Items.Add(acc);
            }
            dao.CloseCon();
        }

        

        void GetSenderNames()
        {
            string select = "SELECT * FROM Customer WHERE AccountNo = @accno";
            string AcNo = cboSenderAccNo.SelectedItem.ToString();

            SqlCommand cmd = new SqlCommand(select, dao.OpenCon());
            cmd.Parameters.AddWithValue("@accno", AcNo);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string fn = dr["Firstname"].ToString();
                string sn = dr["Surname"].ToString();
                decimal bal = decimal.Parse(dr["InitialBalance"].ToString());
                decimal OverDLimit = decimal.Parse(dr["OverdraftLimit"].ToString());
                lblname.Text = fn + " " + sn;
                lblBal.Text = bal.ToString();
                lblOL.Text = OverDLimit.ToString();

            }

            dao.CloseCon();
        }

        void GetRecieverNames()
        {
            string select = "SELECT * FROM Customer WHERE AccountNo = @accno";
            string AcNo = cboRecieverAccNo.SelectedItem.ToString();

            SqlCommand cmd = new SqlCommand(select, dao.OpenCon());
            cmd.Parameters.AddWithValue("@accno", AcNo);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string fn = dr["Firstname"].ToString();
                string sn = dr["Surname"].ToString();
                decimal bal = decimal.Parse(dr["InitialBalance"].ToString());
                int SCode = int.Parse(dr["SortCode"].ToString());
                lblRname.Text = fn + " " + sn;
                txtRSortCode.Text = SCode.ToString();
            }

            dao.CloseCon();
        }

        public decimal GetRecieverBalance(decimal bal)
        {

            string select = "SELECT * FROM Customer WHERE AccountNo = @accno";
            string AcNo = cboRecieverAccNo.SelectedItem.ToString();

            SqlCommand cmd = new SqlCommand(select, dao.OpenCon());
            cmd.Parameters.AddWithValue("@accno", AcNo);

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                
                 bal = decimal.Parse(dr["InitialBalance"].ToString());               
                 lblBal.Text = bal.ToString();
                
            }

            dao.CloseCon();

            return bal;
        }


    }
}
