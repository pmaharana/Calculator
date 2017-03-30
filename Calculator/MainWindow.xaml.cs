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

        private void AdditionButton(object sender, RoutedEventArgs e)
        {
            int result = Int32.Parse(Value1.Text) + Int32.Parse(Value2.Text);
            Calculation.Content = result.ToString();
        }
        private void SubtractionButton(object sender, RoutedEventArgs e)
        {
            int result = Int32.Parse(Value1.Text) - Int32.Parse(Value2.Text);
            Calculation.Content = result.ToString();
        }
        private void MultiplicationButton(object sender, RoutedEventArgs e)
        {
            int result = Int32.Parse(Value1.Text) * Int32.Parse(Value2.Text);
            Calculation.Content = result.ToString();
        }
        private void DivisionButton(object sender, RoutedEventArgs e)
        {
            int result = Int32.Parse(Value1.Text) / Int32.Parse(Value2.Text);
            Calculation.Content = result.ToString();
        }
        private void PercentageButton(object sender, RoutedEventArgs e)
        {
            int result = Int32.Parse(Value1.Text) % Int32.Parse(Value2.Text);
            Calculation.Content = result.ToString();
        }

        private void Value1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Value2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
