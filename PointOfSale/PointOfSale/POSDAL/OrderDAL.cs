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
    class OrderDAL
    {
        SqlConnection con;
        string conString;
        ArrayList arr;
        public OrderDAL()
        {
            conString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ShopBase;Data Source=SAM\\SQLEXPRESS";
        }

        public void InsertRecordOrder(OrderDTO dto)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "INSERT INTO [ShopBase].[dbo].[ORDER] (Order_Title,Order_Date,Status,Business_Admin_Id)"
                                + " VALUES (@Order_Title,@Order_Date,@Status,@Business_Admin_Id)";

                SqlCommand cm = new SqlCommand(sqlQuery, con);

                cm.Parameters.AddWithValue("@Order_Title", dto.ORDERTITLE);
                cm.Parameters.AddWithValue("@Order_Date", dto.ORDERDATE);
                cm.Parameters.AddWithValue("@Status", dto.ORDERSTATUS);
                cm.Parameters.AddWithValue("@Business_Admin_Id", dto.ORDERADMIN);

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


        // ======================================= Search order Record ======================================================

        
        public ArrayList SearchRecordOrder(OrderDTO dto)
        {
            arr = new ArrayList();
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Order_Id,Order_Title,Order_Date,Status"
                                + " FROM [ShopBase].[dbo].[ORDER] WHERE Status<>'Delivered'";

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
                                Int64 oID = reader.GetInt64(reader.GetOrdinal("Order_Id"));
                                string oTitle = reader.GetString(reader.GetOrdinal("Order_Title"));
                                DateTime oDate = DateTime.Parse((reader["Order_Date"]).ToString());
                                string oStatus = reader.GetString(reader.GetOrdinal("Status"));
                                Int64 oAdmin = 1;//reader.GetInt64(reader.GetOrdinal("Business_Admin_Id"));

                                arr.Add(new OrderDTO(oID,oTitle,oDate,oStatus,oAdmin));
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


        // ============================================= Delete Record =========================================

        public void DeleteRecord(OrderDTO dto)
        {

            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "DELETE FROM [ShopBase].[dbo].[ORDER] WHERE Order_Id=@Order_Id";

                SqlCommand sc = new SqlCommand(sqlQuery, con);
                sc.Parameters.AddWithValue("@Order_Id", dto.ORDERID);

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


        // ============================================= Update Record =========================================

        public void UpdateRecord(OrderDTO dto)
        {
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();
                
                string sqlQuery = "UPDATE [ShopBase].[dbo].[ORDER]  SET Order_Title=@Order_Title,Order_Date=@Order_Date,Status=@Status"
                                + ",Business_Admin_Id=@Business_Admin_Id WHERE Order_Id=@Order_Id";

                SqlCommand cm = new SqlCommand(sqlQuery, con);

                cm.Parameters.AddWithValue("@Order_Id", dto.ORDERID);
                cm.Parameters.AddWithValue("@Order_Title", dto.ORDERTITLE);
                cm.Parameters.AddWithValue("@Order_Date", dto.ORDERDATE);
                cm.Parameters.AddWithValue("@Status", dto.ORDERSTATUS);
                cm.Parameters.AddWithValue("@Business_Admin_Id", dto.ORDERADMIN);

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


        // ================================ Search order in list by typing in textbox DAL method =======================================
        public ArrayList searchByTyping(string getText)
        {
            arr = new ArrayList();
            try
            {
                con = new SqlConnection();
                con.ConnectionString = conString;
                con.Open();

                string sqlQuery = "SELECT Order_Id,Order_Title,Order_Date,Status"
                                + " FROM [ShopBase].[dbo].[ORDER] WHERE Order_Title LIKE '%"+getText+"%' And Status<>'Delivered'";

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
                                Int64 oID = reader.GetInt64(reader.GetOrdinal("Order_Id"));
                                string oTitle = reader.GetString(reader.GetOrdinal("Order_Title"));
                                DateTime oDate = DateTime.Parse((reader["Order_Date"]).ToString());
                                string oStatus = reader.GetString(reader.GetOrdinal("Status"));
                                Int64 oAdmin = 1;//reader.GetInt64(reader.GetOrdinal("Business_Admin_Id"));

                                arr.Add(new OrderDTO(oID, oTitle, oDate, oStatus, oAdmin));
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
    }
}
