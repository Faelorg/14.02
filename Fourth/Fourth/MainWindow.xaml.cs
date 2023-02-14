using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing.Imaging;
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
using System.Reflection;
using System.IO;

namespace Fourth
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

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            var exp = (Expander)sender;

            int ind = 13;
            for (int i = 0; i < spnMain.Children.Count; i++)
            {
                if (spnMain.Children[i] != exp)
                {
                    var x = (Expander)spnMain.Children[i];

                    x.IsExpanded = false;

                }
                else
                {
                    ind = i;
                }

            }
            try
            {
                BitmapImage bm = new BitmapImage();
                using (FileStream fs = new FileStream("зодиак/" + ind +".png", FileMode.Open))
                {
                bm.BeginInit();

                    bm.UriSource = new Uri(fs.Name);


                imgZodiak.Source = bm;
                }
                bm.EndInit();
            }
            catch
            {

            }
        }
    }
}
