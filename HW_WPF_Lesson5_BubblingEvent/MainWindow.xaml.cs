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

namespace HW_WPF_Lesson5_BubblingEvent
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

        private void LargeButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The large button is clicked");
        }

        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The small button is clicked");
        }
    }
}
