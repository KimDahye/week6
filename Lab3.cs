//week6 lab3
//copyright DAHYE KIM
using System;

namespace Palindrome
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			Console.Write ("Enter a word: ");
			string word = Console.ReadLine ();
			bool result = IsPalindrome(word);
			printResult (result, word);

		}


		static bool IsPalindrome(string word) {

			if (word.Length >= 1)
			{
				string firstAlphabet = word.Substring (0, 1);
				string lastAlphabet = word.Substring (word.Length - 1, 1);
				int legth = word.Length;

				if (legth == 1)
				{
					return true;
				} 
				else if (firstAlphabet == lastAlphabet)
				{
					if (legth - 2 == 0)
					{
						return true;
					} 
					else 
					{
						return IsPalindrome(word.Substring(1,legth-2));
					}
				}
				else
				{
					return false;	
				}
			}
			else
			{
				return false;
			}
		}

		static void printResult(bool result, string word){
			if(result == true){
				Console.WriteLine ("'{0}' is a Palindrome.", word);
			}
			else
			{
				Console.WriteLine("'{0}' is not a Palindrome.", word);
			}

		}

	}
}
