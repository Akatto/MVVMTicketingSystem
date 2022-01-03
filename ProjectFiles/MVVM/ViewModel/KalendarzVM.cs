using MySqlConnector;
using PracaInżynierska.Glowny;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using PracaInżynierska.MVVM.ViewModel;
using PracaInżynierska.MVVM.Model;
//using Windows.UI.Xaml.Controls;

namespace PracaInżynierska.MVVM.ViewModel
{
    class KalendarzVM : ObiektZauwazalny
    {
        DBConnection connection;
        public Przekazanie AddEventCommand { get; set; }
        public ObservableCollection<Event> wydarzenia = new ObservableCollection<Event>();
        public ObservableCollection<Event> Wydarzenia
        {
            get
            {
                return wydarzenia;
            }
            set
            {
                wydarzenia = value;
                OnPropertyChanged();
            }
        }
        String _date;
        public String date
        {
            get
            {
                if (_date != null)
                {
                    Trace.WriteLine("Pobrano: " + _date.ToString());
                    return _date;
                }
                else
                {
                    return DateTime.Now.ToString();
                }
            }
            set
            {
                if (value != null)
                {
                    _date = value;
                    Trace.WriteLine("Przypisano: " + _date.ToString());
                    OnPropertyChanged();
                }
            }
        }
        public string wydarzenietextbox { get; set; }
        public string datatextbox { get; set; }
        public string godzinatextbox { get; set; }
        public bool zespol { get; set; }

        //public HashSet<DateTime> Daty { get; } = new HashSet<DateTime>();
        public KalendarzVM()
        {
            date = DateTime.Now.ToString();
            AddEventCommand = new Przekazanie(o =>
            {
                AddEvent();
            });
            GetEvents();
        }
        public void GetEvents()
        {
            Wydarzenia.Clear();
            connection = new DBConnection();
            //connection.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM `event` WHERE `event_user_id` = '"+UserInfo.UID+"'", connection.connection);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            foreach(DataRow row in dt.Rows)
            {
                DateTime datka = (DateTime)row["Date"];
                if (datka.CompareTo(DateTime.Now.AddDays(-1)) > 0)
                {
                    Wydarzenia.Add(new Event { Wydarzenie = row["Name"].ToString(), date = datka.Date.ToString("dd/MM/yy"), hour = datka.TimeOfDay.ToString("hh':'mm':'ss") });
                }
            }
            connection.connection.Close();
        }

        public void AddEvent()
        {
            DateTime datka = Convert.ToDateTime(date);
            if (ValidateTime(godzinatextbox))
            {
                string[] time = godzinatextbox.Split(':');
                int[] czas = new int[2];
                czas[0] = Convert.ToInt32(time[0]);
                czas[1] = Convert.ToInt32(time[1]);
                datka = new DateTime(datka.Year, datka.Month, datka.Day, czas[0], czas[1],0);
                string ValiableDate = datka.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss");
                connection = new DBConnection();
                if (zespol == true)
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT `Identyfikator` FROM `user` WHERE `Zespol` = 0",connection.connection);
                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());
                    foreach(DataRow row in dt.Rows)
                    {
                        cmd = new MySqlCommand("INSERT INTO `event`(`Name`, `Date`, `event_user_id`) VALUES ('" + wydarzenietextbox + "','" + ValiableDate + "','"+row["Identyfikator"]+"')", connection.connection);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO `event`(`Name`, `Date`, `event_user_id`) VALUES ('" + wydarzenietextbox + "','" + ValiableDate + "','" + UserInfo.UID + "')", connection.connection);
                    cmd.ExecuteNonQuery();
                }
                connection.connection.Close();
                GetEvents();
            }
        }
        public bool ValidateTime(string time)
        {
            if(time==null || time == "") { return false; }
            Match match = Regex.Match(time, "^(?:0?[0-9]|1[0-9]|2[0-3]):[0-5][0-9]$");
            if (match.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public partial class Event
        {
            public string Wydarzenie { get; set; }
            public string date { get; set; }
            public string hour { get; set; }
        }
        
    }
}
