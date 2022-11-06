using System;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.ComponentModel;
using DesktopApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ApplicationDbContext _context;
        private readonly CollectionViewSource _questionsViewSource;
        private const string NotSpecified = "Not specified";

        public MainWindow()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _questionsViewSource = (CollectionViewSource)FindResource("QuestionsViewSource");
        }
        
        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            _context.Questions.Load();
            _questionsViewSource.Source = _context.Questions.Local.ToObservableCollection();
        }

        private void SaveBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _context.SaveChanges();
            QuestionsDataGrid.Items.Refresh();
            AnswersDataGrid.Items.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _context.Dispose();
            base.OnClosing(e);
        }

        private void CreateQuestionBtn_OnClick(object sender, RoutedEventArgs e)
        {
            string content = QuestionContentTextBox.Text == string.Empty ? NotSpecified : QuestionContentTextBox.Text;
            string description = QuestionDescriptionTextBox.Text == string.Empty
                ? NotSpecified
                : QuestionDescriptionTextBox.Text;
            double successRate = Convert.ToDouble(QuestionSuccessRateTextBox.Text);
            bool isMarkedDebatable = Convert.ToBoolean(QuestionIsMarkedDebatableTextBox.Text);

            var question = new Question
            {
                Content = content,
                Description = description,
                SuccessRate = successRate,
                IsMarkedDebatable = isMarkedDebatable
            };
            
            _context.Questions.Local.Add(question);
            QuestionsDataGrid.Items.Refresh();
        }

        private void DeleteQuestionBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedQuestion = (Question)QuestionsDataGrid.SelectedItem;
            var question = _context.Questions.Local.FirstOrDefault(q => q.Id == selectedQuestion.Id);
            if (question != null)
            {
                _context.Questions.Local.Remove(question);
            }
            QuestionsDataGrid.Items.Refresh();
        }

        private void CreateAnswerBtn_OnClick(object sender, RoutedEventArgs e)
        {
            string key = AnswerKeyTextBox.Text == string.Empty ? NotSpecified : AnswerKeyTextBox.Text;
            string content = AnswerContentTextBox.Text == string.Empty ? NotSpecified : AnswerContentTextBox.Text;
            int questionId = Convert.ToInt32(AnswerQuestionIdTextBox.Text);

            var answer = new Answer
            {
                Key = key,
                Content = content,
                QuestionId = questionId
            };
            
            _context.Answers.Local.Add(answer);
            AnswersDataGrid.Items.Refresh();
        }

        private void DeleteAnswerBtn_OnClick(object sender, RoutedEventArgs e)
        {
            var selectedAnswer = (Answer)AnswersDataGrid.SelectedItem;
            var answer = _context.Answers.Local.FirstOrDefault(a => a.Id == selectedAnswer.Id);
            if (answer != null)
            {
                _context.Answers.Local.Remove(answer);
            }
            AnswersDataGrid.Items.Refresh();
        }
    }
}