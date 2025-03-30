using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;

namespace QuizApp
{
    public class Question
    {
        public string Text { get; set; }
        public string CorrectAnswer { get; set; }
        public List<string> Options { get; set; }
    }
}