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

namespace Biology
{
    /// <summary>
    /// Interaction logic for Lesson1_6_.xaml
    /// </summary>
    public partial class Lesson1_6_ : Window
    {
        public Lesson1_6_()
        {
            InitializeComponent();
        }

        private void ArrowLeftMouseDown(object sender, MouseButtonEventArgs e)
        {
            Excercise5 excercise15 = new Excercise5();
            Close();
            excercise15.ShowDialog();
        }

        private void ArrowDownMouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void ArrowRightMouseDown(object sender, MouseButtonEventArgs e)
        {
            Excercise6 excercise16 = new Excercise6();
            Close();
            excercise16.ShowDialog();
        }
    }
}
