using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
namespace Arac_Otomasyon.dbconn
{
    class baglanti
    {
        private SqlDataAdapter dataAdapter;
        public SqlConnection baglan;
        
        public baglanti()
    {

        dataAdapter = new SqlDataAdapter();
        baglan = new SqlConnection(@"Data Source=DESKTOP-DBRJKIO\SQLEXPRESS;Initial Catalog=Arac_Otomasyonu;Integrated Security=True");
    }


    private SqlConnection openConnection()
    {

        if (baglan.State == ConnectionState.Closed || baglan.State == ConnectionState.Broken)
        {

            baglan.Open();

        }

        return baglan;
    }

    public DataTable executeSelectQuery(String _Query, SqlParameter[] sqlParameter)
    {
        SqlCommand myCommand = new SqlCommand();
        DataTable dataTable = new DataTable();

        dataTable = null;

        DataSet ds = new DataSet();

        try
        {

            myCommand.Connection = openConnection();
            myCommand.CommandText = _Query;
            myCommand.Parameters.AddRange(sqlParameter);
            myCommand.ExecuteNonQuery();

            dataAdapter.SelectCommand = myCommand;
            dataAdapter.Fill(ds);
            dataTable = ds.Tables[0];




        }

        catch (SqlException e)
        {
            Console.WriteLine("Hata : Connection.ExecuteSelectQuery - Query " + _Query + " \n Exception : " + e.StackTrace.ToString());

            return null;
        }
        finally { }

        return dataTable;
    }


    public bool executeInsertQuery(String _Query, SqlParameter[] sqlParameter)
    {
        SqlCommand myCommand = new SqlCommand();


        try
        {

            myCommand.Connection = openConnection();
            myCommand.CommandText = _Query;
            myCommand.Parameters.AddRange(sqlParameter);
            dataAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();







        }

        catch (SqlException e)
        {
            Console.WriteLine("Hata : Connection.InsertSelectQuery - Query " + _Query + " \n Exception : " + e.StackTrace.ToString());

            return false;
        }
        finally { }

        return true;
    }




    public bool executeUpdateQuery(String _Query, SqlParameter[] sqlParameter)
    {
        SqlCommand myCommand = new SqlCommand();


        try
        {

            myCommand.Connection = openConnection();
            myCommand.CommandText = _Query;
            myCommand.Parameters.AddRange(sqlParameter);
            dataAdapter.UpdateCommand = myCommand;
            myCommand.ExecuteNonQuery();







        }

        catch (SqlException e)
        {
            Console.WriteLine("Hata : Connection.ExecuteUpdateQuery - Query " + _Query + " \n Exception : " + e.StackTrace.ToString());

            return false;
        }
        finally { }

        return true;
    }



    public bool executeDeleteQuery(String _Query, SqlParameter[] sqlParameters)
    {
        SqlCommand myCommand = new SqlCommand();


        try
        {

            myCommand.Connection = openConnection();
            myCommand.CommandText = _Query;
            dataAdapter.DeleteCommand = myCommand;
            myCommand.ExecuteNonQuery();







        }

        catch (SqlException e)
        {
            Console.WriteLine("Hata : Connection.ExecuteDeleteQuery - Query " + _Query + " \n Exception : " + e.StackTrace.ToString());

            return false;
        }
        finally { }

        return true;
    }

}
}
