using System;

class MainClass {
  public static void Main (string[] args) 
  {
    var finalMergedArray = MergeSortedArray(new long[]{0,3,4,31}, new long[]{});
    foreach(var a in finalMergedArray)
    {
      Console.WriteLine(a);
    }
  }

  private static long[] MergeSortedArray(long[] array1, long[] array2)
  {
    long[] finalMergedArray=new long[array1.Length+array2.Length];
    int i = 0;
    int j = 0;
    int m = 0;
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

    if(i<array1.Length)
    {
      while(i<array1.Length)
      {
        finalMergedArray[m]=array1[i];
        m++;
        i++;
      }
    }
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