using HomeTask1.Entity;
using HomeTask1.View;
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

namespace HomeTask1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string Login = "login1";
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
                using (var context = new Magnit())
                {
                    var user = context.User.FirstOrDefault(u => LoginBox.Text == u.Login && PasswordBox.Password == u.Password);
                    
                    if (user == null)
                        throw new Exception("Пользователя не существует ");
                  
                    maneger window = new maneger();
                    window.Show();
                  
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("неправильный логин или пароль", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Close();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            
            Close();
        }

        private void CheckBoxPassword_Checked(object sender, RoutedEventArgs e)
        {
            if (CheckBoxPassword.IsChecked == true)
            {
                PasswordBox.Visibility = Visibility.Hidden;
                .Visibility = 
            }
        }

        private void CheckBoxPassword_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
