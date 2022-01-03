using MySqlConnector;
using PracaInżynierska.Glowny;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PracaInżynierska.MVVM.Model
{
    class UserInfo
    {
        public string Login { get; set; }
        public SecureString Password { get; set; }
        public static string UID { get; set; }
        public byte[] Pwd { get; set; }
        public void Test(byte[] passwd)
        {
        }
        public bool TryLogin()
        {
            DBConnection connection = new DBConnection();
            string hash = "";
            if (Pwd == null)
            {
                return false;
            }
            else
            {
                foreach (byte pwd in Pwd)
                {
                    hash += pwd.ToString("x2");
                }
                MySqlCommand cmd = new MySqlCommand("SELECT Identyfikator FROM `user` WHERE `Email` = '" + Login + "' AND Haslo = '" + hash + "' LIMIT 1", connection.connection);
                DataTable dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                Trace.WriteLine("Proba zalogowania!");
                if (dt.Rows.Count > 0)
                {
                    UID = dt.Rows[0]["Identyfikator"].ToString();
                    Trace.WriteLine(UID);
                    Window appka = Application.Current.MainWindow;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
