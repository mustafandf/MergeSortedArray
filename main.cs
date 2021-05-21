using System;

class MainClass {
  public static void Main (string[] args) 
  {
    var finalMergedArray = MergeSortedArray(new long[]{2,3,4,31}, new long[]{1,7,8,100});
    foreach(var a in finalMergedArray)
    {
      Console.WriteLine(a);
    }
    Console.WriteLine("Length of finalMergedArray : {0}",finalMergedArray.Length);
  }

  private static long[] MergeSortedArray(long[] array1, long[] array2)
  {
    //Initializing length of finalMergedArray
    long[] finalMergedArray=new long[array1.Length+array2.Length];
    int i = 0;  //For array1
    int j = 0;  //For array2
    int m = 0;  //For finalMergedArray

    //We iterate over both the arrays till any of them is exhausted
    while(i<array1.Length && j<array2.Length)
    {
      if(array1[i]<array2[j])
      {
        finalMergedArray[m]=array1[i];
        i++;
      }
      else
      {
        finalMergedArray[m]=array2[j];
        j++;
      }
      m++;
    }

    //If array2 is exhausted but array1 still has elements
    if(i<array1.Length)
    {
      while(i<array1.Length)
      {
        finalMergedArray[m]=array1[i];
        m++;
        i++;
      }
    }

    //If array1 is exhausted but array2 still has elements
    if(j<array2.Length)
    {
      while(j<array2.Length)
      {
        finalMergedArray[m]=array2[j];
        m++;
        j++;
      }
    }
    
    return finalMergedArray;
  }
}