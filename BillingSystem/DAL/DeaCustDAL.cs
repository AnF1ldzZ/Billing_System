using BillingSystem.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingSystem.DAL
{
    public class DeaCustDAL
    {
        //static staing Mthod for Database Connection 
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region SELECT Method for Dealer and Customer
        public DataTable Select()
        {
            //SQL Connection for DAtabase Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //DataTable to hold the value from database and return it 
            DataTable dt = new DataTable();
            try
            {
                //write SQL Query Select all the Data From Database
                string sql = "SELECT * FROM tbl_dea_cust";
                //Creating SQL Command to execute Query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating SQL Data Adapter to Store Data From Database Temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Databsae Connection 
                conn.Open();

                //Passign the value from SQL DAta Adapter to Data table
                adapter.Fill(dt);    
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                conn.Close(); 
            }
            return dt;
        }
        #endregion
        #region INSERT Method to Add details for Dealer or Customer
        public bool Insert(DeaCustBLL dc)
        {
            //Creating SQL Connection First
            SqlConnection conn = new SqlConnection(myconnstrng); 

            //Creating and Boolean value and set its default value to false
            bool isSuccess  =false;

            try
            {
                //Write SQL Query to Insert Details Dealer or Customer
                string sql = "INSERT INTO tbl_dea_cust (type,name,email,contact,address,added_date,added_by) VALUES (@type,@name,@email,@contact,@address,@added_date,@added_by) ";

                //SQl Command to Pass the values to Query and execute
                SqlCommand cmd = new SqlCommand(@sql, conn);

                //Passing the calues uisng Parameters
                cmd.Parameters.AddWithValue("@type",dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);

                //Open DatabaseConnection
                conn.Open();

                //int varible to check whether the query is executed successfully or not 
                int rows = cmd.ExecuteNonQuery();

                //if the query is executed successfully then the value of rows will be greater than 0 else it will be less than 0
                if(rows>0)
                {
                    //Query Executed Successfully
                    isSuccess = true;   
                }
                else
                {
                    //Failed to Execute Query 
                    isSuccess = false;
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
        #region UPDATE Method for Dealer and Customer Module
        public bool Update(DeaCustBLL dc)
        {
            //SQL Connection for Database Connection 
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Create Boolean varible and set its default value to false
            bool isSuccess =false;

            try
            {
                //SQL Query to Update data in database 
                string sql = "UPDATE tbl_dea_cust SET type=@type ,name=@name ,email=@email ,contact=@contact, address=@address, added_date=@added_date, added_by=@added_by WHERE id=@id";
                //Create SQL Command to pass the value in sql
                SqlCommand cmd =new SqlCommand(@sql, conn);

                //Passing the values throuhg parameters
                cmd.Parameters.AddWithValue("@type", dc.type);
                cmd.Parameters.AddWithValue("@name", dc.name);
                cmd.Parameters.AddWithValue("@email", dc.email);
                cmd.Parameters.AddWithValue("@contact", dc.contact);
                cmd.Parameters.AddWithValue("@address", dc.address);
                cmd.Parameters.AddWithValue("@added_date", dc.added_date);
                cmd.Parameters.AddWithValue("@added_by", dc.added_by);
                cmd.Parameters.AddWithValue("@id", dc.id);

                //Open the Databas Connectiion 
                conn.Open();

                //Int varible to check if th query executed successfully or not
                int rows = cmd.ExecuteNonQuery();
                if(rows>0) 
                {
                    //Query Executed Successfully
                    isSuccess=true;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;

                }

            }
            catch(Exception ex) 
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
        #region DELETE Method for Dealer and Customer Module
        public bool Delete(DeaCustBLL dc)
        {
            //SQLConnection for Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Create a Boolean Varible and set its default value to false 
            bool isSuccess = false;

            try
            {
                //SQL Query to Delete DAta from Database
                string sql = "DELETE FROM tbl_dea_cust WHERE id=@id";

                //SQL command to pass the value 
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the value 
                cmd.Parameters.AddWithValue("@id", dc.id);

                //Open DB Connection
                conn.Open();

                //interger varible
                int rows = cmd.ExecuteNonQuery();
                if(rows>0) 
                {
                    //Query Executed Successfully 
                    isSuccess = true ;
                }
                else
                {
                    //Failed to Execute Query
                    isSuccess = false;
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
        #region SEARCH METHOD for Dealer and Customer Module 
        public DataTable Search(string keyword)
        {
            //Create a Sql Connection
            SqlConnection conn = new SqlConnection(myconnstrng);


            //Creating a Data Table and return its value
            DataTable dt = new DataTable();

            try
            {
                //Write the Query to Search Dealer or Customer Based in id, Type and name
                string sql = "SELECT * FROM tbl_dea_cust WHERE id LIKE '%" + keyword + "%' OR type LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";

                //Sql Command to Execute the Query
                SqlCommand cmd= new SqlCommand(sql, conn);
                //Sql Dat Adapeter to hold the data from database temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);


                //Open Data Base Connection
                conn.Open();
                //Pass the value from adapter to data table
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
            finally 
            { 
                conn.Close(); 
            }
            return dt;
        }
        #endregion
        #region METHOD TO SEARCH DEALER OR CUSTOMER FOR TRANSACTON MODULE
        public DeaCustBLL SearchDealerCustomerForTransaction(string keyword)
        {
            //Create an Object for DeaCustBLL class
            DeaCustBLL dc= new DeaCustBLL();

            //Create a Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Create a Data Table to hold the Value temporarily
            DataTable dt  = new DataTable();
            try
            {
                //Write a SQL Query to Search Dealer or Customer Based on Keywords
                string sql = "SELECT name, email, contact, address from tbl_dea_cust WHERE id LIKE '%" + keyword + "%' OR name LIKE '%"+keyword+"%' ";

                //Create a SQL Data Adapter to Execute the Query
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                //Open the Database Connection
                conn.Open();

                //Transfer the data from SqlData Adapter to Data Table
                adapter.Fill(dt);

                //If we have values on dt we need to save it in dealerCustomer BLL
                if (dt.Rows.Count > 0)
                {
                    dc.name = dt.Rows[0]["name"].ToString();
                    dc.email = dt.Rows[0]["email"].ToString();
                    dc.contact = dt.Rows[0]["contact"].ToString();
                    dc.address = dt.Rows[0]["address"].ToString();


                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close Database connection
                conn.Close();
            }
            return dc;
        }
        #endregion
        #region METHOD TO GET ID OF THE DEALER OR CUSTOMER BASED ON NAME
        public DeaCustBLL GetDeaCustIDFromName(string Name)
        {
            //First Create an Object of DeaCust BLL and Return it
            DeaCustBLL dc = new DeaCustBLL();

            //SQL Connection here
            SqlConnection conn = new SqlConnection(myconnstrng);
            //Data Table to Hold the data temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Query to Get id based on Name
                string sql = "SELECT id FROM tbl_dea_cust WHERE name= '"+Name+"' ";
                //Create the SQL Data Adapter to Execute the Query
                SqlDataAdapter adapter= new SqlDataAdapter(sql, conn);

                conn.Open();

                //Passing the Value from Adapter to DataTable
                adapter.Fill( dt );
                if(dt.Rows.Count>0)
                {
                    //Pass the value from dt to DeaCustBLL dc
                    dc.id = int.Parse(dt.Rows[0]["id"].ToString());
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                conn.Close();
            }

            return dc;

        }
        #endregion
    }
}
