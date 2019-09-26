namespace Kata
{
  public static class Problem
  {
    public static string CamelCase(this string str)  
    {  
      string[] res = str.Split(' ');
      string output = "";
      foreach(var x in res)
        for(int i = 0; i < x.Length; i++)
          output += (i == 0) ? x[i].ToString().ToUpper() : x[i].ToString();          
      return output;
    }
  }
}
