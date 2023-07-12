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

namespace MagicNumber
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<BoxNumbber> items = new List<BoxNumbber>();
            items.Add(new BoxNumbber() { number = 42});
            items.Add(new BoxNumbber() { number = 55 });
            items.Add(new BoxNumbber() { number = 56 });
            _listNumber.ItemsSource = items;
        }
    }

    public class BoxNumbber
    {

        public int number { get; set; }

       
    }
}
