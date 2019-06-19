using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.POSDAL;
using PointOfSale.POSDTO;

namespace PointOfSale.POSDAL
{
    class ProductCategoryDAL
    {
        SqlConnection con;
        string conString;

        public ProductCategoryDAL()
        {
            conString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ShopBase;Data Source=SAM\\SQLEXPRESS";
        }

        // =================================== PRODUCT CATEGORY UPDATE DELETE SEARCH INSERT METHODS ================================



        // ===========================================  category insertion in Database =====================================================

        public void insertCatToDatabase(PCategoryDTO DTO)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "INSERT INTO dbo.PRODUCTCATEGORY (Category_Name,Business_Admin_Id)"
                                + " VALUES (@Category_Name,@Business_Admin_Id)";

                SqlCommand cm = new SqlCommand(sqlQuery, con);

                cm.Parameters.AddWithValue("@Category_Name", DTO.CATNAME);
                cm.Parameters.AddWithValue("@Business_Admin_Id", DTO.CATBADMIN);

                try
                {
                    cm.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Data Not Inserted!","Error");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Connection Not Successful to Database!","Error");
            }
        }

        ArrayList arr;
        public ArrayList searchAll()
        {
            arr = new ArrayList();
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Product_Category_Id,Category_Name,Business_Admin_Id"
                                + " FROM dbo.PRODUCTCATEGORY";

                SqlCommand cm = new SqlCommand(sqlQuery, con);
                
                try
                {
                    using (var reader = cm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //Check the reader has data:
                            while (reader.Read())
                            {
                                Int64 CATID = reader.GetInt64(reader.GetOrdinal("Product_Category_Id"));
                                string CATNAME = reader.GetString(reader.GetOrdinal("Category_Name"));
                                Int64 CATBADMIN = reader.GetInt64(reader.GetOrdinal("Business_Admin_Id"));
                                arr.Add(new PCategoryDTO(CATID,CATNAME,CATBADMIN));
                            }
                            con.Close();
                            return arr;
                            // If you need to use all rows returned use a loop:
                            /*while (reader.Read())
                            {
                                // Do something
                            }*/
                        }
                        else
                        {
                            MessageBox.Show("Record Not Found");
                            return arr;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Query Execution Error!");
                    return arr;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Not Successful to Database!");
                return arr;
            }
        }

        // =========================================== end of category insertion in Database =====================================================


        // =========================================== category search in Database =====================================================
        public void searchCatInDatabase(PCategoryDTO DTO)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Product_Category_Id,Category_Name,Business_Admin_Id"
                                + " FROM dbo.PRODUCTCATEGORY WHERE Category_Name=@Category_Name";

                SqlCommand cm = new SqlCommand(sqlQuery, con);
                cm.Parameters.AddWithValue("@Category_Name", DTO.CATNAME);
                DTO.CATNAME = "";
                try
                {
                    using (var reader = cm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //Check the reader has data:
                            if (reader.Read())
                            {
                                DTO.CATID = reader.GetInt64(reader.GetOrdinal("Product_Category_Id"));
                                DTO.CATNAME = reader.GetString(reader.GetOrdinal("Category_Name"));
                                DTO.CATBADMIN = reader.GetInt64(reader.GetOrdinal("Business_Admin_Id"));
                            }
                            con.Close();
                            // If you need to use all rows returned use a loop:
                            /*while (reader.Read())
                            {
                                // Do something
                            }*/
                        }
                        else
                        {
                            MessageBox.Show("Record Not Found");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Query Execution Error!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Not Successful to Database!");
            }
        }
       

        // ===========================================  end of category search in Database =====================================================


        // ===========================================  update in Database =====================================================

        public void updateCatToDatabase(PCategoryDTO DTO)
        {

            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "UPDATE dbo.PRODUCTCATEGORY SET Category_Name=@Category_Name,"
                                + "Business_Admin_Id=@Business_Admin_Id WHERE Product_CAtegory_Id=@Product_Category_Id";

                SqlCommand cm = new SqlCommand(sqlQuery, con);

                cm.Parameters.AddWithValue("@Product_Category_Id", DTO.CATID);
                cm.Parameters.AddWithValue("@Category_Name", DTO.CATNAME);
                cm.Parameters.AddWithValue("@Business_Admin_Id", DTO.CATBADMIN);

                try
                {
                    cm.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Data Not Updated!","Error");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Connection Not Successful to Database!","Error");
            }
        }

        // =========================================== end of update in Database =====================================================



        // ===========================================  delete in Database =====================================================

        public void deleteCatToDatabase(PCategoryDTO DTO)
        {

            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "DELETE FROM dbo.PRODUCTCATEGORY WHERE Product_Category_Id=@Product_Category_Id";

                SqlCommand cm = new SqlCommand(sqlQuery, con);

                cm.Parameters.AddWithValue("@Product_Category_Id", DTO.CATID);

                try
                {
                    cm.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Data Not Deleted!", "Error");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Connection Not Successful to Database!","Error");
            }
        }

        // =========================================== end of delete in Database =====================================================



        // ================================= END OF PRODUCT CATEGORY UPDATE DELETE SEARCH INSERT METHODS =============================



        // ========================================== Product population in comboBox method ========================================

        List<string> productCategories;
        public List<string> productComboPoping()
        {
             productCategories = new List<string>();
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Category_Name FROM dbo.PRODUCTCATEGORY";
                SqlCommand cm = new SqlCommand(sqlQuery, con);

                try
                {
                    using (var reader = cm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //Check the reader has data:
                            

                            while (reader.Read())
                            {
                                // Do something
                                productCategories.Add(reader.GetString(reader.GetOrdinal("Category_Name")));
                            }
                            con.Close();
                            return productCategories;
                        }
                        else
                        {
                            MessageBox.Show("Record Not Found");
                            return productCategories;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Query Execution Error!");
                }
                return productCategories;
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Not Successful to Database!");
                return productCategories;
            }
        }


        // ======================================== End of Product population in comboBox method ====================================






        // ============================================== ProductListing method ==========================================
   
       

        public ArrayList pListingSearch(PCategoryDTO DTO)
        {
            arr = new ArrayList();
            ProductManagementDAL DAL = new ProductManagementDAL();

            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Product_Id,Product_Name,Product_Code,Company,Stock_Keeping_Unit,Business_Admin_Id,Product_Category_Id"
                                + " FROM dbo.PRODUCT WHERE Product_Category_Id=@Product_Category_Id";
                
                SqlCommand cm = new SqlCommand(sqlQuery, con);
                cm.Parameters.AddWithValue("@Product_Category_Id", DAL.CatNametoID(DTO.CATNAME));
                //MessageBox.Show(DAL.CatNametoID(DTO.CATNAME)+"");
                DTO.CATNAME = "";
                try
                {
                    using (var reader = cm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //Check the reader has data:
                            
                            while (reader.Read())
                            {
                                // Do something
                                Int64 PID = reader.GetInt64(reader.GetOrdinal("Product_Id"));
                                string PNAME = reader.GetString(reader.GetOrdinal("Product_Name"));
                                string PCODE = reader.GetString(reader.GetOrdinal("Product_Code"));
                                string PCOMPANY = reader.GetString(reader.GetOrdinal("Company"));
                                string PSTOCKUNIT = reader.GetString(reader.GetOrdinal("Stock_Keeping_Unit"));
                                Int64 PBADMIN = reader.GetInt64(reader.GetOrdinal("Business_Admin_Id"));
                                string PCATEGORY = DAL.CatIDtoName(reader.GetInt64(reader.GetOrdinal("Product_Category_Id")));
                                arr.Add(new ProductDTO(PID, PNAME,PCODE,PCOMPANY,PSTOCKUNIT,PBADMIN,PCATEGORY));
                            }
                            con.Close();
                            return arr;
                        }
                        else
                        {
                            MessageBox.Show("Record Not Found", "Error");
                            return arr;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Query Execution error!", "Error");
                    return arr;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Connection Not Successful to Database!","Error");
                return arr;
            }
        }


        // ============================================= End of ProductListing method =============================================

    }
}
