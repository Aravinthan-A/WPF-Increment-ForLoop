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

namespace Increment
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int increment = Convert.ToInt32(txtvalue.Text);
            int length = Convert.ToInt32(txtend.Text);
            int start = Convert.ToInt32(txthigh.Text);

            for (int i= start; i < length; i=i+ increment)
            {
                MessageBox.Show(i.ToString());
            }
        }
    }
}
