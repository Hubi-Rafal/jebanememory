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
using System.Diagnostics;
using static System.Net.WebRequestMethods;
using System.Threading;
using System.Xml.Schema;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
using System.Security.Cryptography;

namespace memory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int odkryte = 0;
        public int zw = 0;

        Brush[] img = new Brush[3];

        int[] wartosc = new int[6] {0,1,2,3,4,5};

        public MainWindow()
        {

            InitializeComponent();

            img[0] = w1.Background;
            img[1] = w2.Background;
            img[2] = w3.Background;

            

            losowanie();

        }

        public void losowanie()
        {
            int[] tablica = new int[3] {0,0,0};
            
            Random rand = new Random();
            for(int i = 0; i<6;i++)
            {

                int wylosowana = rand.Next(0,3);

                tablica[wylosowana]++;

                if (tablica[wylosowana] <= 2)
                {
                    if (wartosc[i] == 0)
                    {
                        image1.Background = img[wylosowana];
                    }
                    if (wartosc[i] == 1)
                    {
                        image2.Background = img[wylosowana];
                    }
                    if (wartosc[i] == 2)
                    {
                        image3.Background = img[wylosowana];
                    }
                    if (wartosc[i] == 3)
                    {
                        image4.Background = img[wylosowana];
                    }
                    if (wartosc[i] == 4)
                    {
                        image5.Background = img[wylosowana];
                    }
                    if (wartosc[i] == 5)
                    {
                        image6.Background = img[wylosowana];
                    }
                }
                else
                {
                    while (tablica[wylosowana] == 2)
                    {
                        wylosowana = rand.Next(3);
                    }
                }
                
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            image1.Opacity = 100;
            odkryte++;
            
            /*if (odkryte == 2)
            {

                if(image3.Opacity == 100)
                {
                    zw++;
                    b1.IsEnabled = false;
                    b3.IsEnabled = false;
                    bord1.Background = Brushes.Green;

                    l1.Content = "Gratulacje, znalazłeś parę!";
                }
                else
                {
                    
                    image1.Opacity = 0;
                    image2.Opacity = 0;
                    image3.Opacity = 0;
                    image4.Opacity = 0;
                    image5.Opacity = 0;
                    image6.Opacity = 0;
                    l1.Content = "";
                    bord1.Background = Brushes.White;
                }
                odkryte = 0;
            }
            zwyciestwoCheck();
        */
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            image2.Opacity = 100;
            odkryte++;
            /*if (odkryte == 2)
            {
                if (image6.Opacity == 100)
                {
                    zw++;
                    b2.IsEnabled = false;
                    b6.IsEnabled = false;
                    bord1.Background = Brushes.Green;
                    
                    l1.Content = "Gratulacje, znalazłeś parę!";
                }
                else
                {
                    image1.Opacity = 0;
                    image2.Opacity = 0;
                    image3.Opacity = 0;
                    image4.Opacity = 0;
                    image5.Opacity = 0;
                    image6.Opacity = 0;
                    l1.Content = "";
                    bord1.Background = Brushes.White;
                }
                odkryte = 0;
            }
            zwyciestwoCheck();*/
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            image3.Opacity = 100;
            odkryte++;
            /*if (odkryte == 2)
            {
                if (image1.Opacity == 100)
                {
                    zw++;
                    b1.IsEnabled = false;
                    b3.IsEnabled = false; 
                    bord1.Background = Brushes.Green;

                    l1.Content = "Gratulacje, znalazłeś parę!";
                }
                else
                {
                    image1.Opacity = 0;
                    image2.Opacity = 0;
                    image3.Opacity = 0;
                    image4.Opacity = 0;
                    image5.Opacity = 0;
                    image6.Opacity = 0;
                    l1.Content = "";
                    bord1.Background = Brushes.White;
                }
                odkryte = 0;
            }
            zwyciestwoCheck();*/
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            image4.Opacity = 100;
            odkryte++;
            /*if (odkryte == 2)
            {
                if (image5.Opacity == 100)
                {
                    zw++;
                    b4.IsEnabled = false;
                    b5.IsEnabled = false;
                    bord1.Background = Brushes.Green;

                    l1.Content = "Gratulacje, znalazłeś parę!";
                }
                else
                {
                    image1.Opacity = 0;
                    image2.Opacity = 0;
                    image3.Opacity = 0;
                    image4.Opacity = 0;
                    image5.Opacity = 0;
                    image6.Opacity = 0;
                    l1.Content = "";
                    bord1.Background = Brushes.White;
                }
                odkryte = 0;
            }
            zwyciestwoCheck();*/
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            image5.Opacity = 100;
            odkryte++;
            /*if (odkryte == 2)
            {
                if (image4.Opacity == 100)
                {
                    zw++;
                    b4.IsEnabled = false;
                    b5.IsEnabled = false;
                    bord1.Background = Brushes.Green;

                    l1.Content = "Gratulacje, znalazłeś parę!";
                }
                else
                {
                    image1.Opacity = 0;
                    image2.Opacity = 0;
                    image3.Opacity = 0;
                    image4.Opacity = 0;
                    image5.Opacity = 0;
                    image6.Opacity = 0;
                    l1.Content = "";
                    bord1.Background = Brushes.White;
                }
                odkryte = 0;
            }
            zwyciestwoCheck();*/
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            image6.Opacity = 100;
            odkryte++;
            /*if (odkryte == 2)
            {
                if (image2.Opacity == 100)
                {
                    zw++;
                    b2.IsEnabled = false;
                    b6.IsEnabled = false;
                    bord1.Background = Brushes.Green;

                    l1.Content = "Gratulacje, znalazłeś parę!";
                }
                else
                {
                    image1.Opacity = 0;
                    image2.Opacity = 0;
                    image3.Opacity = 0;
                    image4.Opacity = 0;
                    image5.Opacity = 0;
                    image6.Opacity = 0;
                    l1.Content = "";
                    bord1.Background = Brushes.White;
                }
                odkryte = 0;

            }
            zwyciestwoCheck();*/

        }

        public void zwyciestwoCheck()
        {
            if (zw == 3)
            {
                bord1.Background = Brushes.Gold;
                l1.Foreground = Brushes.Black;
                l1.Content = "Gratulacje, wygrałeś!";
            }

        }




        /*private void button1_Click(object sender, RoutedEventArgs e)
{
var destinationurl = "https://www.google.com/";
var sInfo = new System.Diagnostics.ProcessStartInfo(destinationurl)
{
UseShellExecute = true,
};
System.Diagnostics.Process.Start(sInfo);
}*/
    }
}
