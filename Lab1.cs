using System;

namespace Numbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			PrintBanner ();
			String name = EnterName ();
			int [] numbers = RandomNumbers ();
			PrintNumbers (numbers, name);
		}

		public static void PrintBanner(){
			Console.WriteLine ("**********************************");
			Console.WriteLine ("******** Lottery Numbers *********");
			Console.WriteLine ("**********************************");
		}

		public static string EnterName(){
			Console.Write ("Enter yout name: ");
			return Console.ReadLine ();
		}

		public static int [] RandomNumbers(){
			Random random = new Random ();
			int[] numbers = new int[6] {0, 0, 0, 0, 0, 0};
			int index = 0;
			do {		
				int randomNumber = random.Next(1, 46);
				if (!HasValue(randomNumber, numbers, index)) {
					numbers[index] = randomNumber;
					index++;
				}
			} while(index < numbers.Length);

			return numbers;
		}

		public static void PrintNumbers(int [] numbers, string name){
			Console.Write ("Name : {0}, Numbers : [", name);
			foreach(int number in numbers)
			{
				Console.Write ("{0} ", number);
			}
			Console.WriteLine ("]");
		}

		public static bool HasValue(int randomNumber, int [] numbers, int index){
			bool found = false;
			for(int loop=0; loop < index; loop++)
			{
				if (numbers[loop] == randomNumber) {
					found = true;
					break;
				}
			}
			return found;
		}


	}
}
