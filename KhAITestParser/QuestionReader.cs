using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace KhAITestParser
{
  public class QuestionReader: IDisposable
  {
    private readonly Stream _stream;

    public QuestionReader(string path) =>
      _stream = new FileStream(path, FileMode.Open);

    public QuestionReader(Stream stream) =>
      _stream = stream;

    public IEnumerable<Question> GetInputData()
    {
      string json;
      using (StreamReader reader = new StreamReader(_stream))
      {
        json = reader.ReadToEnd();
      }
      JToken result = JObject.Parse(json)["questions"];
      IEnumerable<JToken> results = result.Children();
      IEnumerable <Question> questions = results.Select(s => s.ToObject<Question>());
      return questions;
    }

    public void Dispose()
    {
      _stream?.Dispose();
    }
  }
}
