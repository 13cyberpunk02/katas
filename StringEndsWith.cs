public class Kata
{
  public static bool Solution(string str, string ending)
  {
    if(ending.Length > str.Length)
      return false;
    string s = "";
    for(int i = str.Length - ending.Length; i < str.Length; i++)
      s += str[i].ToString(); 
    return s == ending;
  }
}
