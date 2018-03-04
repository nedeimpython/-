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

namespace Интегралы_тест
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int count;
        public int error;
        public int click;
        public MainWindow()
        {
            InitializeComponent();

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    {
                        count++;
                        comboBox.IsEnabled = false;

                        break;
                    }
                case 1:
                    {
                        error++;
                        comboBox.IsEnabled = false;
                        break;
                    }
                case 2:
                    {
                        error++;
                        comboBox.IsEnabled = false;
                        break;
                    }

            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            click++;
            MessageBox.Show("Не забудьте перенести ответ в таблицу, находящуюся слева. \r\n\n Не записанный в таблицу ответ не засчитывается!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Asterisk, MessageBoxResult.OK, MessageBoxOptions.None);
            if (click == 1)
            {
                test_q1.Visibility = Visibility.Hidden;
                test_q2.Visibility = Visibility.Visible;
            }
            if (click == 2)
            {
                test_q2.Visibility = Visibility.Hidden;
                test_q3.Visibility = Visibility.Visible;
            }
            if (click == 3)
            {
                test_q3.Visibility = Visibility.Hidden;
                test_q4.Visibility = Visibility.Visible;
            }
            if (click == 4)
            {
                test_q4.Visibility = Visibility.Hidden;
                test_q5.Visibility = Visibility.Visible;
            }
            if (click == 5)
            {
                test_q5.Visibility = Visibility.Hidden;
                test_qs6.Visibility = Visibility.Visible;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваш результат: " + Convert.ToString(count) + " балл(ов) из 15", "Ваш результат", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void comboBox_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox_Copy.SelectedIndex)
            {
                case 0:
                    {
                        count++;
                        comboBox_Copy.IsEnabled = false;

                        break;
                    }
                default:
                    {
                        error++;
                        comboBox_Copy.IsEnabled = false;
                        break;
                    }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            test_q1.Visibility = Visibility.Visible;
        }

        private void comboBox_Copy1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox_Copy1.SelectedIndex)
            {
                case 1:
                    {
                        count++;
                        comboBox_Copy1.IsEnabled = false;
                        break;
                    }
                default:
                    {
                        error++;
                        comboBox_Copy1.IsEnabled = false;
                        break;
                    }
            }
        }

        private void comboBox_Copy2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox_Copy2.SelectedIndex)
            {
                case 2:
                    {
                        count++;
                        comboBox_Copy2.IsEnabled = false;
                        break;
                    }
                default:
                    {
                        error++;
                        comboBox_Copy2.IsEnabled = false;
                        break;
                    }
            }
        }

        private void comboBox_Copy3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox_Copy3.SelectedIndex)
            {
                case 3:
                    {
                        count++;
                        comboBox_Copy3.IsEnabled = false;
                        break;
                    }
                default:
                    {
                        error++;
                        comboBox_Copy3.IsEnabled = false;
                        break;
                    }
            }
        }

        private void comboBox_Copy4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox_Copy4.SelectedIndex)
            {
                case 1:
                    {
                        count++;
                        comboBox_Copy4.IsEnabled = false;
                        break;
                    }
                default:
                    {
                        error++;
                        comboBox_Copy4.IsEnabled = false;
                        break;
                    }
            }
        }
    }
}
