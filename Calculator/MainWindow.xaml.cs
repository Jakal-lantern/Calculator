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
        // Initialization
        decimal inputNumber1, inputNumber2, outputNumber;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            inputNumber1 = Convert.ToDecimal(number1.Text);
            inputNumber2 = Convert.ToDecimal(number2.Text);

            switch (operationSelection.SelectedIndex)
            {
                // Addition
                case (0):
                    outputNumber = inputNumber1 + inputNumber2;
                    break;

                // Subtraction
                case (1):
                    outputNumber = inputNumber1 - inputNumber2;
                    break;

                // Multiplication
                case (2):
                    outputNumber = inputNumber1 * inputNumber2;
                    break;

                // Division
                case (3):
                    outputNumber = inputNumber1 / inputNumber2;
                    break;
            }

            outputBlock.Text = Convert.ToString(outputNumber);
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            number1.Text = "0";
            number2.Text = "0";
            outputBlock.Text = "";
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
