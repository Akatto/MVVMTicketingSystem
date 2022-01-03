using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PracaInżynierska.Components
{
    /// <summary>
    /// Logika interakcji dla klasy BindPassword.xaml
    /// </summary>
    public partial class BindPassword : UserControl
    {

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(string), typeof(BindPassword), new PropertyMetadata(string.Empty));
        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }



        public BindPassword()
        {
            InitializeComponent();
        }

        private void PWDBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = PWDBox.Password;
        }
    }
}
