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

namespace DemoUI_FOR_is_21_07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGoMenu_Click(object sender, RoutedEventArgs e)
        {
            MyForms.WindowMenu menu = new MyForms.WindowMenu(); 
            menu.Show();
            this.Close();
        }

        private void btn_info_Click(object sender, RoutedEventArgs e)
        {
            MyForms.WindowInfo info = new MyForms.WindowInfo(); 
            info.ShowDialog();
        }
    }
}
