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
using System.Linq;
using System.Windows;
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

    }
}
