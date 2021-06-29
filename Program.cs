using System;
					
public class Program
{
	public static void Main()
	{
		string input = "";
		Console.WriteLine("Enter the input string : ");
		input = Console.ReadLine();
		if(input.Length%2 == 0) {
			Console.WriteLine("Input string is in even length");
			return;
		}
		
		int median = (input.Length)/2; 
		int spaceLength = input.Length-1;
		int currentLen = median;
		int leadingLength = 1;
		
		for(int k=0; k<input.Length; k++){
			for(int i=0; i<spaceLength;i++){
				Console.Write(" ");
			}
			for(int j = median ; j < input.Length && j<=currentLen; j++){
				Console.Write(input[j]);
			}
			
			if(k>median){
				for(int j=0; j < median && j<leadingLength; j++){
					Console.Write(input[j]);
				}
				leadingLength++;
			}
			currentLen++;
			spaceLength--;
			Console.WriteLine();
		}
	}
}
