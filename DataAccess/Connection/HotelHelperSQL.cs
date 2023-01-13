using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class HotelHelperSQL
    {
        #region SQLConnection
        private static SqlConnection MyConnection()
        {
            
            return new SqlConnection(DataConnections.Get_MsSQLConnectionString);
        }
        #endregion

        //private static SqlConnection MyConnection(string MyProvider)
        //{
        //    switch (MyProvider)
        //    {
        //        case "SQL": return new SqlConnection(DataConnections.Get_MsSQLConnectionString);                
        //        case "Oracle": return new SqlConnection(DataConnections.Get_OracleConnectionString);                 
        //        default:
        //            return new SqlConnection(DataConnections.Get_MySQLConnectionString); 
        //    }
        //}

        #region SQLCommand
        public static SqlCommand MySqlCommand(string SqlCommand, string SqlCommandType, SqlParameter[] SqlParams) 
        {

            SqlCommand command = new SqlCommand(SqlCommand, MyConnection());

            if (SqlCommandType == "sp")
            {
                command.CommandType = CommandType.StoredProcedure;
            }
            if (SqlParams != null)
            { 
                command.Parameters.AddRange(SqlParams);
            }
            
            return command;
        }
        #endregion

        #region Summary of NonQuery

        /// <summary>
        /// For the UPDATE, INSERT, and DELETE statements
        /// </summary>
        /// <param name="SqlCommand"></param>
        /// <param name="SqlCommandType"></param>
        /// <param name="CommandParams"></param>
        /// <returns> the returned value is the number of rows that the command affects. </returns>
        
         #endregion

        #region ExecuteNonQuery

        public static int MyExecuteNonQuery(string SqlCommand, string SqlCommandType, SqlParameter[] CommandParams)
        {
            SqlCommand command = MySqlCommand(SqlCommand, SqlCommandType, CommandParams);

            command.Connection.Open();
            int ThatRow = command.ExecuteNonQuery();
            command.Connection.Close();

            return ThatRow;
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SqlCommand"></param>
        /// <param name="SqlCommandType"></param>
        /// <param name="CommandParams"></param>
        /// <returns>Field</returns>

        # region ExecuteSkalar

        public static object MyExecuteSkalar(string SqlCommand, string SqlCommandType, SqlParameter[] CommandParams)
        {
            SqlCommand command = MySqlCommand(SqlCommand, SqlCommandType, CommandParams);

            command.Connection.Open();
            object ThatRow = command.ExecuteScalar();
            command.Connection.Close();

            return ThatRow;
        }
        #endregion

        # region ExecuteReader

        public static SqlDataReader MyExecuteReader(string SqlCommand, string SqlCommandType, SqlParameter[] CommandParams)
        {
            SqlCommand command = MySqlCommand(SqlCommand, SqlCommandType, CommandParams);

            command.Connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            //command.Connection.Close();

            return reader;
        }
        #endregion



    }
}
