using System.Text;
using System;
public class Kata
{
  public static long SquareDigits(int n)
  {
    string numberString = n.ToString();
    StringBuilder result = new StringBuilder();
            for (int i = 0; i < numberString.Length; i++)
             {
                long digit = long.Parse(numberString[i].ToString());
                result.Append((digit * digit).ToString());
             }
     return long.Parse(result.ToString());
  }
}