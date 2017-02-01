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

namespace Sid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            listBox.Visibility = Visibility.Hidden;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Visibility=Visibility.Visible;
            listBox.Items.Clear();
            for(int i=1;i<=100;i++)
            {
                if(i%3==0&&i%5==0)
                {
                    listBox.Items.Add("Register Patient");
                    continue;
                }
                else if(i%3==0)
                {
                    listBox.Items.Add("Register");
                    continue;
                }
                else if(i%5==0)
                {
                    listBox.Items.Add("Patient");
                    continue;
                }
                else
                {
                    listBox.Items.Add(i);
                }
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

            listBox.Visibility = Visibility.Visible;
            listBox.Items.Clear();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0 && i % 7 == 0)
                {
                    listBox.Items.Add("Diagnose Patient");
                    continue;
                }
                else if (i % 2 == 0)
                {
                    listBox.Items.Add("Diagnose");
                    continue;
                }
                else if (i % 7 == 0)
                {
                    listBox.Items.Add("Patient");
                    continue;
                }
                else
                {
                    listBox.Items.Add(i);
                }
            }
        }
    }
}
