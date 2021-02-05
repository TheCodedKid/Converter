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
    /// 

    /* 
     * Look into Big Integer conversion
     * Look into "out of range expection" due to recall of parseString()
     * Consider new way to parse through input (better if else conditions)
     */
    
    //type reference: 10 = dec, 16 = hex, 8 = oct, 2 = bin
    public partial class MainWindow : Window
    {
        //char[] delim = { ' ', ',', ':', '\t' }; for later use
        ArrayList parseInput = new ArrayList();
        public MainWindow()
        {
            InitializeComponent();
        }

        public void parseString(int type)
        {
            text1.Text += ','; //cheeky, I know
            string temp = "";
            for(int i = 0; i < text1.Text.Length; i++)
            {
                if(text1.Text[i] != ',')
                {
                    temp += text1.Text[i];
                }
                else if(text1.Text[i] == ',')
                {
                    parseInput.Add(Convert.ToInt64(temp, type));
                    temp = "";
                }
            }
        }

        private void returnString(int type)
        {
            foreach(long output in parseInput)
            {
                text2.Text += Convert.ToString(output, type);
                text2.Text += ", ";
            }
        }

        private void octClick(object sender, RoutedEventArgs e)
        {
            returnString(8);
        }

        private void hexClick(object sender, RoutedEventArgs e)
        {
            returnString(16);
        }

        private void binClick(object sender, RoutedEventArgs e)
        {
            returnString(2);
        }

        private void decClick(object sender, RoutedEventArgs e)
        {
            returnString(10);
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

        private void clearInputClick(object sender, RoutedEventArgs e)
        {
            parseInput.Clear();
            text1.Text = "";
        }

        private void clearOutputClick(object sender, RoutedEventArgs e)
        {
            text2.Text = "";
        }
    }
}
