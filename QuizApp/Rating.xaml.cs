using System.Collections.ObjectModel;
using System.Windows;

namespace QuizApp
{
    public partial class Rating : Window
    {
        public Rating(ObservableCollection<PlayerScore> scores)
        {
            InitializeComponent();
            LeaderboardListBox.ItemsSource = scores;
        }
    }
}