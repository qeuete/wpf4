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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для AutorizatsiaWindow.xaml
    /// </summary>
    public partial class AutorizatsiaWindow : Window
    {
        public AutorizatsiaWindow()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredCode = CodeTextBox.Text.Trim();
            string expectedCode = "ням"; 

            if (enteredCode == expectedCode)
            {

                User userWindow = new User();
                userWindow.Show();
                Close(); 
            }
            else
            {
                MessageBox.Show("Неверное кодовое слово. Попробуйте снова.");
            }
        }
    }
}
