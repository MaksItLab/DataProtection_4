using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int M = 26;
			int K = 4;

			string str = Console.ReadLine();
			string strClose = "";
			string strOpen = "";

			char[] arrOpentext = str.ToCharArray();
            Console.WriteLine();
			char[] arrCloseText = new char[arrOpentext.Length];
			for (int i = 0; i < arrOpentext.Length; i++)
			{
				arrCloseText[i] = (char)(((arrOpentext[i] + K) % M) + 97);
			}

			strClose = String.Concat<char>(arrCloseText);
			Console.WriteLine(strClose);

		}
	}
}
