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
        public ObservableCollection<Position> positionsNumber { get; set; }
        public MainWindow()
        {
            positionsNumber = new ObservableCollection<Position>();
            ObservableCollection<Digit> Pos_1_Number = new ObservableCollection<Digit>();
            ObservableCollection<Digit> Pos_2_Number = new ObservableCollection<Digit>();
            ObservableCollection<Digit> Pos_3_Number = new ObservableCollection<Digit>();
            ObservableCollection<Digit> Pos_4_Number = new ObservableCollection<Digit>();

            for (int i = 0; i < 15; i++)
            {
                int[] BinaryNum = ConvertBinary(i);

                if (BinaryNum[0] == 1) Pos_1_Number.Add(new Digit() { digitnumber = i });
                if (BinaryNum[1] == 1) Pos_2_Number.Add(new Digit() { digitnumber = i });
                if (BinaryNum[2] == 1) Pos_3_Number.Add(new Digit() { digitnumber = i });
                if (BinaryNum[3] == 1) Pos_4_Number.Add(new Digit() { digitnumber = i });
                //BinaryNum.Reverse();
                // string result = string.Join("", BinaryNum);
                // Console.WriteLine($"N:{i}-B:{result}");
            }

            positionsNumber.Add(new Position()
            {
                Title = "Box Number 1",
                IsChecked = false,
                BoxNumber = Pos_1_Number
            });

            positionsNumber.Add(new Position()
            {
                Title = "Box Number 2",
                IsChecked = false,
            BoxNumber = Pos_2_Number
            });

            positionsNumber.Add(new Position()
            {
                Title = "Box Number 3",
                IsChecked = false,
                BoxNumber = Pos_3_Number
            });

            positionsNumber.Add(new Position()
            {
                Title = "Box Number 4",
                IsChecked = false,
                BoxNumber = Pos_4_Number
            });
            //pages.Add(new Page() { Title = "Page2", lines = new ObservableCollection<line>() { new line() { linenumber = "Line2_1" }, new line() { linenumber = "Line2_2" }, new line() { linenumber = "Line2_3" } } });



            InitializeComponent();


            

            ListviewMother.ItemsSource = positionsNumber;




        }

        public static int[] ConvertBinary(int n)
        {
            int i;
            int[] a = new int[4];

            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            // Console.Write("Binary of the given number= ");
            //for (i = i - 1; i >= 0; i--)
            //{
            //    Console.Write(a[i]);
            //}
            return a;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            

        }
    }


    public class Position
    {
        public string Title { get; set; }
        public ObservableCollection<Digit> BoxNumber { get; set; } = new ObservableCollection<Digit>();

        public bool IsChecked { get; set; }

    }

    public class Digit
    {
        public int digitnumber { get; set; }
    }
}
