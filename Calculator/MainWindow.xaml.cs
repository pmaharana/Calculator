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

        }

        private void ClearAllClick(object sender, RoutedEventArgs e)
        {
            Result.Text = "";
        }
    }
}
