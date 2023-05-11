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
    public class categoriesDAL
    {
        //Static String Method for Database Connection String
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;


        #region Select Method
        public DataTable Select()
        {
            //Creating Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //Wrting SQL Query to get all the data from Database
                string sql = "SELECT * FROM tbl_categories";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //Open Database Connection
                conn.Open();

                //Adding the value from adapter to Data table dt
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
        #region Insert New Category
        public bool Insert(categoriesBLL c)
        {
            //Creating A Boolean Varible and set its default value to false
            bool isSuccess = false;

            //Creating to Database
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Writing Query to Add New Category
                string sql = "INSERT INTO tbl_categories (title, description, added_date, added_by) VALUES (@title, @description, @added_date, @added_by)" ;

                //Creating SQL Command to pass values in our query
                SqlCommand cmd = new SqlCommand(sql,conn);
                //Passing Values through parameter
                cmd.Parameters.AddWithValue("@title",c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);


                //Open Database Connection
                conn.Open();

                //Creating the int varible to exucute query
                int rows = cmd.ExecuteNonQuery();

                //If the query is executed successfully then its value will be greater than ) else it will be less than )

                if(rows>0)
                {
                    //Query Executed Succeddfully
                    isSuccess = true;   
                }else
                {
                    //Failed to Execute Query
                    isSuccess=false;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing Database Connection
                conn.Close ();
            }
                
            return isSuccess;
        }
        #endregion
        #region Update Method
        public bool Update(categoriesBLL c)
        {
            //Creating Boolean varible and set its dafault value to false
            bool isSuccess = false;
            //Creating sQL Connection 
            SqlConnection conn = new SqlConnection(myconnstrng);

            try 
            {
                //Query to UPdate category
                string sql = "UPDATE tbl_categories SET title=@title, description=@description, added_date=@added_date, added_by=@added_by WHERE id=@id";

                //Sql Command to Pass the Value on Sql Query
                SqlCommand cmd = new SqlCommand(sql,conn);

                //Passing Value using cmd
                cmd.Parameters.AddWithValue("@title", c.title);
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@id",c.id);


                //Open Database Connection
                conn.Open();

                //Create Int Varible to execute query
                int rows = cmd.ExecuteNonQuery();
                //if the query is successfully executed then the value will be grater than zero

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
        #region Delete Category Method
        public bool Delete(categoriesBLL c)
        {
            //Create a Boolean varible and set its value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng); 

            try
            {
                //SQL Query to Delete from Database
                string sql = "DELETE FROM tbl_categories WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql,conn);

                //Passing the value using cmd
                cmd.Parameters.AddWithValue("@id", c.id);

                //Open SqlConnection
                conn.Open ();

               int rows = cmd.ExecuteNonQuery();

                //If the query is executed successfullly then the value of rows will be greater than zero else it will be less than 0
               if(rows>0) 
               {
                    //Query Executed Successfully
                    isSuccess=true;
               }
               else
               {
                    //Failed to Exectue Query
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
        #region Method for search Funtionality

        public DataTable Search(string keywords)
        {
            //SQL Connection For Database Connection
            SqlConnection conn = new SqlConnection(myconnstrng);


            //Create Data Table to hold the data from database temporarily
            DataTable dt = new DataTable();

            try
            {
                //SQL Query To Search Categories from Database
                String sql = "SELECT * FROM tbl_categories WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' OR description LIKE '%" + keywords + "%'";
                //Creating SQL Command to Execute the Query
                SqlCommand cmd =new SqlCommand(sql,conn);

                //Getting Data From Database 
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open DatabaseConnection
                conn.Open ();

                //Passing values from adapter to Data Table dt
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close ();
            }
            return dt;
        }
        #endregion
    }
}
