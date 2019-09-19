using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {        
            str = str.ToLower();                                    
            List<string> mexico = new List<string>();
            char[] c = str.ToCharArray();
            for(int i = 0; i < c.Length; i++)
            {
                if(c[i].ToString() == " ")
                  continue;
                c[i] = char.ToUpper(c[i]);
                mexico.Add(new string(c));
                c[i] = char.ToLower(c[i]);
            }
            return mexico;            
        }
    }
}
