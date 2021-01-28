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

namespace Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int output = 0;
        int input = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void octClick(object sender, RoutedEventArgs e)
        {
            input = Convert.ToInt32(text1.Text);
            text2.Text = Convert.ToString(input, 8);
            input = 0;
        }

        private void hexClick(object sender, RoutedEventArgs e)
        {
            input = Convert.ToInt32(text1.Text);
            text2.Text = input.ToString("X");
            input = 0;
        }

        private void binClick(object sender, RoutedEventArgs e)
        {
            input = Convert.ToInt32(text1.Text);
            text2.Text = Convert.ToString(input, 2);
            input = 0;
        }
        private void text1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
