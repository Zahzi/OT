﻿using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace TrackerClient
{
    public class Db
    {
        private readonly MySqlConnection _connection;
        private MySqlCommand _mCmd;

        public Db()
        {
            string conString = string.Format("SERVER=157.230.200.22;Port=3306;DATABASE=otdb;UID=otuser;PASSWORD=2016againlol;Convert Zero Datetime=True;");
            //var conString = string.Format("SERVER=127.0.0.1;Port=3306;DATABASE=olympus;UID=otracker;PASSWORD=9Ohz7b^5LG0*O'c;Convert Zero Datetime=True;");
            //string conString = string.Format("SERVER=10.1.10.3;Port=3306;DATABASE=olympus;UID=otracker;PASSWORD=9Ohz7b^5LG0*O'c;Convert Zero Datetime=True;");
            _connection = new MySqlConnection(conString);
        }
        private bool OpenConnection()
        {
            Reconnect:
            try
            {
                _connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 1042:
                        Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again.");
                        break;
                    default:
                        Console.WriteLine("Error " + ex.ErrorCode + ": " + ex.Message);
                        break;
                }
                return false;
            }
            catch (InvalidOperationException)
            {
                _connection.Close();
                goto Reconnect;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        private void CloseConnection()
        {
            try
            {
                _connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        internal int ExecuteNonQuery(string sql, params object[] args)
        {
            int result;
            try
            {
                if (!OpenConnection()) return -1;
                MySqlCommand mCmd = new MySqlCommand(sql, _connection);
                for (int i = 0; i < args.Length; i++)
                    mCmd.Parameters.AddWithValue("?p" + i, args[i]);
                result = mCmd.ExecuteNonQuery();
                mCmd = null;
                CloseConnection();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(string.Format("Error {1}: {0}", ex.Message, ex.Number));
                result = -1;
            }
            finally
            {
                CloseConnection();
            }
            return result;
        }
        internal object ExecuteScalar(string sql, params object[] args)
        {
            if (!OpenConnection()) return null;
            _mCmd = new MySqlCommand(sql, _connection);
            for (int i = 0; i < args.Length; i++)
                _mCmd.Parameters.AddWithValue("?p" + i, args[i]);
            object mObject = _mCmd.ExecuteScalar();
            _mCmd = null;
            CloseConnection();
            return mObject;
        }
        internal List<string>[] ExecuteReader(string sql, params object[] args)
        {
            List<string>[] list = null;
            try
            {
                if (!OpenConnection()) return null;
                MySqlCommand mCmd = new MySqlCommand(sql, _connection);
                for (int i = 0; i < args.Length; i++)
                    mCmd.Parameters.AddWithValue("?" + i, args[i]);
                MySqlDataReader mReader = mCmd.ExecuteReader();
                mCmd = null;
                list=  new List<string>[mReader.FieldCount];

                for (int i = 0; i < (list.Length); i++)
                {
                    list[i] = new List<string>();
                }
                while (mReader.Read())
                {
                    for (int i = 0; i < (list.Length); i++)
                        list[i].Add(mReader[i].ToString());
                }
                mReader.Close();

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(string.Format("Error {1}: {0}", ex.Message, ex.ErrorCode));
                list = null;
            }
            finally
            {
                CloseConnection();
            }
            return list;
        }
        internal DataTable ExecuteReaderDT(string sql, params object[] args)
        {
            DataTable dataTable = new DataTable();
            try
            {
                if (!OpenConnection()) return null;
                MySqlCommand mCmd = new MySqlCommand(sql, _connection);
                for (int i = 0; i < args.Length; i++)
                    mCmd.Parameters.AddWithValue("?" + i, args[i]);
                dataTable.Load(mCmd.ExecuteReader());
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(string.Format("Error {1}: {0}", ex.Message, ex.ErrorCode));
                dataTable = null;
            }
            finally
            {
                CloseConnection();
            }
            return dataTable;
        }
    }
}
