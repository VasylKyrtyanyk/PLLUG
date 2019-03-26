using System;


namespace Fibonacci
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Output n Fibonacci numbers Enter 1 \n0" +
							  "Print Fibonacci numbers to a given number Enter 2 ");


			
			Print_numbers_Fibonatchi();

			Console.ReadKey();

		}

		public static int Fibonatchi(int position)
		{

			if (position == 0)
			{
				return 1;
			}
			if (position == 1)
			{
				return 1;
			}
			else
			{
				
				return Fibonatchi(position - 2) + Fibonatchi(position - 1);
			}
		}

		public static void Print_numbers_Fibonatchi()
		{
			Console.WriteLine("Enter k");
			int k = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter n");
			int n = Convert.ToInt32(Console.ReadLine());


			switch (k)
			{
				case 1:
				{
					for (int i = 0; i < n; i++)
					{
						Console.WriteLine(Fibonatchi(i));
					}

					break;
				}
				case 2:
				{
					int temp = 1;
					int i = 0;
					while (true)
					{
						temp = Fibonatchi(i);
						if (temp > n)
						{
							break;
						}

						Console.WriteLine(temp);
						i++;
					}

					break;
				}
			}
		}

	

	}
}
