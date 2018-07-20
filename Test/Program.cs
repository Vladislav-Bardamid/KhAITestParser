using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KhAITestParser;

namespace Test
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        QuestionReader reader = new QuestionReader(@"C:\Projects\answers.json");
        IEnumerable<Question> questions = reader.GetInputData();
      }
      catch (Exception exception)
      {
        Console.WriteLine(exception.Message);
      }
      finally
      {
        Console.Write("Нажмите любую клавишу для завершения");
        Console.ReadKey(true);
      }
    }
  }
}
