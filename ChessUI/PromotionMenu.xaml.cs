using ChessLogic;
using System.Windows.Controls;
using System.Windows.Input;

namespace ChessUI
{
    /// <summary>
    /// Logika interakcji dla klasy PromotionMenu.xaml
    /// </summary>
    public partial class PromotionMenu : UserControl
    {
        public event Action<PieceType> PieceSelected;

        public PromotionMenu()
        {
            InitializeComponent();
        }

        private void QueenImg_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void RookImg_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void BishopImg_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void KnightImg_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
