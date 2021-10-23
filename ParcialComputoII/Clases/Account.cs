using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ParcialComputoII.Clases
{
    class Account
    {

        Connection Connection = new Connection();
        private Crud crud = new Crud();

        public int _codUser { get; set; }
        public string _firstname { get; set; }
        public string _lastname { get; set; }
        public string _email { get; set; }
        public string _registerdate { get; set; }
        public string _username {get; set;}
        public string _password {get; set;}

  

        public MySqlDataReader getAll()
        {
            string query = "SELECT * from accoun WHERE codUser<>1";
            return crud.select(query);
        }
        //public MySqlDataReader getAllUserLogs()
        //{
        //    string query = "SELECT codLog, username, timeLoggedin FROM userlog ";

        //    return crud.select(query);
        //}

        
        public Boolean registerAccount()
        {
            string query = "INSERT INTO accoun(firstname, lastname, email, registerDate, username, password)" +
            "VALUE ('" + _firstname + "','" + _lastname + "','" + _email + "','" + _registerdate + "','" + _username + "','" + _password + "')";
            crud.executeQuery(query);
            return true;
        }

        public Boolean Login()
        {
            string query = "SELECT * FROM accoun WHERE username= '"+_username+ "'AND password= '"+_password+"'";
            if (crud.select(query).HasRows)
            {
                return true;

            }
            return false;
        }

        public void insertLog()
        {

            string insertlog = "INSERT INTO userlog (username, timeLoggedin) VALUES('" + _username + "'" + DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss") + "')"; 
            crud.executeQuery(insertlog);
        }

        public MySqlDataReader getLog()
        {
            string query = "SELECT * from userlog";
            return crud.select(query);
        }

        public MySqlDataReader getLogWithoutAdmin()
        {
            string query = "SELECT * from userlog WHERE username <> 'admin' ";

            return crud.select(query);
        }
    }
}
