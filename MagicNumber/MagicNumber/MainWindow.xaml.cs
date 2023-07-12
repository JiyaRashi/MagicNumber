using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ObservableCollection<Page> pages = new ObservableCollection<Page>();
        public MainWindow()
        {
            pages.Add(new Page() { Title = "Page1", lines = new ObservableCollection<line>() { new line() { linenumber = "Line1_1" }, new line() { linenumber = "Line1_2" }, new line() { linenumber = "Line1_3" } } });
            pages.Add(new Page() { Title = "Page2", lines = new ObservableCollection<line>() { new line() { linenumber = "Line2_1" }, new line() { linenumber = "Line2_2" }, new line() { linenumber = "Line2_3" } } });
            
            InitializeComponent();
            ListviewMother.ItemsSource = pages;
        }
    }


    public class Page
    {
        public string Title { get; set; }
        public string TemplateStyle { get; set; }
        public ObservableCollection<line> lines { get; set; } = new ObservableCollection<line>();

    }

    public class line
    {
        public string linenumber { get; set; }
    }
}
