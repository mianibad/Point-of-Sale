using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.POSDTO;

namespace PointOfSale.POSDAL
{
    class ProductManagementDAL
    {
        SqlConnection con;
        string conString;
        public static List<string> productDetails = new List<string>();
        ArrayList arr = new ArrayList();


        public ProductManagementDAL()
        {
            conString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ShopBase;Data Source=SAM\\SQLEXPRESS";
        }
      


        public string connectToDatabase()
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();
                return "Connected Successfully to Database!";
            }
            catch (Exception)
            {
                return "Connection Not Successful to Database!";
            }
        }

        public void disconnectToDatabase()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {

            }
        }





        public ArrayList getAllProducts()
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Product_Id,Product_Name,Product_Code,Company,Stock_Keeping_Unit,Business_Admin_Id,Product_Category_Id"
                                + " FROM dbo.PRODUCT";

                SqlCommand cm = new SqlCommand(sqlQuery, con);

                try
                {
                    using (var reader = cm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // If you need to use all rows returned use a loop:
                            while (reader.Read())
                            {
                                Int64 PID = reader.GetInt64(reader.GetOrdinal("Product_Id"));
                                string PNAME = reader.GetString(reader.GetOrdinal("Product_Name"));
                                string PCODE = reader.GetString(reader.GetOrdinal("Product_Code"));
                                string PCOMPANY = reader.GetString(reader.GetOrdinal("Company"));
                                string PSTOCKUNIT = reader.GetString(reader.GetOrdinal("Stock_Keeping_Unit"));
                                Int64 PBADMIN = reader.GetInt64(reader.GetOrdinal("Business_Admin_Id"));
                                string PCATEGORY = CatIDtoName(reader.GetInt64(reader.GetOrdinal("Product_Category_Id")));
                                arr.Add(new ProductDTO(PID, PNAME, PCODE, PCOMPANY, PSTOCKUNIT, PBADMIN, PCATEGORY));
                            }
                            con.Close();
                            return arr;
                        }
                        else
                        {
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
                MessageBox.Show("Connection Not Successful to Database!", "Error");
                return arr;
            }
        }




        // ================================= PRODUCT UPDATE DELETE SEARCH INSERT METHODS =================================



        // ===========================================  insertion in Database =====================================================

        public void insertToDatabase(ProductDTO dto)
        {
           
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "INSERT INTO dbo.PRODUCT (Product_Name,Product_Code,Company,Stock_Keeping_Unit,Business_Admin_Id,Product_Category_Id)"
                                + " VALUES (@Product_Name,@Product_Code,@Company,@Stock_Keeping_Unit,@Business_Admin_Id,@Product_Category_Id)";

                SqlCommand cm = new SqlCommand(sqlQuery, con);

                cm.Parameters.AddWithValue("@Product_Name", dto.PNAME);
                cm.Parameters.AddWithValue("@Product_Code", dto.PCODE);
                cm.Parameters.AddWithValue("@Company", dto.PCOMPANY);
                cm.Parameters.AddWithValue("@Stock_Keeping_Unit", dto.PSTOCKUNIT);
                cm.Parameters.AddWithValue("@Business_Admin_Id", dto.PBADMIN);
                cm.Parameters.AddWithValue("@Product_Category_Id", CatNametoID(dto.PCATEGORY)); 

                try
                {
                    cm.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Data Not Inserted!", "Error");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Connection Not Successful to Database!", "Error");
            }
        }

        // =========================================== end of insertion in Database =====================================================



        // ===========================================  search in Database =====================================================
        public ArrayList searchInDatabase(string a, string b)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Product_Id,Product_Name,Product_Code,Company,Stock_Keeping_Unit,Business_Admin_Id,Product_Category_Id"
                                + " FROM dbo.PRODUCT WHERE Product_Name LIKE '%"+a+"%' OR Product_Code LIKE '%"+b+"%'";

                SqlCommand cm = new SqlCommand(sqlQuery, con);
                //cm.Parameters.AddWithValue("@Product_Name", a);
                //cm.Parameters.AddWithValue("@Product_Code", b);
                try
                {
                    using (var reader = cm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // If you need to use all rows returned use a loop:
                            while (reader.Read())
                            {
                                Int64 PID = reader.GetInt64(reader.GetOrdinal("Product_Id"));
                                string PNAME = reader.GetString(reader.GetOrdinal("Product_Name"));
                                string PCODE = reader.GetString(reader.GetOrdinal("Product_Code"));
                                string PCOMPANY = reader.GetString(reader.GetOrdinal("Company"));
                                string PSTOCKUNIT = reader.GetString(reader.GetOrdinal("Stock_Keeping_Unit"));
                                Int64 PBADMIN = reader.GetInt64(reader.GetOrdinal("Business_Admin_Id"));
                                string PCATEGORY = CatIDtoName(reader.GetInt64(reader.GetOrdinal("Product_Category_Id")));
                                arr.Add(new ProductDTO(PID, PNAME, PCODE, PCOMPANY, PSTOCKUNIT, PBADMIN, PCATEGORY)); 
                            }
                            con.Close();
                            return arr;
                        }
                        else
                        {
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
                MessageBox.Show("Connection Not Successful to Database!", "Error");
                return arr;
            }
        }
       

        // ===========================================  end of search in Database =====================================================




        // ===========================================  update in Database =====================================================

        public void updateToDatabase(ProductDTO DTO)
        {

            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "UPDATE dbo.PRODUCT SET Product_Name=@Product_Name,Product_Code=@Product_Code,Company=@Company,Stock_Keeping_Unit=@Stock_Keeping_Unit,"
                                + "Business_Admin_Id=@Business_Admin_Id,Product_Category_Id=@Product_Category_Id WHERE Product_Id=@Product_Id";

                SqlCommand cm = new SqlCommand(sqlQuery, con);

                cm.Parameters.AddWithValue("@Product_Id", DTO.PID);
                cm.Parameters.AddWithValue("@Product_Name", DTO.PNAME);
                cm.Parameters.AddWithValue("@Product_Code", DTO.PCODE);
                cm.Parameters.AddWithValue("@Company", DTO.PCOMPANY);
                cm.Parameters.AddWithValue("@Stock_Keeping_Unit", DTO.PSTOCKUNIT);
                cm.Parameters.AddWithValue("@Business_Admin_Id", DTO.PBADMIN);
                cm.Parameters.AddWithValue("@Product_Category_Id", CatNametoID(DTO.PCATEGORY)); 

                try
                {
                    cm.ExecuteNonQuery();
                    con.Close();

                }
                catch (Exception)
                {
                    MessageBox.Show("Data Not Updated!", "Error");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Connection Not Successful to Database!", "Error");
            }
        }

        // =========================================== end of update in Database =====================================================



        // ===========================================  delete in Database =====================================================

        public void deleteToDatabase(ProductDTO DTO)
        {

            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "DELETE FROM dbo.PRODUCT WHERE Product_Id=@Product_Id";

                SqlCommand cm = new SqlCommand(sqlQuery, con);

                cm.Parameters.AddWithValue("@Product_Id", DTO.PID);

                try
                {
                    cm.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Data Not Deleted!","Error");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Connection Not Successful to Database!","Error");
            }
        }

        // =========================================== end of delete in Database =====================================================




        // =========================================== to convert category name to ID and Viseversa ===================================

        public Int64 CatNametoID(string name)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Product_Category_Id"
                                + " FROM dbo.PRODUCTCATEGORY WHERE Category_Name=@Category_Name";

                SqlCommand cm = new SqlCommand(sqlQuery, con);
                cm.Parameters.AddWithValue("@Category_Name", name);

                try
                {
                    using (var reader = cm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //Check the reader has data:
                            if (reader.Read())
                            {
                                return reader.GetInt64(reader.GetOrdinal("Product_Category_Id"));
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
                            MessageBox.Show("Record Not Found","Category Name To ID");
                        }
                    }
                }
                catch (Exception)
                {
                    return 0;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public string CatIDtoName(Int64 id)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Category_Name"
                                + " FROM dbo.PRODUCTCATEGORY WHERE Product_Category_Id=@Product_Category_Id";

                SqlCommand cm = new SqlCommand(sqlQuery, con);
                cm.Parameters.AddWithValue("@Product_Category_Id", id);

                try
                {
                    using (var reader = cm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //Check the reader has data:
                            if (reader.Read())
                            {
                                return reader.GetString(reader.GetOrdinal("Category_Name"));
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
                            MessageBox.Show("Record Not Found","Category ID To Name");
                        }
                    }
                }
                catch (Exception)
                {
                    return "";
                }
                return "";
            }
            catch (Exception)
            {
                return"";
            }
        }

        // =========================================== end to convert category name to ID and Viseversa ===================================

        // =================================== END OF PRODUCT UPDATE DELETE SEARCH INSERT METHODS ===================================




        // =================================== order's product searching through category ==========================================
        
        public ArrayList searchProdOfCategory(ProductDTO dto)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Product_Id,Product_Name"
                                + " FROM dbo.PRODUCT WHERE Product_Category_Id=@Product_Category_Id";

                SqlCommand cm = new SqlCommand(sqlQuery, con);
                cm.Parameters.AddWithValue("@Product_Category_Id", CatNametoID(dto.PCATEGORY));

                try
                {
                    using (var reader = cm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //Check the reader has data:
                            /*if (reader.Read())
                            {
                                return reader.GetInt64(reader.GetOrdinal("Product_Category_Id"));
                            }*/
                            // If you need to use all rows returned use a loop:
                            while (reader.Read())
                            {
                                Int64 id = reader.GetInt64(reader.GetOrdinal("Product_Id"));
                                string PNAME = reader.GetString(reader.GetOrdinal("Product_Name"));
                                ProductDTO pDto = new ProductDTO(id,PNAME,"","","",1,dto.PCATEGORY);
                                arr.Add(pDto);
                            }
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Record Not Found", "Category Name To ID");
                        }
                    }
                }
                catch (Exception)
                {
                    return arr;
                }
                return arr;
            }
            catch (Exception)
            {
                return arr;
            }
        }



        public Int64 prodNameToID(ProductDTO dto)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Product_Id"
                                + " FROM dbo.PRODUCT WHERE Product_Name=@Product_Name";

                SqlCommand cm = new SqlCommand(sqlQuery, con);
                cm.Parameters.AddWithValue("@Product_Name", dto.PNAME);

                try
                {
                    using (var reader = cm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //Check the reader has data:
                            if (reader.Read())
                            {
                                return reader.GetInt64(reader.GetOrdinal("Product_Id"));
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
                            MessageBox.Show("Record Not Found", "Category Name To ID");
                        }
                    }
                }
                catch (Exception)
                {
                    return 0;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
        }



        public string prodIDToName(ProductDTO dto)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Product_Name"
                                + " FROM dbo.PRODUCT WHERE Product_Id=@Product_Id";

                SqlCommand cm = new SqlCommand(sqlQuery, con);
                cm.Parameters.AddWithValue("@Product_Id", dto.PID);

                try
                {
                    using (var reader = cm.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            //Check the reader has data:
                            if (reader.Read())
                            {
                                return reader.GetString(reader.GetOrdinal("Product_Name"));
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
                            MessageBox.Show("Record Not Found", "Category Name To ID");
                        }
                    }
                }
                catch (Exception)
                {
                    return "";
                }
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

    }
}
