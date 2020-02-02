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

namespace Biology
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

        private void ButtonLesson1_Click(object sender, RoutedEventArgs e)
        {
            Lesson1 les1 = new Lesson1();
            les1.Show();
        }

        private void ButtonLesson2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonLesson3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonLesson4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuAbout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuHelp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
