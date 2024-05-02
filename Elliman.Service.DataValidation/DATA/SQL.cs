using System;
using System.Data;

namespace Elliman.Service.DataValidation.DATA
{
    public class SQL
    {
        public Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase DB;

        public static DataSet GetDataset(string SQL, string SQLServer = "DE-LI-SQL-01")
        {

            Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase DB = default(Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase);

            //Internal
            switch (SQLServer.ToUpper())
            {
                case "DE-LI-SQL-01":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_01_I);
                    break;
                case "DE-CLD-SQL5":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_05_I);
                    break;
                case "DE-CLD-SQL7":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_07_I);
                    break;
                case "DE-CLD-SQL9":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_13_I);
                    break;
                case "DE-CLD-SQL12":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_12_I);
                    break;
                case "DE-CLD-SQL13":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_13_I);
                    break;
                case "DE-CLD-SQL15":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_15_I);
                    break;
                case "DE-CLD-SQL16":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_16_I);
                    break;
                case "DE-DPN-SQL-1":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_DPN_I);
                    break;
                case "DE-DEV-SQL-1":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_Dev_1);
                    break;
            }

            System.Data.Common.DbCommand Command = null;

            Command = DB.GetSqlStringCommand(SQL);
            Command.CommandType = CommandType.Text;
            Command.CommandTimeout = 2000;
            DataSet DS = default(DataSet);
            using (System.Data.Common.DbConnection Connection = DB.CreateConnection())
            {
                DS = DB.ExecuteDataSet(Command);
                Connection.Close();
                Connection.Dispose();
            }

            Command.Dispose();

            return DS;

        }

        public static Int32 ExecuteNonQuery(string SQL, string SQLServer = "DE-LI-SQL-01")
        {
            Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase DB = null;
            Int32 ReturnInt;

            switch (SQLServer.ToUpper())
            {
                case "DE-LI-SQL-01":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_01_I);
                    break;
                case "DE-CLD-SQL5":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_05_I);
                    break;
                case "DE-CLD-SQL7":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_07_I);
                    break;
                case "DE-CLD-SQL9":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_13_I);
                    break;
                case "DE-CLD-SQL12":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_12_I);
                    break;
                case "DE-CLD-SQL13":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_13_I);
                    break;
                case "DE-CLD-SQL15":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_15_I);
                    break;
                case "DE-CLD-SQL16":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_16_I);
                    break;
                case "DE-DPN-SQL-1":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_DPN_I);
                    break;
                case "DE-DEV-SQL-1":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_Dev_1);
                    break;

            }


            using (System.Data.Common.DbCommand command = DB.GetSqlStringCommand(SQL))
            {
                command.CommandType = CommandType.Text;
                command.CommandTimeout = 2000;

                using (System.Data.Common.DbConnection Connection = DB.CreateConnection())
                {
                    ReturnInt = DB.ExecuteNonQuery(command);
                    Connection.Close();
                    Connection.Dispose();
                }
            }

            DB = null;
            return ReturnInt;
        }

        public static object ExecuteScalar(string SQL, string SQLServer = "DE-LI-SQL-01")
        {
            Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase DB = null;
            object ReturnInt;

            switch (SQLServer.ToUpper())
            {
                case "DE-LI-SQL-01":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_01_I);
                    break;
                case "DE-CLD-SQL5":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_05_I);
                    break;
                case "DE-CLD-SQL7":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_07_I);
                    break;
                case "DE-CLD-SQL9":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_13_I);
                    break;
                case "DE-CLD-SQL12":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_12_I);
                    break;
                case "DE-CLD-SQL13":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_13_I);
                    break;
                case "DE-CLD-SQL15":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_15_I);
                    break;
                case "DE-CLD-SQL16":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_16_I);
                    break;
                case "DE-DPN-SQL-1":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_DPN_I);
                    break;
                case "DE-DEV-SQL-1":
                    DB = new Microsoft.Practices.EnterpriseLibrary.Data.Sql.SqlDatabase(CONSTANTS.ConnectionString_Dev_1);
                    break;

            }


            using (System.Data.Common.DbCommand command = DB.GetSqlStringCommand(SQL))
            {
                command.CommandType = CommandType.Text;
                command.CommandTimeout = 2000;

                using (System.Data.Common.DbConnection Connection = DB.CreateConnection())
                {
                    ReturnInt = DB.ExecuteScalar(command);
                    Connection.Close();
                    Connection.Dispose();
                }
            }

            DB = null;
            return ReturnInt;
        }
    }
}

