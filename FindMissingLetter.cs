using System;

public class Kata
{
  public static char FindMissingLetter(char[] array)
  {
    char[] letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ".ToCharArray();
    int index = Array.IndexOf(letters, array[0]);
    char res = ' ';
    for(int i = index; i < letters.Length; i++)
    {
      if(!Array.Exists(array, element => element == letters[i]))
        {
          res = letters[i];
          break;
        }
    }
    return res;
  }
}
