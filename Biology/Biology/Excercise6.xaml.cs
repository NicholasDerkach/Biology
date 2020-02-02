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
    /// Interaction logic for Excercise6.xaml
    /// </summary>
    public partial class Excercise6 : Window
    {
        public Excercise6()
        {
            InitializeComponent();
        }

        private void ArrowLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Lesson1_6_ les16 = new Lesson1_6_();
            Close();
            les16.ShowDialog();
        }

        private void ArrowDownButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void ArrowRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Close();
        }

        private void ButtonCheckAnswers_Click(object sender, RoutedEventArgs e)
        {
            bool isAllFieldsFullfied = (
             txtTarget1.Text == (string)Monogibrig.Content &&
            txtTarget2.Text == (string)Digibrid.Content
                );

            if (isAllFieldsFullfied)
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

        //
        private void txtTarget1_Drop(object sender, DragEventArgs e)
        {
            ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void txtTarget2_Drop(object sender, DragEventArgs e)
        {
            ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void txtTarget3_Drop(object sender, DragEventArgs e)
        {
            ((TextBlock)sender).Text = (string)e.Data.GetData(DataFormats.Text);
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Label lbl = (Label)sender;
            DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.All);
        }

        private void Label_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Label lbl = (Label)sender;
            DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.All);
        }

        private void Label_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            Label lbl = (Label)sender;
            DragDrop.DoDragDrop(lbl, lbl.Content, DragDropEffects.All);
        }
    }
}
