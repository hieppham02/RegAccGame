using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace RegAccGame
{
    public static class SqliteSupport
    {
        private static string connectionString = "Data Source=RegAcc.db;Version=3;";
        private static SQLiteConnection connection = new SQLiteConnection(connectionString);
        public static DataTable DisplayData()
        {
            DataTable dataTable = new DataTable();
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            if (connection.State == ConnectionState.Open)
            {
                string selectQuery = "SELECT ID, USERNAME, PASSWORD, WRPASSWORD, BALANACE, IPADDRESS, STATUS FROM ACCOUNT";
                using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectQuery, connection))
                {
                    // Đổ bảng vừa dùng sql select vào datable 

                    dataAdapter.Fill(dataTable);
                    connection.Close();

                }
            }
            return dataTable;
        }
        public static void InsertData(UserInfo user)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            if (connection.State == ConnectionState.Open)
            {
                string insertQuery = "INSERT INTO ACCOUNT (USERNAME, PHONENUMBER, PASSWORD, WRPASSWORD, BANKNAME, BANKACCOUNT, FULLNAME, BALANCE, IPADDRESS, TOKEN, STATUS) VALUES (@Username, @PhoneNumber, @Password, @WrPassword, @BankName, @BankAccount, @FullName, @Balance, @Ipaddress, @Token, @Status)";
                using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    // Sử dụng tham số để tránh SQL Injection
                    command.Parameters.AddWithValue("@Username", user.username);
                    command.Parameters.AddWithValue("@PhoneNumber", user.phone_number);
                    command.Parameters.AddWithValue("@Password", user.password);
                    command.Parameters.AddWithValue("@WrPassword", user.wr_password);
                    command.Parameters.AddWithValue("@BankName", user.bank_name);
                    command.Parameters.AddWithValue("@BankAccount", user.bank_account);
                    command.Parameters.AddWithValue("@FullName", user.fullname);
                    command.Parameters.AddWithValue("@Balance", user.balance);
                    command.Parameters.AddWithValue("@Ipaddress", user.ip_address);
                    command.Parameters.AddWithValue("@Token", user.token);
                    command.Parameters.AddWithValue("@Status", user.status);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateData(UserInfo user)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            if (connection.State == ConnectionState.Open)
            {
                string updateQuery = "UPDATE ACCOUNT SET BALANCE = @Balance, TOKEN = @Token, STATUS = @Status WHERE USERNAME = @Username";
                using (SQLiteCommand command = new SQLiteCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", user.username);
                    command.Parameters.AddWithValue("@Balance", user.balance);
                    command.Parameters.AddWithValue("@Token", user.token);
                    command.Parameters.AddWithValue("@Status", user.status);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteData(UserInfo user)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }

            if (connection.State == ConnectionState.Open)
            {
                string deleteQuery = "DELETE FROM ACCOUNT WHERE USERNAME = @Username";
                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", user.username);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
