using ChessLogic;
using System.Windows;
using System.Windows.Controls;

namespace ChessUI
{
    /// <summary>
    /// Logika interakcji dla klasy GameOverMenu.xaml
    /// </summary>
    public partial class GameOverMenu : UserControl
    {
        public event Action<Option> OptionSelected;

        public GameOverMenu()
        {
            InitializeComponent();
        }

        private static string GetWinnerText(Player winner)
        {
            return winner switch
            {
                Player.White => "White wins",
                Player.Black => "Black wins",
                _ => "It's a draw"
            };
        }

        private static string PlayerString(Player player)
        {
            return player switch
            {
                Player.White => "White",
                Player.Black => "Black",
                _ => ""
            };
        }

        private static string GetReasonText(EndReason reason, Player currentPlayer) 
        {
            return "";
        }

        private void RestartClick(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Restart);
        }

        private void ExitClick(object sender, RoutedEventArgs e)
        {
            OptionSelected?.Invoke(Option.Exit);
        }
    }
}
