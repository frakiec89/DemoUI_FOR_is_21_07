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

namespace DemoUI_FOR_is_21_07.MyForms
{
    /// <summary>
    /// Логика взаимодействия для WindowMenu.xaml
    /// </summary>
    public partial class WindowMenu : Window
    {
        public WindowMenu()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();   
            window.Show();
            this.Close();
        }

        private void btnGoWindowOne_Click(object sender, RoutedEventArgs e)
        {
            MyForms.WindowOne one = new MyForms.WindowOne();
            one.Show();
            Close();
        }

        private void btnGoWindowTwo_Click(object sender, RoutedEventArgs e)
        {
            MyForms.WindowTwo two = new MyForms.WindowTwo();
            two.Show();
            Close() ;
        }

        private void btnGoWindowThree_Click(object sender, RoutedEventArgs e)
        {
            MyForms.WindowThree three = new MyForms.WindowThree();
            three.Show();
            Close();
        }
    }
}
