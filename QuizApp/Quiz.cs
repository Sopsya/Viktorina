using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;

namespace QuizApp
{ 
    public class Quiz
    {
        public string Title { get; set; }
        public List<Question> Questions { get; set; } = new();

        public void SaveToFile(string filePath)
        {
            var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
        public static Quiz LoadFromFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Quiz>(json);
        }
    }
}