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

namespace WpfApp2
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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            decimal firstNumber = Convert.ToDecimal(FirstNumber.Text);
            decimal secondNumber = Convert.ToDecimal(SecondNumber.Text);
            ResultsNumber.Text = (firstNumber + secondNumber).ToString();
        }

        private void subtractButton_Click(object sender, RoutedEventArgs e)
        {
            decimal firstNumber = Convert.ToDecimal(FirstNumber.Text);
            decimal secondNumber = Convert.ToDecimal(SecondNumber.Text);
            ResultsNumber.Text = (firstNumber - secondNumber).ToString();
        }

        private void multiplyButton_Click(object sender, RoutedEventArgs e)
        {
            decimal firstNumber = Convert.ToDecimal(FirstNumber.Text);
            decimal secondNumber = Convert.ToDecimal(SecondNumber.Text);
            ResultsNumber.Text = (firstNumber * secondNumber).ToString();
        }

        private void divisionButton_Click(object sender, RoutedEventArgs e)
        {
            decimal firstNumber = Convert.ToDecimal(FirstNumber.Text);
            decimal secondNumber = Convert.ToDecimal(SecondNumber.Text);
            ResultsNumber.Text = (firstNumber / secondNumber).ToString();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber.Clear();
            SecondNumber.Clear();
            ResultsNumber.Clear();
        }
    }
}
