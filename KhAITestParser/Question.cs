using System;
using System.Collections.Generic;
using System.Text;

namespace KhAITestParser
{
  public class Question
  {
    public string Text { get; set; }
    public List<string> Variants { get; set; }
    public List<int> Answers { get; set; }
  }
}
