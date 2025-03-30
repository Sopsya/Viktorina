using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text.Json;

namespace QuizApp
{
 
    public class Option
    {
        public string Name { get; set; }
        public Option(string name) => Name = name;
    }

}