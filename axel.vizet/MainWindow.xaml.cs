using System;
using System.Windows;

namespace axel.vizet
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double premierNombre = 0;

        string operation = "";

        double resultat = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BTN_0_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "0";
        }

        private void BTN_1_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "1";
        }

        private void BTN_2_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "2";
        }

        private void BTN_3_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "3";
        }

        private void BTN_4_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "4";
        }

        private void BTN_5_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "5";
        }

        private void BTN_6_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "6";
        }

        private void BTN_7_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "7";
        }

        private void BTN_8_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "8";
        }

        private void BTN_9_Click(object sender, RoutedEventArgs e)
        {
            if (TB_Display.Text == "0 =" || TB_Display.Text == "0")
            {
                TB_Display.Text = "";
            }

            TB_Display.Text = TB_Display.Text + "9";
        }

        private void BTN_Fois_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "*";
            TB_Display.Text = "0";
        }

        private void BTN_Plus_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "+";
            TB_Display.Text = "0";
        }

        private void BTN_Moins_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "-";
            TB_Display.Text = "0";
        }

        private void BTN_DIV_Click(object sender, RoutedEventArgs e)
        {
            premierNombre = Convert.ToDouble(TB_Display.Text);
            operation = "/";
            TB_Display.Text = "0";
        }

        private void BTN_CLR_Click(object sender, RoutedEventArgs e)
        {
            TB_Display.Text = "0 =";
            premierNombre = 0;
            operation = "";
        }

        private void BTN_egale_Click(object sender, RoutedEventArgs e)
        {
            double deuxiemeNombre = Convert.ToDouble(TB_Display.Text);
         

            if (operation == "+")
            {
                resultat = premierNombre + deuxiemeNombre;
            }

            else if (operation == "-")
            {
                resultat = premierNombre - deuxiemeNombre;
            }

            else if (operation == "*")
            {
                resultat = premierNombre * deuxiemeNombre;
            }

            else if (operation == "/")
            {
                resultat = premierNombre / deuxiemeNombre;
            }

            TB_Display.Text = resultat.ToString();
            //test git frdytgedr
        }

        private void Btn_sin_Click(object sender, RoutedEventArgs e)
        {
            resultat = Math.Sin(Convert.ToDouble(TB_Display.Text));
        }
         
        private void Btn_cos_Click(object sender, RoutedEventArgs e)
        {
            resultat = Math.Cos(Convert.ToDouble(TB_Display.Text));
        }
           
        }
    }
