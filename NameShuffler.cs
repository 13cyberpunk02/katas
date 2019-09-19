using System;

public class Kata
{   
  public static string NameShuffler(string str)
  {
    string[] res = str.Split(" ");
    Array.Reverse(res);    
    return string.Join(" ", res);
  }
}
