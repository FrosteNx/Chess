using ChessLogic;
using System.Numerics;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ChessUI
{
    public static class Images
    {
        public static readonly Dictionary<PieceType, ImageSource> WhiteSources = new()
        {
            { PieceType.Pawn, LoadImage("Assets/PawnW.png") },
            { PieceType.Bishop, LoadImage("Assets/BishopW.png") },
            { PieceType.Knight, LoadImage("Assets/KnightW.png") },
            { PieceType.Rook, LoadImage("Assets/RookW.png") },
            { PieceType.Queen, LoadImage("Assets/QueenW.png") },
            { PieceType.King, LoadImage("Assets/KingW.png") }
        };

        public static readonly Dictionary<PieceType, ImageSource> BlackSources = new()
        {
            { PieceType.Pawn, LoadImage("Assets/PawnB.png") },
            { PieceType.Bishop, LoadImage("Assets/BishopB.png") },
            { PieceType.Knight, LoadImage("Assets/KnightB.png") },
            { PieceType.Rook, LoadImage("Assets/RookB.png") },
            { PieceType.Queen, LoadImage("Assets/QueenB.png") },
            { PieceType.King, LoadImage("Assets/KingB.png") }
        };

        private static ImageSource LoadImage(string FilePath)
        {
            return new BitmapImage(new Uri(FilePath, UriKind.Relative));
        }

        public static ImageSource GetImage(Player color, PieceType type)
        {
            return color switch
            {
                Player.White => WhiteSources[type],
                Player.Black => BlackSources[type],
                _ => null
            };
        }

        public static ImageSource GetImage(Piece piece)
        {
            if (piece == null)
                return null;

            return GetImage(piece.Color, piece.Type);
        }
    }
}