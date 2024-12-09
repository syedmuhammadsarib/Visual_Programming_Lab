    using System.Collections.ObjectModel;
    using System.Numerics;
    using System.Windows;

    namespace CricketTeamManager
    {
        public class Player
        {
            public int PlayerID { get; set; }
            public string Name { get; set; }
        }

        public partial class MainWindow : Window
        {
            public ObservableCollection<Player> Players { get; set; }

            public MainWindow()
            {
                InitializeComponent();
                Players = new ObservableCollection<Player>();
                PlayersListBox.ItemsSource = Players;
            }

            private void AddPlayer_Click(object sender, RoutedEventArgs e)
            {
                if (!string.IsNullOrWhiteSpace(PlayerNameTextBox.Text))
                {
                    int newId = Players.Count + 1;
                    Players.Add(new Player { PlayerID = newId, Name = PlayerNameTextBox.Text });
                    PlayerNameTextBox.Clear();
                }
            }

            private void RemovePlayer_Click(object sender, RoutedEventArgs e)
            {
                if (PlayersListBox.SelectedItem is Player selectedPlayer)
                {
                    Players.Remove(selectedPlayer);
                }
            }

            private void PlayerNameTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
            {
                // Handle text changed event if needed
            }
        }
    }
