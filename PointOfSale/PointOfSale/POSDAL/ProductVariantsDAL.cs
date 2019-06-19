using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.POSDTO;
using System.Windows.Forms;

namespace PointOfSale.POSDAL
{
    class ProductVariantsDAL
    {
        SqlConnection con;
        string conString;
        ArrayList arr;
        public ProductVariantsDAL()
        {
            conString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ShopBase;Data Source=SAM\\SQLEXPRESS";
        }

        public void addVariants(ProductVariantsDTO pvDTO)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "INSERT INTO [ShopBase].[dbo].[PRODUCTVARIANTS] (Price,Flavor,Size,Product_Id)"
                                + " VALUES (@Price,@Flavor,@Size,@Product_Id)";

                SqlCommand cm = new SqlCommand(sqlQuery, con);

                cm.Parameters.AddWithValue("@Price", pvDTO.PRICE);
                cm.Parameters.AddWithValue("@Flavor", pvDTO.FLAVOR);
                cm.Parameters.AddWithValue("@Size", pvDTO.SIZE);
                cm.Parameters.AddWithValue("@Product_Id", pvDTO.PRODUCTID);

                try
                {
                    cm.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Data Not Inserted!", "Variants Error");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Connection Not Successful to Database!", "Error");
            }
        }

        public void updateVariants(ProductVariantsDTO pvDTO)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "UPDATE [ShopBase].[dbo].[PRODUCTVARIANTS]  SET Price=@Price,Flavor=@Flavor,Size=@Size"
                                + ",Product_Id=@Product_Id WHERE Product_Variants_Id=@Product_Variants_Id";

                SqlCommand cm = new SqlCommand(sqlQuery, con);

                cm.Parameters.AddWithValue("@Product_Variants_Id", pvDTO.PRODVARID);
                cm.Parameters.AddWithValue("@Price", pvDTO.PRICE);
                cm.Parameters.AddWithValue("@Flavor", pvDTO.FLAVOR);
                cm.Parameters.AddWithValue("@Size", pvDTO.SIZE);
                cm.Parameters.AddWithValue("@Product_Id", pvDTO.PRODUCTID);

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


        public void deleteVariant(Int64 pvDAL)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "DELETE FROM [ShopBase].[dbo].[PRODUCTVARIANTS] WHERE Product_Variants_Id=@Product_Variants_Id";

                SqlCommand sc = new SqlCommand(sqlQuery, con);
                sc.Parameters.AddWithValue("@Product_Variants_Id", pvDAL);

                try
                {
                    sc.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Data Not Deleted!", "ERROR");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection To Database Failed!", "ERROR");
            }
        }


        public ArrayList searchAllVariant(Int64 productID)
        {
            arr = new ArrayList();
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Product_Variants_Id,Price,Flavor,Size"
                                + " FROM [ShopBase].[dbo].[PRODUCTVARIANTS] WHERE Product_Id=@Product_Id";

                SqlCommand cm = new SqlCommand(sqlQuery, con);
                cm.Parameters.AddWithValue("@Product_Id", productID);

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
                                Int64 pvID = reader.GetInt64(reader.GetOrdinal("Product_Variants_Id"));
                                string price = reader.GetString(reader.GetOrdinal("Price"));
                                string flavor = reader.GetString(reader.GetOrdinal("Flavor"));
                                string size = reader.GetString(reader.GetOrdinal("Size"));
                                

                                arr.Add(new ProductVariantsDTO(pvID,price,flavor,size));
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
                MessageBox.Show("Connection Not Successful to Database!", "Error");
                return arr;
            }
        }
    }
}
