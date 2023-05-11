using BillingSystem.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem.DAL
{
    public class transactionDetailDAL
    {
        //Create Connnection String 
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Insert Method for Transaction Detail
        public bool InsertTransationDetail(transactionDetailBLL td)
        {
            //Create a boolean value and set its default value to false
            bool isSuccess = false;

            //Create a database connection here
            SqlConnection conn =new SqlConnection(myconnstrng);

            try
            {
                //Sql Query to Insert Transaction details
                string sql = "INSERT INTO tbl_transaction_detail (product_id, rate, qty, total, dea_cust_id, added_date, added_by) VALUES  (@product_id, @rate, @qty, @total, @dea_cust_id, @added_date, @added_by)";

                //Passing the value to the SQL Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values using cmd
                cmd.Parameters.AddWithValue("@product_id", td.product_id);
                cmd.Parameters.AddWithValue("@rate", td.rate);
                cmd.Parameters.AddWithValue("@qty", td.qty);
                cmd.Parameters.AddWithValue("@total", td.total);
                cmd.Parameters.AddWithValue("@dea_cust_id", td.dea_cust_id);
                cmd.Parameters.AddWithValue("@added_date", td.added_date);
                cmd.Parameters.AddWithValue("@added_by", td.added_by);

                //Open Database connection
                conn.Open();

                //daclare the int variable amd wxwcute the query
                int rows=cmd.ExecuteNonQuery();
                if (rows>0) 
                {
                    isSuccess = true;
                }
                else
                {
                    //Failed to Excute Query
                    isSuccess=false;
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                conn.Close(); 
            }

            return isSuccess;

        }
        #endregion
    }
}
