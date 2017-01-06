using System;
using System.Collections.Generic;
using System.Data;
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
        char sign;
        string display;
        bool wasSign;



        public MainWindow()
        {
            InitializeComponent();           
            display = "";
            wasSign = false;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = textBox.Text + "-";
            Button button = sender as Button;
            DisplayText(button.Content.ToString());
            wasSign = false;
        }

        private void button_Copy13_Click(object sender, RoutedEventArgs e)
        {            
            if(wasSign)
            {
                return;
            }
            sign = '+';
            DisplayText(sign.ToString());
            wasSign = true;
        }

        private void button_Copy14_Click(object sender, RoutedEventArgs e)
        {
            if (wasSign)
            {
                return;
            }
            sign = '-';
            DisplayText(sign.ToString());
            wasSign = true;
        }

        private void button_Copy15_Click(object sender, RoutedEventArgs e)
        {
            if (wasSign)
            {
                return;
            }
            sign = '*';
            DisplayText(sign.ToString());
            wasSign = true;
        }

        private void button_Copy16_Click(object sender, RoutedEventArgs e)
        {
            if (wasSign)
            {
                return;
            }
            sign = '/';
            DisplayText(sign.ToString());
            wasSign = true;
        }

        private void button_Copy11_Click(object sender, RoutedEventArgs e)
        {
            
            int textLenght = textBox.Text.Length;

            if (textLenght > 0)
            {
                if ((textBox.Text[0]).Equals('-'))

                    textBox.Text = textBox.Text.Substring(1, textLenght - 1);
                else
                {
                    textBox.Text = "-" + textBox.Text;
                }
            }

            else textBox.Text = "-" + textBox.Text;
            
        }

        private void button_Copy8_Click(object sender, RoutedEventArgs e)
        {
            int textLenght = textBox.Text.Length;

            if(textLenght > 0)
            {
                textBox.Text = textBox.Text.Substring(0, textLenght - 1);
            }
            button_Copy17.IsEnabled = true;
        }

        private void button_Copy12_Click(object sender, RoutedEventArgs e)
        {
            display = "";
            textBox.Text = display;
        }

        private void button_Copy17_Click(object sender, RoutedEventArgs e)
        {
            if (wasSign)
            {
                return;
            }
            DataTable dataTable = new DataTable();
            display = dataTable.Compute(display, "").ToString();
            textBox.Text = display;    
        }

        private void DisplayText(string inputSign)
        {
            const int displayStringLength = 21;
            if (display.Length < displayStringLength)
            {
                display += inputSign;
                textBox.Text = display;
            }
        }
                
        }
    }

