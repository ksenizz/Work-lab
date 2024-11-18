using System;
public static class Kata
{
    public static string Disemvowel(string str)
    {
       string result = "";
       string eva = "aeiouAEIOU";
         for (int i = 0; i < str.Length; i++)
           {
                char char_adam = str[i];
                bool adam = eva.Contains(char_adam);
                   if (!adam)
                      {
                       result += char_adam;
                      }
           }
        return result;
    }
}