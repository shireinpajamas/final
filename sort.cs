using System;
using System.Collections.Generic;					
public class Program
{
	int[] num={0,0,0,0,0,0};
	public void Main()
	{
	
	for(int i=0;i<6;i++){
		num[i] = Int32.Parse(Console.ReadLine());
	}
		bubblesort();
		list_sort();
		arr_sort();
		insertion_sort();
	}
	
	public void bubblesort(){
         int temp;
         for (int j = 0; j <= num.Length - 2; j++) {
            for (int i = 0; i <= num.Length - 2; i++) {
               if (num[i] > num[i + 1]) {
                  temp= num[i + 1];
                  num[i + 1] = num[i];
                  num[i] = temp;
               }
            }
         }
         Console.WriteLine("bubble's Sort:");
         foreach (int k in num)
            Console.Write(k + " ");
		
		Console.WriteLine();
      }
	 public void list_sort(){
		var nums = new List<int> {};
		 for(int i=0;i<6;i++){
			 nums.Add(num[i]);
		 }
		 nums.Sort();
		 Console.WriteLine("list's Sort: \n"+string.Join(" ", nums));
	}
	public void arr_sort(){
		Array.Sort(num);
		Console.WriteLine("Array's Sort:");
         foreach (int k in num)
            Console.Write(k + " ");
	}
	public void insertion_sort(){
	{
    int i, key, j;
    for (i=1;i<6;i++){
        key = num[i];
        j = i - 1;
        while (j >= 0 && num[j] > key)
        {
            num[j + 1] = num[j];
            j = j - 1;
        }
        num[j + 1] = key;
    }
		Console.WriteLine("insertion's Sort:\n");
		foreach (int k in num)
            Console.Write(k + " ");
	}	
	}
	}

