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
    /// Interaction logic for Excercise2.xaml
    /// </summary>
    public partial class Excercise2 : Window
    {
        public Excercise2()
        {
            InitializeComponent();
        }

        private void ArrowLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            Lesson1_2_ les12 = new Lesson1_2_();
            Close();
            les12.ShowDialog();
        }

        private void ArrowDownButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void ArrowRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Lesson1_3_ les13 = new Lesson1_3_();
            Close();
            les13.ShowDialog();
        }

        //Drag and drop
        private void ButtonCheck_Click(object sender, RoutedEventArgs e)
        {
            if (
            txtTarget1.Text == (string)Gene.Content &&
            txtTarget2.Text == (string)Spadok.Content
                )
            {
                False.Visibility = Visibility.Hidden;
                Correct.Visibility = Visibility.Visible;
                AnswerText.Content = "*Відповідь правильна";
            }
            else
            {
                Correct.Visibility = Visibility.Hidden;
                False.Visibility = Visibility.Visible;
                AnswerText.Content = "*Відповідь не правильна";
            }
        }

        //Drop
        private void txtTarget1_Drop(object sender, DragEventArgs e)
        {
            ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
        }
        private void txtTarget2_Drop(object sender, DragEventArgs e)
        {
            ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
        }

        //Drag
        private void Label1_Drag(object sender, MouseButtonEventArgs e)
        {
            Label lbl = (Label)sender;
            DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.All);
        }
        private void Label2_Drag(object sender, MouseButtonEventArgs e)
        {
            Label lbl = (Label)sender;
            DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.All);
        }

    }
}
