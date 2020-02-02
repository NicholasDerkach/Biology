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
    /// Interaction logic for Lesson1_2_.xaml
    /// </summary>
    public partial class Lesson1_2_ : Window
    {
        public Lesson1_2_()
        {
            InitializeComponent();
        }

        private void ArrowLeftMouseDown(object sender, MouseButtonEventArgs e)
        {
            Excercise1 excercise11 = new Excercise1();
            Close();
            excercise11.ShowDialog();
        }

        private void ArrowDownMouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void ArrowRightMouseDown(object sender, MouseButtonEventArgs e)
        {

            Excercise2 excercise12 = new Excercise2();
            Close();
            excercise12.ShowDialog();
        }
    }
}
