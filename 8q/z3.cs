public static class Kata
{
  public static int SquareSum(int[] numbers)
  { 
    int result=0;
      for(int i=0;i<numbers.Length;i++)
       { int a=numbers[i]*numbers[i];
         result+=a;
       }
    return result;
  }
}