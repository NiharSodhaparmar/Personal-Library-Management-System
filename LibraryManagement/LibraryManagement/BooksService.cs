using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LibraryManagement
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class BooksService : IBooksService
    {

        //MANAGE CATEGORIES -----------------------------------------------------------------------

        public DataSet GetCategories()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=LibraryDB;Integrated Security=True");
                string Query = "SELECT * from Category";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }

            return ds;
        }


        public string addCategory(string categoryName)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=LibraryDB;Integrated Security=True");
            SqlCommand cmd;
            cmd = new SqlCommand("insert into Category(Category) values(@category)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@category", categoryName);
            cmd.ExecuteNonQuery();
            con.Close();
            return "Catregory Added Succesfully";
        }


        public string deleteCategory(int id)
        {
            string result = "";
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=LibraryDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd = new SqlCommand("SELECT count(*) FROM Book_Category Where CId=@CId", con);
            cmd.Parameters.AddWithValue("@CId", id);
            con.Open();
            int rows = Convert.ToInt32(cmd.ExecuteScalar());
            //SqlDataReader reader = cmd.ExecuteReader();
            con.Close();
            if(rows > 0)
            {
                result = "false";
            }
            else
            {
                string Query = "DELETE FROM Category Where CId=@CId";
                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@CId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Deleted Successfully!";
            }
            
            return result;
        }

        public string updateCategory(int id, string newCategoryName)
        {
            string result = "";
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=LibraryDB;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();

            string Query = "UPDATE Category SET Category=@Category WHERE CId=@CId";

            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@CId", id);
            cmd.Parameters.AddWithValue("@Category", newCategoryName);
            con.Open();
            cmd.ExecuteNonQuery();
            result = "Record Updated Successfully !";
            con.Close();

            return result;
        }


        //MANAGE BOOKS ----------------------------------------------------------------------------

        public DataSet getBooks()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=LibraryDB;Integrated Security=True");
                string Query = "SELECT * from Books";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }

            return ds;
        }

        public string addBooks(string bookName, string author, string edition, string pages, string price, Dictionary<string, int> dictionary)
        {
            int bookId = 2;
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=LibraryDB;Integrated Security=True");
            SqlCommand cmd;
            cmd = new SqlCommand("insert into Books (Title,Price,Author,Pages,Edition) values(@Title,@Price,@Author,@Pages,@Edition)", con);
            con.Open();
            cmd.Parameters.AddWithValue("@Title",bookName);
            cmd.Parameters.AddWithValue("@Price",price);
            cmd.Parameters.AddWithValue("@Author",author);
            cmd.Parameters.AddWithValue("@Pages",pages);
            cmd.Parameters.AddWithValue("@Edition",edition);
            cmd.ExecuteNonQuery();
            con.Close();

            cmd = new SqlCommand("select max(BID) from books;", con);
            con.Open();
            bookId = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            foreach (var i in dictionary)
            {
                cmd = new SqlCommand("insert into Book_Category (CId,BId) values(@CId,@BId)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@CId",i.Value);
                cmd.Parameters.AddWithValue("@BId",bookId);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return "Book Added Succesfully";
        }


        public string deleteBook(int bookId)
        {
            List<int> cids = new List<int>();
            string result = "";
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=LibraryDB;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            string Query = "DELETE FROM Books Where BId=@BId";
            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@BId", bookId);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            cmd = new SqlCommand("DELETE from Book_Category where BId=@BId", con);
            cmd.Parameters.AddWithValue("@BId", bookId);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            result = "Record Deleted Successfully!";
            return result;

        }


        public string updateBook(int bookId, string bookName, string author, string edition, string pages, string price, Dictionary<string, int> d)
        {
            string result = "";
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=LibraryDB;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();

            string Query = "UPDATE Books SET Title=@Title,Price=@price,Author=@Author,Pages=@Pages,Edition=@Edition WHERE BId=@BId";

            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@BId", bookId);
            cmd.Parameters.AddWithValue("@Title",bookName );
            cmd.Parameters.AddWithValue("@Price",price );
            cmd.Parameters.AddWithValue("@Author",author );
            cmd.Parameters.AddWithValue("@Pages",pages );
            cmd.Parameters.AddWithValue("@Edition",edition );
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            cmd = new SqlCommand("DELETE from Book_Category where BId=@BId", con);
            cmd.Parameters.AddWithValue("@BId", bookId);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            foreach (var i in d)
            {
                cmd = new SqlCommand("insert into Book_Category (CId,BId) values(@CId,@BId)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@CId", i.Value);
                cmd.Parameters.AddWithValue("@BId", bookId);
                cmd.ExecuteNonQuery();
                con.Close();
            }

            result = "Record Updated Successfully !";
            

            return result;

        }


        public DataSet getBooksByCategory(string category)
        {
            DataSet ds = new DataSet();
            DataTable table = new DataTable("Books");
            table.Columns.Add("BId");
            table.Columns.Add("Title");
            table.Columns.Add("Author");
            table.Columns.Add("Edition");
            table.Columns.Add("Pages");
            table.Columns.Add("Price");

            int cid = 0 ;
            List<int> bookIds = new List<int>();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=LibraryDB;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * from Category where Category=@Category", con);
                cmd.Parameters.AddWithValue("@Category", category);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    cid = Convert.ToInt32(reader["CId"]);
                }
                con.Close();

                cmd = new SqlCommand("SELECT * from Book_Category where CId=@CId", con);
                cmd.Parameters.AddWithValue("@CId", cid);
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bookIds.Add(Convert.ToInt32(reader["BId"]));
                }
                con.Close();

                foreach (var bookId in bookIds)
                {
                    cmd = new SqlCommand("SELECT * from Books where BId=@BId", con);
                    cmd.Parameters.AddWithValue("@BId", bookId);
                    con.Open();
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        table.Rows.Add(Convert.ToInt32(reader["BId"]), reader["Title"], reader["Author"], reader["Edition"], reader["Pages"], reader["Price"]);
                    }
                    con.Close();
                }
                ds.Tables.Add(table);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }

            return ds;
        }


        //public Dictionary<string, int> getBook_Categories(int id)
        //{
        //    List<int> cids = new List<int>();
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=LibraryDB;Integrated Security=True");
        //        SqlCommand cmd;
        //        cmd = new SqlCommand("SELECT CId from Book_Category where BId=@BId", con);
        //        cmd.Parameters.AddWithValue("@BId", id);
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while(reader.Read())
        //        {
        //            cids.Add(Convert.ToInt32(reader["CId"]));
        //        }
        //        con.Close();
        //    }
        //    catch (FaultException fex)
        //    {
        //        throw new FaultException<string>("Error: " + fex);
        //    }

        //}

    }
}
