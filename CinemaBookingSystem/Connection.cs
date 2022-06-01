/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace CinemaBookingSystem
{
    class Connection
    {

        
        private static Connection _instance = null;
        SqlConnection con = null;
        SqlCommand cmd = null;

        private Connection()
        {
            string str = @"URI=file:C:\Users\User\Documents\CinemaDb.mdf";
            //string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\CinemaDb.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(str);
            con.Open();
            cmd = new SqlCommand(con);
            cmd.Connection = con;
        }

        static public Connection getDatabaseConnection()
        {
            if(_instance == null)
            {
                _instance = new Connection();
                _instance.executeCommand("PRAGMA foreign_keys = ON;");

            }
            return _instance;
        }

        public bool executeCommand(string command)
        {
            bool ok = true;
            cmd.CommandText = command;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception Ex)
            {
                ok=false;
            }
            return ok;
        }
        
    }
}
*/