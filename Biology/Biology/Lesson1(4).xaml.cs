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
    /// Interaction logic for Lesson1_4_.xaml
    /// </summary>
    public partial class Lesson1_4_ : Window
    {
        public Lesson1_4_()
        {
            InitializeComponent();
        }

        private void ArrowLeftMouseDown(object sender, MouseButtonEventArgs e)
        {

            Excercise3 excercise13 = new Excercise3();
            Close();
            excercise13.ShowDialog();
        }

        private void ArrowDownMouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void ArrowRightMouseDown(object sender, MouseButtonEventArgs e)
        {
            Excercise4 excercise14 = new Excercise4();
            Close();
            excercise14.ShowDialog();
        }
    }
}
