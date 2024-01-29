using System;
using System.Numerics;
using System.Windows;

namespace NumberConversionApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            string inputText = inputTextBox.Text;

            if (int.TryParse(inputText, out int inputNumber))
            {
                INumber decimalNumber = new DecimalNumber(inputNumber);
                INumber binaryNumber = new BinaryNumber(inputNumber);

                decimalResultTextBox.Text = decimalNumber.ConvertToDecimal();
                binaryResultTextBox.Text = binaryNumber.ConvertToBinary();
            }
            else
            {
                MessageBox.Show("Введите корректное число.");
            }
        }
    }
}
