using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Biometric_Attendance_System
{
    class Database
    {
        string databaseName;
        string username;
        string password;
        string connectionString;
        string dataSource;

        //MySQL Database Attributes
        public MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        MySqlDataReader sqlReader;

        public Database(string databaseName, string dataSource, string username, string password)
        {

            this.databaseName = databaseName;
            this.dataSource = dataSource;
            this.username = username;
            this.password = password;
            
            connectionString =
                "Database = " + databaseName + ";" +
                "Server = " + dataSource + ";" +
                "uid = " + username + ";" +
                "pwd = " + password;
            sqlConnection = new MySqlConnection(connectionString);

        }

        public bool TestConnection()
        {
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                throw ex;
            }
            return true;
        }

        public bool ExecuteCommand(string sql, Array parameters)
        {
            try
            {
                sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddRange(parameters);
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Commit();
            }
        }

        public bool ExecuteCommand(string sql)
        {
            try
            {
                sqlCommand = new MySqlCommand(sql, sqlConnection);
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Commit();
            }
        }


        public MySqlDataReader GetData(string sql)
        {
            try
            {
                sqlCommand = new MySqlCommand(sql, sqlConnection);
                if(sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                sqlReader = sqlCommand.ExecuteReader();
                return sqlReader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MySqlDataReader GetData(string sql, Array parameters)
        {
            try
            {
                sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddRange(parameters);
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open();
                sqlReader = sqlCommand.ExecuteReader();
                return sqlReader;
            }
            catch (Exception ex)
            {
                Program.Database.Commit();
                return GetData(sql, parameters);
                //throw ex;
            }
        }

        public void Commit()
        {
            try
            {
                sqlReader.Close();
                sqlReader.Dispose();
                
            }
            catch(Exception)
            {

            }
            finally
            {
                sqlConnection.Close();
            }
        }


    }
}
