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

namespace Calc
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
    }

    public class AddButtonPage : ContentPage
    {
        public AddButtonPage()
        {
            Grid grid = new Grid();
            Title = "Label Grid Demo - C#";

            int columnsNum = 6;
            int rowsNum = 6;

            for (int x = 0; x < columnsNum; x++)
            {
                for (int y = 0; y < rowsNum; y++)
                {
                    // Insert button into grid  
                    Button b = new Button() { HorizontalOptions = LayoutOptions.Fill, VerticalOptions = LayoutOptions.Fill, Text = x + ":" + y };
                }
            }
            Content = grid;
        }
    }




}
