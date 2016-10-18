using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace etaisyys
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int x1 = Convert.ToInt16(textBox1.Text);
            int y1 = Convert.ToInt16(textBox2.Text);
            int x2 = Convert.ToInt16(textBox3.Text);
            int y2 = Convert.ToInt16(textBox4.Text);
            textBox5.Text = laske(x1,y1,x2,y2).ToString();
        }
        double laske(int x1,int y1,int x2,int y2)
        {
            double ero = Math.Pow(x2 - x1,2)+ Math.Pow(y2-y1,2);
            double valimatka = Math.Sqrt(ero);
            return valimatka;
        }
    }
}
