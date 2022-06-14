
namespace CompuPass
{
	internal class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Console.Title = "CompuPass v0.1"; 
			while (true)
			{				
				Console.WriteLine("Press Enter to generate a new password\n");
				if (Console.ReadKey().Key == ConsoleKey.Enter)
				{
					Console.Clear();
					string pass = GeneratePass();
					Clipboard.SetText(pass);
					Console.WriteLine($"{pass}\n\nThe password has been copied to the clipboard\n");					
				}
                else{ break; }				
			}
		}		
		static string GeneratePass()
		{
			string passGen = Convert.ToString(GetLetter());
			passGen += GetNumber();
			passGen += ".";
			passGen += GetString();
			passGen += GetString();
			passGen += "!";
			return passGen;
		}
		static char GetLetter()
		{
			string alph = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			Random charRnd = new Random();
			int num = charRnd.Next(0, alph.Length);
			return alph[num];
		}
		static string GetNumber()
		{
			int numTwo = 0;
			Random numRnd = new Random();
			int numOne = numRnd.Next(10);

			if (numOne == 0)
				numTwo = 9;
			else if (numOne == 1)
				numTwo = 2;
			else
			{
				if (numRnd.Next(2) == 0)
					numTwo = numOne - 1;
				else
					numTwo = numOne + 1;				
			}

			if (numTwo == 10)
				numTwo= 0;
            

			string numbers = numOne.ToString() + numTwo.ToString();
			return numbers;
		}
		static string GetString()
		{
			string adjChar, alph;
			char charTwo = ' ';
			alph = "abcdefghijklmnopqrstuvwxyz";
			Random charRnd = new Random();
			int num = charRnd.Next(0, alph.Length);
			char charOne = alph[num];


			switch (charOne)
			{
				case 'a':
					adjChar = "qsz";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'b':
					adjChar = "vgn";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'c':
					adjChar = "xdv";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'd':
					adjChar = "esfc";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'e':
					adjChar = "drw";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'f':
					adjChar = "rdgv";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'g':
					adjChar = "fthb";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'h':
					adjChar = "gyjn";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'i':
					adjChar = "uko";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'j':
					adjChar = "uhkm";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'k':
					adjChar = "ijl";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'l':
					adjChar = "ko";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'm':
					adjChar = "jn";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'n':
					adjChar = "hbm";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'o':
					adjChar = "ipl";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'p':
					adjChar = "o";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'q':
					adjChar = "wa";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'r':
					adjChar = "eft";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 's':
					adjChar = "awdx";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 't':
					adjChar = "rgy";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'u':
					adjChar = "yji";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'v':
					adjChar = "cfb";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'w':
					adjChar = "qse";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'x':
					adjChar = "szc";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'y':
					adjChar = "thu";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				case 'z':
					adjChar = "ax";
					charTwo = adjChar[charRnd.Next(0, adjChar.Length)];
					break;
				default:
					break;
			}
			string chars = charOne.ToString() + charTwo.ToString();
			return chars;
		}
	}
}