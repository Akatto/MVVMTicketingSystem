using MySqlConnector;
using PracaInżynierska.Glowny;
using PracaInżynierska.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace PracaInżynierska.MVVM.ViewModel
{
    class UzytkownikVM
    {
        DBConnection connection;
        int _Rola;
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string TelefonSluzbowy { get; set; }
        public string TelefonPrywatny { get; set; }
        public string Identyfikator { get; set; }
        public BitmapImage awatar { get; set; }
        public List<User> items = new List<User>();
        public List<User> Items
        {
            get { return items; }
            set { items = value; }
        }
        public int Rola {
            get { return _Rola; }
            set
            {
                _Rola = value;
                switch (value)
                {
                    case 0:
                        RolaString = "Administrator";
                        break;
                    case 1:
                        RolaString = "Uzytkownik";
                        break;
                }
            }
        }
        public string RolaString { get; set; }

        public UzytkownikVM()
        {
        }

        public void reloaduserdata()
        {
            items.Clear();
            connection = new DBConnection();
            //connection.connection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * from user WHERE `Identyfikator`= '" + UserInfo.UID + "' LIMIT 1", connection.connection);
            //"+UserInfo.UID+"
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            Imie = dt.Rows[0]["Imie"].ToString();
            Nazwisko = dt.Rows[0]["Nazwisko"].ToString();
            Email = dt.Rows[0]["Email"].ToString();
            TelefonSluzbowy = dt.Rows[0]["TelefonSluzbowy"].ToString();
            TelefonPrywatny = dt.Rows[0]["TelefonPrywatny"].ToString();
            Identyfikator = UserInfo.UID;
            if(dt.Rows[0]["awatar"] != DBNull.Value)
            {
                awatar = obrazzbitow((byte[])dt.Rows[0]["awatar"]);
            }
            else
            {
                awatar = new BitmapImage(new Uri(@"pack://application:,,,/Obrazy/BrakObrazka.png"));
            }
            Rola = (int)dt.Rows[0]["Rola"];
            dt = new DataTable();
            cmd = new MySqlCommand("SELECT * FROM `user` WHERE `Zespol` = 0 AND `Identyfikator` != '"+Identyfikator+"'", connection.connection);
            dt.Load(cmd.ExecuteReader());
            foreach(DataRow row in dt.Rows)
            {
                BitmapImage zespolawatar;
                if (row["awatar"] != DBNull.Value)
                {
                    zespolawatar = obrazzbitow((byte[])row["awatar"]);
                }
                else
                {
                    zespolawatar = new BitmapImage(new Uri(@"pack://application:,,,/Obrazy/BrakObrazka.png"));
                }
                Items.Add(new User() { Imie = row["Imie"].ToString(), Nazwisko = row["Nazwisko"].ToString(), TelefonSluzbowy = row["TelefonSluzbowy"].ToString(), Email = row["Email"].ToString(), awatar=zespolawatar });
            }
            connection.connection.Close();
        }
        public BitmapImage obrazzbitow(byte[] tablica)
        {
            MemoryStream ms = new MemoryStream(tablica);
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.StreamSource = ms;
            image.EndInit();
            return image;
        }
        public partial class User
        {
            public string Imie { get; set; }
            public string Nazwisko { get; set; }
            public string TelefonSluzbowy { get; set; }
            public string Email { get; set; }
            public BitmapImage awatar { get; set; }
        }
    }
}
