public class Kata
{
  public static double[] Multiples(int m, double n)
  {
    double [] eva= new double [m];
      for (int i = 0; i < m; i++)
         {  
             eva[i] = n *(i+1);
         }
          return eva;
  }
}