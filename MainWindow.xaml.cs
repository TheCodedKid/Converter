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
using System.Collections;

namespace Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Globals
        ArrayList parseInput = new ArrayList();
        public MainWindow()
        {
            InitializeComponent();
        }

        //type reference: 10 = dec, 16 = hex, 8 = oct, 2 = bin

        public void parseString(int type)
        //Currently parsing to 8 digits for safety reasons, am considering max bit storage size for int type for the future
        {
            long temp = 0;
            //String tempString = text1.Text;
            int n = 5; //length of processed per slot in arraylist
            for(int i = 0; i < text1.Text.Length; i += n)
            {
                if (i + n <= text1.Text.Length)
                {
                    temp = Convert.ToInt64(text1.Text.Substring(i, n), type);
                }
                else if (i + n > text1.Text.Length)
                {
                    temp = Convert.ToInt64(text1.Text.Substring(i, (text1.Text.Length % n)), type);
                }
                parseInput.Add(temp);
                temp = 0; //for checking, doesn't need to be here I think
            }
        }

        private void returnString()
        {
            foreach(long output in parseInput)
            {
                text2.Text += output;
            }
            text2.Text += " ";
            parseInput.Clear();
        }

        private void octClick(object sender, RoutedEventArgs e)
        {
            returnString();
        }

        private void hexClick(object sender, RoutedEventArgs e)
        {
            returnString();
        }

        private void binClick(object sender, RoutedEventArgs e)
        {
            returnString();
        }

        private void decClick(object sender, RoutedEventArgs e)
        {
            returnString();
        }


        private void octSelectClick(object sender, RoutedEventArgs e)
        {
            parseString(8);
        }

        private void hexSelectClick(object sender, RoutedEventArgs e)
        {
            parseString(16);
        }

        private void binSelectClick(object sender, RoutedEventArgs e)
        {
            parseString(2);
        }

        private void decSelectClick(object sender, RoutedEventArgs e)
        {
            parseString(10);
        }
    }
}
