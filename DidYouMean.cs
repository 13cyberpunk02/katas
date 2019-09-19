using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    private IEnumerable<string> words;

    public Kata(IEnumerable<string> words)
    {
        this.words = words;
    }

    public string FindMostSimilar(string term)
    {        
        string chosenWord = null;
        int similarDiff = 2147483647;
        foreach (string word in words)
        {  
          if (wordsId(word, term) < similarDiff) 
          {
            similarDiff = wordsId(word, term);
            chosenWord = word;
          }
        }
      return chosenWord;
    }
    public int wordsId(string w1, string w2)
    {
      int[,] distance = new int[w1.Length + 1, w2.Length + 1];
      for (int i = 0; i <= w1.Length; i++)
        distance[i, 0] = i;
      for (int j = 1; j <= w2.Length; j++)
        distance[0, j] = j;
      for (int i = 1; i <= w1.Length; i++)
        for (int j = 1; j <= w2.Length; j++)
          distance[i, j] = Math.Min(Math.Min(distance[i - 1, j] + 1, distance[i, j - 1] + 1), distance[i - 1, j - 1] + ((w1[i - 1] == w2[j - 1]) ? 0 : 1));

      return distance[w1.Length, w2.Length];
    }
}
