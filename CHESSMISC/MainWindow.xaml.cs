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
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace CHESSMISC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<ChessPiece> Pieces { get; set; }
        public MainWindow()
        {
            Pieces = new ObservableCollection<ChessPiece>();
            InitializeComponent();
            DataContext = Pieces;
            NewGame();
            //Pieces.Add(new ChessPiece() { Row = 4, Column = 4, Type = ChessPieceTypes.Tower, IsBlack = true });
            //Pieces.Where((x => x.Row == 2)); TESTIGN
        }

        

        private void OnClick(object sender, EventArgs e)
        {
            Pieces.Add(new ChessPiece() { Row = 3, Column = 4, Type = ChessPieceTypes.King, IsBlack = false });
        }

        private void NewGame()
        {
            Pieces.Clear();
            Pieces.Add(new ChessPiece() { Row = 0, Column = 0, Type = ChessPieceTypes.Tower, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 1, Type = ChessPieceTypes.Knight, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 2, Type = ChessPieceTypes.Bishop, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 3, Type = ChessPieceTypes.Queen, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 4, Type = ChessPieceTypes.King, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 5, Type = ChessPieceTypes.Bishop, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 6, Type = ChessPieceTypes.Knight, IsBlack = true });
            Pieces.Add(new ChessPiece() { Row = 0, Column = 7, Type = ChessPieceTypes.Tower, IsBlack = true });

            Enumerable.Range(0, 8).Select(x => new ChessPiece()
            {
                Row = 1,
                Column = x,
                IsBlack = true,
                Type = ChessPieceTypes.Pawn
            }).ToList().ForEach(Pieces.Add);


            Pieces.Add(new ChessPiece() { Row = 7, Column = 0, Type = ChessPieceTypes.Tower, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 1, Type = ChessPieceTypes.Knight, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 2, Type = ChessPieceTypes.Bishop, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 3, Type = ChessPieceTypes.Queen, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 4, Type = ChessPieceTypes.King, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 5, Type = ChessPieceTypes.Bishop, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 6, Type = ChessPieceTypes.Knight, IsBlack = false });
            Pieces.Add(new ChessPiece() { Row = 7, Column = 7, Type = ChessPieceTypes.Tower, IsBlack = false });

            Enumerable.Range(0, 8).Select(x => new ChessPiece()
            {
                Row = 6,
                Column = x,
                IsBlack = false,
                Type = ChessPieceTypes.Pawn
            }).ToList().ForEach(Pieces.Add);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           Pieces.Add(new ChessPiece() { Row = 3, Column = 4, Type = ChessPieceTypes.King, IsBlack = false });

        }

        //private void CreateBoard()
       // {
         //   for (var row = 0; row < 8; row++)
        //    {
             //   var isBlack = row % 2 == 1;
              //  for (int col = 0; col < 8; col++)
              //  {
                //    var button = new Button();
                //    button.Click += OnClick;
                //    var square = new Rectangle { Fill = isBlack ? Brushes.Black : Brushes.White };
                //    button.Content = square;
                //    SquareGrid.Children.Add(button);
               //     isBlack = !isBlack;

                //}
            //}

        //}



        public int FindPiece(int row, int col)
        {
            for (int i = 0; i < Pieces.Count; i++)
            {
                if (row == Pieces.ElementAt(i).Row && col == Pieces.ElementAt(i).Column)
                {
                    return i;
                }
            }
            return -1;
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Pieces.ElementAt(FindPiece(0, 0)).Row = 5;
        }
    }
}
