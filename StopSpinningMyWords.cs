using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
  public static string SpinWords(string sentence)
  {
    string[] words = sentence.Split(' ');
    for(int i = 0; i < words.Length; i++)
    {
      if(words[i].Length > 4)
      {
        char[] characters = words[i].ToCharArray();    
        Array.Reverse(characters);         
        words[i] = new string(characters);
      }        
    }
    string res = String.Join(" ", words);
    return res;    
  }
}
