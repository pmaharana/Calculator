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

namespace Calculator
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

       

      

        private void Result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ZeroClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "0";
        }

        private void OneClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "1";
        }

        private void TwoClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "2";
        }

        private void ThreeClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "3";
        }
        private void FourClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "4";
        }
        private void FiveClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "5";
        }
        private void SixClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "6";
        }
        private void SevenClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "7";
        }
        private void EightClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "8";
        }
        private void NineClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "9";
        }

        private void DecimalClick(object sender, RoutedEventArgs e)
        {
            Result.Text += ".";
        }
        private void PlusClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "+";
        }

        private void MinusClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "-";
        }

        private void MultiplyClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "X";
        }

        private void DivideClick(object sender, RoutedEventArgs e)
        {
            Result.Text += "/";
        }

        private void EqualClick(object sender, RoutedEventArgs e)
        {
            if (Result.Text.Contains('+'))
            {
                var splittedAdd = Result.Text.Split('+');
                var addition = double.Parse(splittedAdd[0]) + double.Parse(splittedAdd[1]);
                Result.Text = addition.ToString();
            }

            if (Result.Text.Contains('-'))
            {
                var splittedSubtract = Result.Text.Split('-');
                var subtraction = double.Parse(splittedSubtract[0]) - double.Parse(splittedSubtract[1]);
                Result.Text = subtraction.ToString();
            }
            if (Result.Text.Contains('X'))
            {
                var splittedMultiply = Result.Text.Split('X');
                var multiplication = double.Parse(splittedMultiply[0]) * double.Parse(splittedMultiply[1]);
                Result.Text = multiplication.ToString();
            }
            if (Result.Text.Contains('/'))
            {
                var splittedDivide = Result.Text.Split('/');
                var division = double.Parse(splittedDivide[0]) / double.Parse(splittedDivide[1]);
                Result.Text = division.ToString();
            }
        }
        private void ClearAllClick(object sender, RoutedEventArgs e)
        {
            Result.Text = "";
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.D1)
            {
                Result.Text += "1";
            }
        }










    }
}
