using System;
using System.Collections.Generic;			
public class Program
{
	
	public void Main()
	{
		
	int amg_city,amg_con_city,Is_same;
	string Is_same_text;
	var true_con_list = new List<string>{};	
	var index_city = new List<int>{};
	var name_city = new List<string>{};
	var connect_city = new List<string>{};
	var contaminate_level = new List<int>{};
	amg_city = Int32.Parse(Console.ReadLine());
	
	for(int i=0;i<amg_city;i++){
		contaminate_level.Add(0);
		index_city.Add(i);
		name_city.Add(Console.ReadLine());
		amg_con_city = Int32.Parse(Console.ReadLine());
		
		for(int j=0;j<=amg_con_city;j++){
			Is_same_text = Console.ReadLine();
		
		}		
	}
		 foreach (int k in index_city){
            Console.WriteLine(index_city[k] + " " + name_city[k] + " "+ contaminate_level[k]);
		 }
	}
	}		


