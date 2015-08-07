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

namespace SO_31875062
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var text = LargeRun.Text;
            var firstNo = int.Parse(text.Substring(0, 1));
            var secondNo = int.Parse(text.Substring(1, 1));
            PowerRun.FontSize = Math.Pow(firstNo, secondNo);
        }
    }
}
