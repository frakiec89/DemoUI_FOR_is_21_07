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
    /// Логика взаимодействия для WindowThree.xaml
    /// </summary>
    public partial class WindowThree : Window
    {
        public WindowThree()
        {
            InitializeComponent();
        }

        private void btn_back_menu_Click(object sender, RoutedEventArgs e)
        {
            MyForms.WindowMenu menu = new MyForms.WindowMenu();
            menu.Show();    
            Close();
        }

        private void btn_info_Click(object sender, RoutedEventArgs e)
        {
            MyForms.WindowThreeInfo threeInfo = new MyForms.WindowThreeInfo();
            threeInfo.ShowDialog();
        }

        private void btn_GOOO_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Я не  умею");
        }
    }
}
