using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class FundTransfer
    {
        DAO dao = new DAO();

        public void ViewTransactions(int SAccNo,int RAccNo,int RSCode,decimal Amount,int RNo,string TransferDate)
        {
            SqlCommand cmd = dao.OpenCon().CreateCommand();

            cmd.CommandText = "uspTransferFunds";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SAccNo", SAccNo);
            cmd.Parameters.AddWithValue("@RAccNo",RAccNo );
            cmd.Parameters.AddWithValue("@RSCode",RSCode );
            cmd.Parameters.AddWithValue("@Amount",Amount );
            cmd.Parameters.AddWithValue("@RNo",RNo );
            cmd.Parameters.AddWithValue("@TDate", TransferDate);

            cmd.ExecuteNonQuery();
            dao.CloseCon();




        }


    }
}
