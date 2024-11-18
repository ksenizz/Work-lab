public static class Kata
    {
      public static object[] RemoveEveryOther(object[] arr)
        {         
       object []new_eva= new object[(arr.Length+1)/2];
       int j = 0;
        for (int i = 0; i < arr.Length; i++) 
           {
               if (i % 2 == 0) 
                 {
                     new_eva[j] = arr[i];
                     j++;
                 }
            }
        return new_eva;
        }    
   }