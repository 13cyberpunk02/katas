public class Kata
{
  public static string Correct(string text)
  {
    text = text.Replace('0', 'O');
    text = text.Replace('1', 'I');
    text = text.Replace('5', 'S');
    return text;    
  }
}
