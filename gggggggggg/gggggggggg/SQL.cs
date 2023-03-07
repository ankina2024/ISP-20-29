using System.Data.SqlClient;

namespace gggggggggg
{
    public class SQL
    {
        
        string ConString = @"Data Source = tcp:192.168.9.200,49172;
                            Initial Catalog = Trade;
                            User = student;
                            Password = 123456;";

        public int InsDelUpd(string command)
        {
            SqlConnection con = new SqlConnection (ConString); 
            con.Open();
            SqlCommand com = new SqlCommand(command, con);
            return com.ExecuteNonQuery();

        }
        public SqlDataReader Select(string command)
        {
            SqlConnection con = new SqlConnection(ConString);
            con.Open();
            SqlCommand com = new SqlCommand(command, con);
            return com.ExecuteReader();
        }
    }
}
