using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

namespace CRUD_ADO
{
    public class CRUD
    {
        public static Boolean chkValidity(string uname, string pass)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O7LF2JA;Initial Catalog=training;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from LoginTb", con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if (rdr.GetString("username").Equals(uname) && rdr.GetString("passwrd").Equals(pass))
                        return true;
                }

            }
            catch (Exception e) { return false; }
            return false;
        }

        public static bool AddUser(string name, string uname, string pass)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O7LF2JA;Initial Catalog=training;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand($"INSERT INTO LoginTb (person, username, passwrd) VALUES ('{name}', '{uname}', '{pass}')", con);
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();
                return rowsAffected > 0;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static string SendMessage(string uname, string rname, string message)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O7LF2JA;Initial Catalog=training;Integrated Security=True");
                con.Open();

                // Check if the receiver's username exists in the database
                SqlCommand checkReceiverCmd = new SqlCommand($"SELECT COUNT(*) FROM LoginTb WHERE username = '{rname}'", con);
                int receiverCount = (int)checkReceiverCmd.ExecuteScalar();

                if (receiverCount == 0)
                {
                    return "Receiver does not exist.";
                }

                // Insert the message into the messageTb table
                SqlCommand insertMessageCmd = new SqlCommand($"INSERT INTO messageTbl (sender_id, receiver_id, msgs) VALUES  ('{uname}', '{rname}', '{message}')", con);

                int rowsAffected = insertMessageCmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                    return "Message sent";
                return "Failed to send message";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static List<(string message,string userId)> GetUserMessages(string uname)
        {
            List<(string, string)> userMessages = new  List<(string, string)>();

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O7LF2JA;Initial Catalog=training;Integrated Security=True");
                con.Open();


                // Fetch received messages
                SqlCommand receivedCmd = new SqlCommand($"SELECT sender_id, msgs FROM messageTbl WHERE receiver_id = '{uname}'", con);
                SqlDataReader receivedRdr = receivedCmd.ExecuteReader();

                
                while (receivedRdr.Read())
                {
                    string senderId = receivedRdr.GetString("sender_id");
                    string message = receivedRdr.GetString("msgs");
                    userMessages.Add((senderId, message));

                }


                con.Close();
                return userMessages;

            }
            catch (Exception e)
            {
                // Handle exception
                Console.WriteLine(e.Message);
            }
            return null;
        }

        public static string GetMessage(string uname)
        {
            string user;
           

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O7LF2JA;Initial Catalog=training;Integrated Security=True");
                con.Open();


                // Fetch received messages
                SqlCommand receivedCmd = new SqlCommand($"SELECT sender_id, msgs FROM messageTbl WHERE receiver_id = '{uname}'", con);
                SqlDataReader receivedRdr = receivedCmd.ExecuteReader();


                
                user = receivedRdr.GetString("sender_id");


                con.Close();
                return user;

            }
            catch (Exception e)
            {
                // Handle exception
                Console.WriteLine(e.Message);
            }
            return "user not found";
           
        }


    }
}





