using System;
using System.Collections.Generic;

public static class SumOfMultiples
{

    public static int Sum(IEnumerable<int> multiples, int max)
    {
        HashSet<int> uniqueSet = new HashSet<int>();
        foreach (var number in multiples){


            for(int i=1; i < max;i++){
                
            if(number > 0 ){
                if(i%number==0){
                    if (!uniqueSet.Contains(i))
                   {
                      uniqueSet.Add(i);
                   }
                }
            }
            }
        }

        int sum = 0;
        foreach (var i in uniqueSet)  
        {  
                    Console.WriteLine(i);

           sum = sum + i;
        }
        
        return sum;
        throw new NotImplementedException("You need to implement this method.");
    }

    
}
