using System.Linq;
public class Kata
{
  public static string Shortcut(string input)
  {    
    return new string(input.Where(c => !"aeiou".Contains(c)).ToArray());
  }
}
