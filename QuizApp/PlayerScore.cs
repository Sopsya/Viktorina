using System.ComponentModel;

namespace QuizApp
{
    public class PlayerScore
    {
        public string QuizTitle { get; set; }
        private string playerName;
        private int correctAnswers;
        private int totalQuestions;

        public string PlayerName
        {
            get => playerName;
            set
            {
                if (playerName != value)
                {
                    playerName = value;
                    OnPropertyChanged(nameof(PlayerName));
                }
            }
        }
        public int CorrectAnswers
        {
            get => correctAnswers;
            set
            {
                if (correctAnswers != value)
                {
                    correctAnswers = value;
                    OnPropertyChanged(nameof(CorrectAnswers));
                }
            }
        }
        public int TotalQuestions
        {
            get => totalQuestions;
            set
            {
                if (totalQuestions != value)
                {
                    totalQuestions = value;
                    OnPropertyChanged(nameof(TotalQuestions));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        public override string ToString() => $"{PlayerName}: {CorrectAnswers}/{TotalQuestions} ({QuizTitle})";
        
    }
}