using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace QuizApp
{
    public partial class SozdatViktorinu : Window
    {
        public Quiz CreatedQuiz { get; private set; }
        public ObservableCollection<Question> Questions { get; set; } = new ObservableCollection<Question>();

        // Событие для передачи созданной викторины
        public Action<Quiz> QuizCreated;
        public SozdatViktorinu()
        {
            InitializeComponent();
            QuestionsList.ItemsSource = Questions;
        }

        private void AddQuestion_Click(object sender, RoutedEventArgs e)
        {
            var addQuestionWindow = new Vopros();
            addQuestionWindow.ShowDialog();

            if (addQuestionWindow.NewQuestion != null) Questions.Add(addQuestionWindow.NewQuestion);
            
        }
        private void SaveQuiz_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(QuizName.Text))
            {
                MessageBox.Show("Введите название викторины!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            if (Questions.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы один вопрос в викторину!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Создаём объект викторины
            CreatedQuiz = new Quiz
            {
                Title = QuizName.Text,
                Questions = new List<Question>(Questions)
            };

            // Передаём викторину через событие
            QuizCreated?.Invoke(CreatedQuiz);

            this.Close();
        }
    }
}