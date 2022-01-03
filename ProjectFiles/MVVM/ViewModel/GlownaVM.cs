using MySqlConnector;
using PracaInżynierska.Glowny;
using PracaInżynierska.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracaInżynierska.MVVM.ViewModel
{

    class GlownaVM
    {
        UserInfo user = new UserInfo();
        DBConnection connection;
        public string _CurrentNewsNaglowek;
        public string CurrentNewsNaglowek
        {
            get { return _CurrentNewsNaglowek; }
            set
            {
                if (_CurrentNewsNaglowek != value)
                {
                    {
                        _CurrentNewsNaglowek = value;
                    }
                }
            }
        }
        public string[] _Events = new string[4];
        public DateTime?[] _EventTimes = new DateTime?[4];
        public string[] Events
        {
            get
            {
                return _Events;
            }
            set
            {
                _Events = value;
            }
        }
        public DateTime?[] EventTimes
        {
            get
            {
                return _EventTimes;
            }
            set
            {
                _EventTimes = value;
            }
        }

        public string _CurrentNews;
        public string CurrentNews
        {
            get { return _CurrentNews; }
            set
            {
                if (_CurrentNews != value)
                {
                    {
                        _CurrentNews = value;
                    }
                }
            }
        }
        public GlownaVM()
        {
        }

        public void ReloadNews()
        {
            connection = new DBConnection();
            //connection.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from news LIMIT 1", connection.connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            CurrentNewsNaglowek = dt.Rows[0]["Title"].ToString();
            CurrentNews = dt.Rows[0]["Description"].ToString();
            dt = new DataTable();
            cmd = new MySqlCommand("SELECT * FROM `event` WHERE `event_user_id` = '"+UserInfo.UID+"' ORDER BY `Date` ASC", connection.connection);
            dt.Load(cmd.ExecuteReader());
            int licznik = 0;
            foreach(DataRow row in dt.Rows)
            {
                DateTime datka = (DateTime)row["Date"];
                if (datka.CompareTo(DateTime.Now) > 0 && licznik<4)
                {
                    Events[licznik] = row["Name"].ToString();
                    EventTimes[licznik] = (DateTime)row["Date"];
                    licznik++;
                }
            }
            if(licznik<4)
            {
                for(int i=licznik;licznik<4;licznik++)
                {
                    Events[i] = "Brak Kolejnych Wydarzeń";
                }
            }
        }
    }
}
