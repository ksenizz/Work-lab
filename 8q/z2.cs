using System;
public static class Kata
{
  public static int Enough(int cap, int on, int wait)
  {
    int result=wait-(cap-on);
    if(result<=0) return 0;
    else return result;
  }
}