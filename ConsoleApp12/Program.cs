using System;
using System.IO;
namespace console
{
	class program
	{
		static void cheak(string path)
		{
			string[] data = File.ReadAllLines(path);
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i].StartsWith("//"))
				{
					data[i] = "";
				}
				if (data[i].StartsWith("/*"))
				{
					data[i] = "";
				}
				if (data[i].StartsWith("#define"))
				{
					data[i] = "";
				}
				if (data[i].EndsWith("*/"))
				{
					data[i] = "";
				}
			}
			for (int i = 0; i < data.Length; i++)
				Console.WriteLine(data[i]);


		}
		public static void Main()
		{
			string paths = @"C:\\Users\\AL Manar\\Desktop\\PS\\text.txt";
			cheak(paths);

		}
	}
}