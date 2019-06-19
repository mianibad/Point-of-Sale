using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PointOfSale.POSDTO;

namespace PointOfSale.POSDAL
{
    class OrderProductDAL
    {
        SqlConnection con;
        string conString;

        public OrderProductDAL()
        {
            conString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ShopBase;Data Source=SAM\\SQLEXPRESS";
        }

        public void insert(OrderProductDTO dto)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "INSERT INTO [ShopBase].[dbo].[ORDERPRODUCT] (Order_Id,Product_Id,Quantity,Size)"
                                + " VALUES (@Order_Id,@Product_Id,@Quantity,@Size)";

                SqlCommand cm = new SqlCommand(sqlQuery, con);

                cm.Parameters.AddWithValue("@Order_Id", dto.ORDERID);
                cm.Parameters.AddWithValue("@Product_Id", dto.PRODUCTID);
                cm.Parameters.AddWithValue("@Quantity", dto.QUANTITY);
                cm.Parameters.AddWithValue("@Size", dto.SIZE);

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


        ArrayList arr = new ArrayList();
        public ArrayList search(OrderProductDTO DTO)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Order_Id,Product_Id,Quantity,Size"
                                + " FROM [ShopBase].[dbo].[ORDERPRODUCT] WHERE Order_Id=@Order_Id";

                SqlCommand cm = new SqlCommand(sqlQuery, con);
                cm.Parameters.AddWithValue("@Order_Id", DTO.ORDERID);
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
                                Int64 opID = reader.GetInt64(reader.GetOrdinal("Order_Id"));
                                Int64 opProduct = reader.GetInt64(reader.GetOrdinal("Product_Id"));
                                string oQuantity = reader.GetString(reader.GetOrdinal("Quantity"));
                                string oSize = reader.GetString(reader.GetOrdinal("Size"));

                                arr.Add(new OrderProductDTO(opID,opProduct,oQuantity,oSize));
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



        public void delete(OrderProductDTO DTO)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "DELETE FROM [ShopBase].[dbo].[ORDERPRODUCT] WHERE Product_Id=@Product_Id";

                SqlCommand sc = new SqlCommand(sqlQuery, con);
                sc.Parameters.AddWithValue("@Product_Id", DTO.PRODUCTID);

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





    }
}
