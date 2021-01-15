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

namespace WPFDecimalAdder
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

        private void ___calculateBtn__Click(object sender, RoutedEventArgs e)
        {
            int num1;
            int num2;
            int answer;

            // if the user tries to enter a non-integer number into the text box it will not allow it.
            if (int.TryParse(___firstNumberBox.Text, out num1) || string.IsNullOrEmpty(___firstNumberBox.Text))
            {
                // the out is num 1
            }
            else
            {
                
               
                ___firstNumberBox.Focus();
                //clear the text box.
                ___firstNumberBox.Clear();

                // show message.
                MessageBox.Show("The first number must be an actual number!", "Message", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            // if the user tries to enter a non-integer number into the text box it will not allow it.
            if (int.TryParse(___secondNumberBox.Text, out num2) || string.IsNullOrEmpty(___secondNumberBox.Text))
            {
                // the out is num2
            }
            else
            {
               
                ___secondNumberBox.Focus();
                ___secondNumberBox.Clear();

                MessageBox.Show("The second number must be a number!", "Message", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            // check to see if values are actually within range

            if(num1 < 0)
            {
                ___firstNumberBox.Focus();
                MessageBox.Show("The first number must be greater than Zero!", "Message", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                ___firstNumberBox.Clear();
            }
            else if (num2 < -10 || num2 > 10)
            {
                ___secondNumberBox.Focus();
                MessageBox.Show("The second number must be between -10 and 10!", "Message", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                // otherwise add the two numbers
                answer = num1 + num2;

                ___sumBox_.Text = answer.ToString();
            }

        }

        private void ___quitBtn__Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
