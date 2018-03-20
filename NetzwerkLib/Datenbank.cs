using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace NetzwerkLib
{
    public class Datenbank
    {
        void Con(string str)
        {
            Console.WriteLine("[DATABASE] " + str);
        }

        bool is_running = false;

        // Verbindung
        private MySqlConnection dbConn;

        //server=127.0.0.1;user id=server1;password=hsnrvsy;database=vsy_servers
        public void DB_Connect( string db_server, string db_database, string db_userid, string db_password)
        {
            string str_connect = "Server=" + db_server + "; port=1234; " + "UID=" + db_userid + "; password=" + db_password + "; Database=test;";

            Con(str_connect);

            dbConn = new MySqlConnection(@str_connect);
            try
            {
                dbConn.Open();
                is_running = true;
            }catch(Exception e)
            {
                Con(e.ToString());
            }
        }

        public void DB_CREATE_DATABASE(string db_database)
        {
            if (is_running)
            {
                MySqlCommand command = new MySqlCommand("CREATE DATABASE " + db_database + ";", dbConn);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch
                {
                    Con("DB_CREATE_DATABASE " + db_database + " schon vorhanden");
                }
            }
            else
            {
                Con("nicht verbunden");
            }
        }

        public void DB_CREATE_TABLE(string db_table, string db_columns)
        {
            if (is_running)
            {
                MySqlCommand command = new MySqlCommand("CREATE TABLE " + db_table + "("+ db_columns + ");", dbConn);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Con("DB_CREATE_TABLE " + e.ToString());
                }
            }
            else
            {
                Con("nicht verbunden");
            }
        }

        public void DB_INSERT_INTO(string db_table, string db_columns, string db_values)
        {
            if (is_running)
            {
                string q = "INSERT INTO " + db_table + " (" + db_columns + ") VALUES (" + db_values + ");";
                Con(q);
                MySqlCommand command = new MySqlCommand(q, dbConn);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Con("DB_INSERT_INTO " + e.ToString());
                }
            }
            else
            {
                Con("nicht verbunden");
            }
        }

        public void DB_DELETE_FROM(string db_table, string db_where)
        {
            if (is_running)
            {
                string q = "DELETE FROM " + db_table + " WHERE " + db_where + ";";
                //Con(q);
                MySqlCommand command = new MySqlCommand(q, dbConn);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    Con("DB_DELETE_FROM " + e.ToString());
                }
            }
            else
            {
                Con("nicht verbunden");
            }
        }

        public DataTable DB_Select(string db_table, string db_columns, string db_where)
        {
            MySqlDataAdapter adapter;
            DataTable table = new DataTable();
            List<string>[] select = new List<string>[1];
            if (is_running)
            {
                string q = "SELECT " + db_columns + " FROM " + db_table;
                if (db_where != "")
                {
                    q = q + " WHERE " + db_where;
                }
                q = q + ";";

                try
                {
                    //Con(q);
                    adapter = new MySqlDataAdapter(q, dbConn);
                    adapter.Fill(table);
                    return table;
                }
                catch (Exception e)
                {
                    Con("SELECT " + e.ToString());
                    return null;
                }
            }
            else
            {
                Con("nicht verbunden");
                return table;
            }
        }

        public Dictionary<int, string> DB_Select2( string db_table, string db_columns, string db_where )
        {
            Dictionary<int, string> select = new Dictionary<int, string>();

            if (is_running)
            {
                string q = "SELECT " + db_columns + " FROM " + db_table;
                if(db_where != "")
                {
                    q = q + " WHERE " + db_where;
                }
                q = q + ";";

                try
                {
                    Con(q);
                    MySqlCommand command = new MySqlCommand(q, dbConn);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        return null;
                    }

                    Con("Spalten: " + reader.FieldCount.ToString());
                    int spalten = reader.FieldCount;
                    Con("START");
                    while (reader.Read())
                    {
                        for (int x = 0; x < spalten; x++)
                        {
                            Con(reader[x].ToString());
                        }
                    }
                    Con("END");
                    reader.Close();
                    return select;
                }
                catch(Exception e)
                {
                    Con("SELECT "+e.ToString());
                    return null;
                }
            }
            else
            {
                Con("nicht verbunden");
                return select;
            }
        }
    }
}
