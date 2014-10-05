using System;
using System.Windows;

namespace WpfApplication1
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

        public int oper1;
        public int oper2;
        public int equal = 0;
        public string mathOperator = "";

        public void AddString(string s)
        {
            Display.Text = Display.Text + s;
        }
        
        public void nine_click(Object sender, RoutedEventArgs e)
        {
            AddString("9");
        }

        public void eight_click(Object sender, RoutedEventArgs e)
        {
            AddString("8");
        }

        public void seven_click(Object sender, RoutedEventArgs e)
        {
            AddString("7");
        }

        public void six_click(Object sender, RoutedEventArgs e)
        {
            AddString("6");
        }

        public void five_click(Object sender, RoutedEventArgs s)
        {
            AddString("5");
        }

        public void four_click(Object sender, RoutedEventArgs s)
        {
            AddString("4");
        }

        public void three_click(Object sender, RoutedEventArgs s)
        {
            AddString("3");
        }

        public void two_click(Object sender, RoutedEventArgs s)
        {
            AddString("2");
        }

        public void one_click(Object sender, RoutedEventArgs s)
        {
            AddString("1");
        }

        public void zero_click(Object sender, RoutedEventArgs s)
        {
            AddString("0");
        }

        public void add_click(Object sender, RoutedEventArgs e)
        {
            oper1 = Convert.ToInt32(Display.Text);
            Display.Text = "";
            mathOperator = "+";
        }

        public void subtract_click(Object sender, RoutedEventArgs e)
        {
            oper1 = Convert.ToInt32(Display.Text);
            Display.Text = "";
            mathOperator = "-";
        }

        public void divide_click(Object sender, RoutedEventArgs e)
        {
            oper1 = Convert.ToInt32(Display.Text);
            Display.Text = "";
            mathOperator = "/";
        }

        public void multiply_click(Object sender, RoutedEventArgs e)
        {
            oper1 = Convert.ToInt32(Display.Text);
            Display.Text = "";
            mathOperator = "*";
        }

        public void c_click(Object sender, RoutedEventArgs e)
        {
            Display.Text = "";
        }

        public void result_click(Object sender, RoutedEventArgs e)
        {
            oper2 = Convert.ToInt32(Display.Text);

            switch (mathOperator)
            {
                case "+":
                    Display.Text = (oper1 + oper2).ToString();
                    break;

                case "-":
                    Display.Text = (oper1 - oper2).ToString();
                    break;

                case "/":
                    Display.Text = (oper1/oper2).ToString();
                    break;

                case "*":
                    Display.Text = (oper1*oper2).ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
