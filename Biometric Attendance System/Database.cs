using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
                sqlConnection.Open();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }

        public bool ExecuteCommand(string sql, Array parameters)
        {
            try
            {
                sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddRange(parameters);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
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
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
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

                sqlConnection.Open();
                sqlReader = sqlCommand.ExecuteReader();
                return sqlReader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }
            
            return null;
        }

        public MySqlDataReader GetData(string sql, Array parameters)
        {
            try
            {
                sqlCommand = new MySqlCommand(sql, sqlConnection);
                sqlCommand.Parameters.AddRange(parameters);
                sqlConnection.Open();
                sqlReader = sqlCommand.ExecuteReader();
                return sqlReader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                MessageBox.Show(ex.Message);
            }

            return null;
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
