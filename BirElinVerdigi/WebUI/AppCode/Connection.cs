using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace BirElinVerdigi.WebUl.AppCode
{
    public static class Connection
    {
        private static string connectionString = @"Data Source=.; Initial Catalog=PartTime; Integrated Security=True;";
        public static SqlDataReader ExecuteReader(String commandText,
          CommandType commandType = CommandType.Text, SqlParameter[] parameters = null)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = commandType;
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                conn.Open();
                // When using CommandBehavior.CloseConnection, the connection will be closed when the   
                // IDataReader is closed.  
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

                return reader;
            }
        }
    }
}
