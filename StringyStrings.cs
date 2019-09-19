public class Kata
{
  public static string Stringy(int size)
  {
    string res = "";
    for(int i = 0; i < size; i++)
    {
      if(i % 2 == 0)
       res += "1";      
      else
       res += "0";
    }
    return res;
  }
}
