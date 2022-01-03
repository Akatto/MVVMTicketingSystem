using PracaInżynierska.Glowny;
using PracaInżynierska.MVVM.Model;
using PracaInżynierska.State;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PracaInżynierska.MVVM.ViewModel
{
    class LoginPanelVM : ObiektZauwazalny
    {
        public LoginCommand loginCommand { get; }
        public string _Blad { get; set; }
        public string Blad
        {
            get
            {
                return _Blad;
            }
            set
            {
                _Blad = value;
                OnPropertyChanged();
            }
        }
        public string _BladColor { get; set; } = "White";
        public string BladColor
        {
            get
            {
                return _BladColor;
            }
            set
            {
                _BladColor = value;
                OnPropertyChanged();
            }
        }
        public Przekazanie TryLoginCommand { get; set; }
        public UserInfo user = new UserInfo();
        public string Login
        {
            get
            {
                return user.Login;
            }
            set
            {
                user.Login = value;
            }
        }
        public SecureString Pwd
        {
            get
            {
                return user.Password;
            }
            set
            {
                user.Password = value;
                user.Pwd = SecureStringToHashedString(user.Password);
            }
        }
        byte[] SecureStringToHashedString(SecureString ss)
        {
            IntPtr ssPtr = IntPtr.Zero;
            byte[] pwd;
            try
            {
                ssPtr = Marshal.SecureStringToGlobalAllocUnicode(ss);
                using(SHA256 hasher = SHA256.Create())
                {
                    pwd = hasher.ComputeHash(Encoding.ASCII.GetBytes(Marshal.PtrToStringUni(ssPtr)));
                }
                return pwd;
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(ssPtr);
            }
        }
        public LoginPanelVM(MainWindowVM vm)
        {
            TryLoginCommand = new Przekazanie(o =>
            {
                BladColor = "White";
                Blad = "Trwa logowanie!";
                if(user.TryLogin())
                {
                    BladColor = "White";
                    Blad = "Udało się zalogować!";
                    vm.ChangeViewToHome();
                    //zalogowano
                }
                else
                {
                    BladColor = "Red";
                    Blad = "Podano niepoprawne dane!";
                }
            });
        }
    }
}
