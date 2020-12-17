using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryDAL
{
    public class DAL
    {
        private NpgsqlConnection con;
        public DAL()
        {
            con = new NpgsqlConnection(ConfigurationManager.AppSettings["PostgreConnection"]);
        }

		public DataTable PRC_LOGIN(string userName, string Password)
		{
			DataTable dt = new DataTable();

			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"libapp.f_prc_login", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("p_username", userName);
				cmd.Parameters.AddWithValue("p_password", Password);
                NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter(cmd);
                DataAdapter.Fill(dt);
            }
			catch (Exception ex)
			{

			}
			finally
			{
				con.Close();
				con.Dispose();
			}
			return dt;
		}

		public DataTable PRC_GET_BOOKS()
		{
			DataTable dt = new DataTable();
			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"libapp.f_prc_get_books", con);
				cmd.CommandType = CommandType.StoredProcedure;

				NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter(cmd);

				DataAdapter.Fill(dt);
			}
			catch (Exception ex)
			{

			}
			finally
			{
				con.Close();
				con.Dispose();
			}
			return dt;
		}

		public DataTable PRC_GET_BOOKS_BY_PARAM(string param)
		{
			DataTable dt = new DataTable();
			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"libapp.f_prc_get_books_by_param", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("p_book_name", param);

				NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter(cmd);

				DataAdapter.Fill(dt);
			}
			catch (Exception ex)
			{

			}
			finally
			{
				con.Close();
				con.Dispose();
			}
			return dt;
		}

		public DataTable PRC_GET_BOOK_TYPES()
		{
			DataTable dt = new DataTable();
			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"libapp.f_PRC_GET_BOOK_TYPES", con);
				cmd.CommandType = CommandType.StoredProcedure;

				NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter(cmd);

				DataAdapter.Fill(dt);
			}
			catch
			{

			}
			finally
			{
				con.Close();
				con.Dispose();
			}
			return dt;
		}

		public DataTable PRC_GET_BOOK_CATEGORIES()
		{
			DataTable dt = new DataTable();
			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"libapp.f_prc_get_book_categories", con);
				cmd.CommandType = CommandType.StoredProcedure;

				NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter(cmd);

				DataAdapter.Fill(dt);
			}
			catch
			{

			}
			finally
			{
				con.Close();
				con.Dispose();
			}
			return dt;
		}

		public DataTable PRC_GET_PRINTERY()
		{
			DataTable dt = new DataTable();
			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"libapp.f_prc_get_printery", con);
				cmd.CommandType = CommandType.StoredProcedure;

				NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter(cmd);

				DataAdapter.Fill(dt);
			}
			catch
			{

			}
			finally
			{
				con.Close();
				con.Dispose();
			}
			return dt;
		}

		public DataTable PRC_GET_CITY()
		{
			DataTable dt = new DataTable();
			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"libapp.f_PRC_GET_CITY", con);
				cmd.CommandType = CommandType.StoredProcedure;

				NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter(cmd);

				DataAdapter.Fill(dt);
			}
			catch
			{

			}
			finally
			{
				con.Close();
				con.Dispose();
			}
			return dt;
		}

		public DataTable PRC_GET_TOWN(string cityName)
		{
			DataTable dt = new DataTable();
			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"libapp.f_PRC_GET_TOWN", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("p_cityname", cityName);
				NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter(cmd);

				DataAdapter.Fill(dt);
			}
			catch
			{

			}
			finally
			{
				con.Close();
				con.Dispose();
			}
			return dt;
		}

		public DataTable PRC_GET_HIRED_BOOK(string userName)
		{
			DataTable dt = new DataTable();
			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"libapp.f_prc_get_hired_book", con);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("p_username", userName);

				NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter(cmd);

				DataAdapter.Fill(dt);
			}
			catch (Exception ex)
			{

			}
			finally
			{
				con.Close();
				con.Dispose();
			}
			return dt;
		}

		public DataTable PRC_GET_LANG()
		{
			DataTable dt = new DataTable();
			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"libapp.f_prc_get_lang", con);
				cmd.CommandType = CommandType.StoredProcedure;

				NpgsqlDataAdapter DataAdapter = new NpgsqlDataAdapter(cmd);

				DataAdapter.Fill(dt);
			}
			catch
			{

			}
			finally
			{
				con.Close();
				con.Dispose();
			}
			return dt;
		}
		public int PRC_DML_PRINTERY(string PrinteryName, string townName, string cityName, string adress)
		{
			int etkilenen = 0;

			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"call libapp.PRC_DML_PRINTERY(:p_printeryname,:p_townname,:p_cityname,:p_adress)", con);
				cmd.CommandType = CommandType.Text;

				cmd.Parameters.AddWithValue("p_printeryname", PrinteryName);
				cmd.Parameters.AddWithValue("p_townname", townName);
				cmd.Parameters.AddWithValue("p_cityname", cityName);
				cmd.Parameters.AddWithValue("p_adress", adress);
				etkilenen = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				etkilenen = -1;
			}
			finally
			{
				con.Close();
				con.Dispose();
			}

			return etkilenen;
		}

		public int PRC_DML_BOOK(int bookId, string dmlType, string bookName, string printeryDate, string writerName, string writerSurname, string printery, string category, string typeName, int hirePrice, int langId)
		{
			int etkilenen = 0;

			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"call libapp.PRC_DML_BOOK(:p_bookid, :p_dmltype, :p_bookname, :p_printerydate, :p_writername, :p_writersurname, :p_printery, :p_category, :p_typename, :p_hireprice, :p_langid)", con);
				cmd.CommandType = CommandType.Text;

				cmd.Parameters.AddWithValue("p_bookid", bookId);
				cmd.Parameters.AddWithValue("p_dmltype", dmlType.ToLower());
				cmd.Parameters.AddWithValue("p_bookname", bookName);
				cmd.Parameters.AddWithValue("p_printerydate", Convert.ToDateTime(printeryDate).ToString("yyyy-MM-dd"));
				cmd.Parameters.AddWithValue("p_writername", writerName);
				cmd.Parameters.AddWithValue("p_writersurname", writerSurname);
				cmd.Parameters.AddWithValue("p_printery", printery);
				cmd.Parameters.AddWithValue("p_category", category);
				cmd.Parameters.AddWithValue("p_typename", typeName);
				cmd.Parameters.AddWithValue("p_hireprice", hirePrice);
				cmd.Parameters.AddWithValue("p_langid", langId);
				etkilenen = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				etkilenen = -1;
				throw;
			}
			finally
			{
				con.Close();
				con.Dispose();
			}

			return etkilenen;
		}

		public int PRC_DML_HIRE(string dmlType, int bookId, string userName, string responseTime, int isBack, int price, int hireId)
		{
			int etkilenen = 0;

			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"call libapp.PRC_DML_HIRE(:p_dmltype, :p_bookid, :p_username, :p_responsetime, :p_isback, :p_price, :p_hireid)", con);
				cmd.CommandType = CommandType.Text;

				cmd.Parameters.AddWithValue("p_dmltype", dmlType.ToLower());
				cmd.Parameters.AddWithValue("p_bookid", bookId);
				cmd.Parameters.AddWithValue("p_username", userName);
				cmd.Parameters.AddWithValue("p_responsetime", Convert.ToDateTime(responseTime)).NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Date;
				cmd.Parameters.AddWithValue("p_isback", isBack).NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Smallint;
				cmd.Parameters.AddWithValue("p_price", price);
				cmd.Parameters.AddWithValue("p_hireid", hireId);
				etkilenen = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				etkilenen = -1;
			}
			finally
			{
				con.Close();
				con.Dispose();
			}

			return etkilenen;
		}

		public int PRC_DML_MEMBER(string dmlType, string name, string surname, string userName, string Password)
		{
			int etkilenen = 0;

			try
			{
				con.Open();
				NpgsqlCommand cmd = new NpgsqlCommand(@"call libapp.PRC_DML_MEMBER(:p_dmltype, :p_name, :p_surname, :p_username, :p_password)", con);
				cmd.CommandType = CommandType.Text;

				cmd.Parameters.AddWithValue("p_dmltype", dmlType.ToLower());
				cmd.Parameters.AddWithValue("p_name", name);
				cmd.Parameters.AddWithValue("p_surname", surname);
				cmd.Parameters.AddWithValue("p_username", userName);
				cmd.Parameters.AddWithValue("p_password", Password);
				etkilenen = cmd.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				etkilenen = -1;
				throw ex;
			}
			finally
			{
				con.Close();
				con.Dispose();
			}

			return etkilenen;
		}
	}
}
