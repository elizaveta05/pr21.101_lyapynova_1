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

namespace pr21._101_lyapynova_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
            string number = TB1.Text;
            try
            {
                int a = TB1.Text.Length;
                int b = 12;
                if (a == b)
                {

                    int sum = 0;
                    int product = 1;
                    int[] mas = new int[12];

                    for (int i = 0; i < 3; i++)
                    {
                        int numeral = int.Parse(number[i].ToString());
                        product *= numeral;
                        
                    }

                    for (int i = 3; i < 12; i++)
                    {
                        int numeral = int.Parse(number[i].ToString());
                        sum += numeral;
                    }
                    
                    if (product == sum)
                    {
                        TB2.Text = "Произведение первых трех цифр равно сумме девяти последних цифр.";
                    }
                    else
                    {
                        TB2.Text = "Произведение первых трех цифр не равно сумме девяти последних цифр.";
                    }

                }
                else if (a > b)
                {
                    TB2.Text = "Ошибка! Введено больше 12 чисел";
                }
                else
                {
                    TB2.Text = "Ошибка! Введено меньше 12 чисел";

                }
            }
            catch (FormatException)
            {
                TB2.Text = "Ошибка! Введите 12-значное число цифрами!";
            }
            catch (Exception)
            {
                TB2.Text = "Ошибка! Введите 12-значное число цифрами!";

            }

        }
    }
}
